# Modelo de dominio propuesto

Este documento define el modelo conceptual, no el esquema SQL definitivo.

## Agregado Capacitación

### `Capacitacion`
Campos conceptuales:
- `Id: UUID`
- `TipoCapacitacionId`
- `Titulo`
- `Descripcion`
- `CupoMaximo`
- `PoliticaCupoCompleto`
- `PorcentajeAsistenciaRequerida`
- `Estado`
- `PermiteAutodescargaCertificado` o equivalente derivado del estado de certificados
- timestamps
- soft delete

Relaciones:
- 1..N Jornadas
- 0..N Expositores
- 0..N PreciosPorTipoInscripcion
- 0..N AsignacionesRolCapacitacion
- 0..N Inscripciones
- 0..N Plantillas/Versiones de certificado

### `Jornada`
- `Id`
- `CapacitacionId`
- `Fecha`
- `HoraInicio`
- `HoraFin`
- `Lugar`
- orden opcional

### `TipoCapacitacion`
Catálogo:
- `Id`
- `Nombre`
- `Descripcion`
- `Activo`
- soft delete

### `Expositor`
- `Id`
- `Nombre`
- `Apellido`
- `Bio`
- `Institucion`
- `Cargo`
- `FotoAssetId`
- `UsuarioId?`

La cuenta es opcional.

## Agregado Usuario

### `Usuario`
- `Id: UUID`
- `FirebaseUid?`
- `Nombre`
- `Apellido`
- `Dni`
- `Email`
- `Telefono`
- `Institucion`
- `Localidad`
- `Provincia`
- `Domicilio`
- `EmailVerificado` como dato sincronizado/consultado según estrategia
- soft delete

Restricciones:
- DNI normalizado con índice para vinculación.
- FirebaseUid único cuando existe.
- Email normalizado con índice apropiado.

## Roles

### `RolGlobalUsuario`
- `UsuarioId`
- `RolGlobal`

### `AsignacionRolCapacitacion`
- `Id`
- `UsuarioId`
- `CapacitacionId`
- `RolContextual`
- `AsignadoPor`
- `FechaAsignacion`
- `RevocadoEn?`

## Inscripciones

### `TipoInscripcion`
Catálogo configurable:
- `Id`
- `Nombre`
- `Descripcion`
- `Activo`

### `PrecioCapacitacion`
- `CapacitacionId`
- `TipoInscripcionId`
- `Importe`

### `Inscripcion`
- `Id`
- `CapacitacionId`
- `UsuarioId?`
- `PersonaTemporalId?` o snapshot de persona según diseño definitivo
- `TipoInscripcionId`
- `TipoInscripcionNombreSnapshot`
- `PrecioAplicado`
- `Origen`
- `Estado`
- `FechaInscripcion`
- `FechaCancelacion?`

Debe existir una estrategia explícita para inscripción presencial sin cuenta.

Recomendación de diseño:
- crear una entidad `Persona` independiente de `CuentaUsuario`, o
- permitir `Usuario` sin `FirebaseUid`.

La segunda opción simplifica vinculación: toda persona registrada presencialmente crea un `Usuario` interno sin identidad Firebase y posteriormente se vincula la cuenta.

### `ListaEspera`
Puede modelarse como entidad propia:
- `Id`
- `CapacitacionId`
- `UsuarioId`
- `Posicion/FechaIngreso`
- `Estado`
- `PromovidoEn?`

Debe soportar bloqueo/transacción durante promoción.

## Asistencia

### `Asistencia`
- `Id`
- `InscripcionId`
- `JornadaId`
- `Estado`
- `RegistradoPor`
- `RegistradoEn`
- `AnuladoEn?`
- `MotivoCorreccion?`

Restricción:
- una asistencia activa por inscripción+jornada.

El porcentaje se calcula sobre jornadas computables.

## Pagos

### `Pago`
- `Id`
- `InscripcionId`
- `Monto`
- `Medio`
- `Estado`
- `FechaPago`
- `RegistradoPor?`
- `ValidadoPor?`
- `ValidadoEn?`
- `Observaciones`
- `ComprobanteAssetId?`
- `AnuladoEn?`

Estados propuestos:
- `PENDIENTE_VALIDACION`
- `APROBADO`
- `RECHAZADO`
- `ANULADO`

Para efectivo puede crearse directamente como aprobado.

## Certificados

### `PlantillaCertificado`
- `Id`
- `CapacitacionId`
- `AssetId`
- `Version`
- `Activa`

### `CampoPlantilla`
- `Id`
- `PlantillaId`
- `Token`
- `X`
- `Y`
- `Width?`
- `Height?`
- `FontFamily?`
- `FontSize?`
- `Alignment?`

El editor de plantilla debe ofrecer una experiencia formal y profesional orientada a documentos académicos. Como mínimo cada campo dinámico podrá configurar: familia tipográfica desde un catálogo controlado, tamaño, peso, estilo, color, alineación horizontal, ancho/alto del área, interlineado cuando corresponda y coordenadas exactas. El editor debe incorporar previsualización sobre la plantilla real, guías/alineación y reproducción fiel en el PDF final. Se priorizan composiciones sobrias, jerarquía tipográfica académica y legibilidad; no se requieren efectos decorativos propios de un editor gráfico generalista.

### `Certificado`
- `Id`
- `InscripcionId`
- `CodigoUnico`
- `Estado`
- `PdfAssetPath?` o generación bajo demanda según decisión
- `GeneradoEn`
- `HabilitadoEn?`
- `RevocadoEn?`
- `RevocadoPor?`

`CodigoUnico`: formato `XXXXXXXX-DDMMAAAA-DNI`. El segmento inicial se deriva de los primeros ocho caracteres alfanuméricos del nombre normalizado de la capacitación; `DDMMAAAA` corresponde a la fecha de la jornada inicial; `DNI` se persiste sin puntos ni separadores. El valor generado se considera inmutable después de la emisión.

## Archivos

### `Asset`
- `Id`
- `StoragePath`
- `PublicUrl?`
- `MimeType`
- `Size`
- `Category`
- `Visibility`
- `Version`
- `CreatedAt`
- `CreatedBy?`

## Auditoría

### `AuditEntry`
- `Id`
- `ActorUsuarioId?`
- `FirebaseUid?`
- `Action`
- `EntityType`
- `EntityId`
- `OccurredAtUtc`
- `OldValuesJson?`
- `NewValuesJson?`
- `IpAddress?`
- `CorrelationId?`

## Consideraciones de concurrencia

Las operaciones de cupo y lista de espera deben ejecutarse dentro de transacciones y proteger la invariante:

```text
inscripciones_confirmadas_activas <= cupo_maximo
```

No basta con consultar cupo y luego insertar sin control transaccional.
