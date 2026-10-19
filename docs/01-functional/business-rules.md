# Reglas de negocio

## Capacitaciones

- `RN-CAP-001`: toda capacitación debe pertenecer a un tipo de capacitación configurable.
- `RN-CAP-002`: toda capacitación se crea con una jornada inicial.
- `RN-CAP-003`: una capacitación puede contener una o más jornadas.
- `RN-CAP-004`: la modalidad soportada inicialmente es exclusivamente presencial.
- `RN-CAP-005`: una capacitación puede tener cero, uno o varios expositores.
- `RN-CAP-006`: un expositor puede existir sin cuenta Ágora.
- `RN-CAP-007`: los estados válidos son `BORRADOR`, `PUBLICADA`, `INSCRIPCION_ABIERTA`, `INSCRIPCION_CERRADA`, `EN_CURSO`, `FINALIZADA`, `CANCELADA`, `ARCHIVADA`.
- `RN-CAP-008`: las transiciones de estado deben validarse por dominio; no se acepta asignación arbitraria.

## Cupos y lista de espera

- `RN-CUP-001`: el cupo es global por capacitación.
- `RN-CUP-002`: la política al completar cupo es configurable por capacitación.
- `RN-CUP-003`: las políticas iniciales son `CERRAR_INSCRIPCION` y `LISTA_ESPERA`.
- `RN-CUP-004`: una cancelación válida libera inmediatamente un lugar.
- `RN-CUP-005`: si existe lista de espera, la primera persona de la cola obtiene automáticamente el lugar liberado.
- `RN-CUP-006`: la promoción desde lista de espera debe ser transaccional para evitar sobrecupo.
- `RN-CUP-007`: la arquitectura deberá permitir notificar promociones mediante Firebase Cloud Messaging en una fase posterior.

## Inscripciones

- `RN-INS-001`: la inscripción online requiere autenticación.
- `RN-INS-002`: se prohíben dos inscripciones vigentes para el mismo usuario y capacitación.
- `RN-INS-003`: una inscripción puede cancelarse por el participante hasta 24 horas antes del inicio aplicable de la capacitación.
- `RN-INS-004`: administración puede registrar inscripciones presenciales para personas sin cuenta.
- `RN-INS-005`: una inscripción presencial sin cuenta debe registrar DNI y datos mínimos de persona.
- `RN-INS-006`: cuando la persona crea posteriormente una cuenta e informa un DNI coincidente con una persona registrada previamente por un administrativo, Ágora vincula automáticamente a esa cuenta las inscripciones presenciales asociadas a ese DNI. No se exige una verificación adicional de identidad para esta vinculación; esta decisión constituye un riesgo de negocio aceptado y debe quedar auditada.
- `RN-INS-007`: el tipo de inscripción pertenece a la inscripción, no al usuario.
- `RN-INS-008`: el precio se congela al crear la inscripción.
- `RN-INS-009`: el tipo de inscripción proviene de un catálogo configurable.
- `RN-INS-010`: el sistema debe conservar origen de inscripción: online o presencial.

## Pagos

- `RN-PAG-001`: los medios iniciales son `EFECTIVO` y `TRANSFERENCIA`.
- `RN-PAG-002`: una inscripción admite cero o más pagos.
- `RN-PAG-003`: no existen becas, descuentos ni bonificaciones en el alcance inicial.
- `RN-PAG-004`: una transferencia requiere comprobante almacenado de forma privada.
- `RN-PAG-005`: una transferencia inicia como `PENDIENTE_VALIDACION`.
- `RN-PAG-006`: una transferencia puede pasar a `APROBADA` o `RECHAZADA`.
- `RN-PAG-007`: administración institucional y usuarios con permiso contextual de cobro pueden validar transferencias.
- `RN-PAG-008`: los pagos no se eliminan físicamente; pueden anularse preservando trazabilidad.
- `RN-PAG-009`: no se implementa módulo de caja.

## Asistencia

- `RN-ASI-001`: acreditación significa asistencia.
- `RN-ASI-002`: la asistencia se registra por jornada.
- `RN-ASI-003`: el porcentaje mínimo de asistencia requerido para certificado es configurable por capacitación.
- `RN-ASI-004`: sólo personal autorizado puede registrar o corregir asistencia.
- `RN-ASI-005`: las modificaciones de asistencia se auditan.

## Certificados

- `RN-CER-001`: el formato final es PDF.
- `RN-CER-002`: la plantilla base es una imagen JPG/PNG.
- `RN-CER-003`: la plantilla define posiciones configurables para campos dinámicos.
- `RN-CER-004`: campos inicialmente previstos: `{{nombreCompleto}}`, `{{dni}}`, `{{capacitacion}}`, `{{fecha}}`, `{{cargaHoraria}}`.
- `RN-CER-005`: firmas, logos y textos estáticos pueden estar incorporados en la imagen de plantilla.
- `RN-CER-006`: cada certificado posee un código único.
- `RN-CER-007`: el código del certificado se construye con el formato `XXXXXXXX-DDMMAAAA-DNI`.
  - `XXXXXXXX`: primeros ocho caracteres alfanuméricos del nombre de la capacitación normalizado a mayúsculas, sin tildes, espacios ni signos. Si el nombre normalizado posee menos de ocho caracteres, se utiliza completo sin agregar caracteres artificiales.
  - `DDMMAAAA`: fecha de la jornada inicial de la capacitación.
  - `DNI`: DNI del asistente, normalizado sin puntos ni separadores.
  - Ejemplo conceptual: `PROGRAMAC-31082026-30123456`.
  - La construcción debe ser determinística e inmutable una vez emitido el certificado.
- `RN-CER-008`: cada certificado incluye QR de validación pública.
- `RN-CER-009`: estados: `NO_GENERADOS`, `EN_REVISION`, `HABILITADOS`, `REVOCADOS`.
- `RN-CER-010`: sólo certificados habilitados y cuyos requisitos se cumplan pueden ser descargados por el participante.
- `RN-CER-011`: un certificado revocado conserva historial.
- `RN-CER-012`: para capacitaciones con costo, el certificado requiere pago suficiente/aprobado además de asistencia.
- `RN-CER-013`: para capacitaciones gratuitas, sólo se exige asistencia requerida.
- `RN-CER-014`: el área administrativa puede gestionar generación individual y masiva.

## Usuarios

- `RN-USR-001`: `UsuarioId` es UUID interno.
- `RN-USR-002`: `FirebaseUid` identifica la identidad técnica.
- `RN-USR-003`: DNI es dato de negocio y no PK.
- `RN-USR-004`: email debe estar verificado para las operaciones protegidas definidas.
- `RN-USR-005`: acceso mediante email/contraseña y Google.
- `RN-USR-006`: los administradores sólo pueden ser promovidos por administradores autorizados.
- `RN-USR-007`: nombre y teléfono pueden editarse con validaciones.
- `RN-USR-008`: DNI queda restringido una vez que existan operaciones sensibles; su cambio requerirá validación administrativa.

## Archivos

- `RN-STO-001`: Firebase Storage almacena archivos.
- `RN-STO-002`: PostgreSQL almacena URL/referencia, metadata y vínculo de negocio.
- `RN-STO-003`: fotos de expositores y flyers pueden ser públicos.
- `RN-STO-004`: comprobantes de pago son privados.
- `RN-STO-005`: deben conservarse versiones históricas de flyers y plantillas.

## Auditoría

- `RN-AUD-001`: auditoría incluida desde MVP.
- `RN-AUD-002`: registra actor, acción, entidad, fecha/hora, valores anterior/nuevo e IP cuando esté disponible.
- `RN-AUD-003`: pagos, asistencias, certificados, roles, capacitaciones e inscripciones son auditables.
- `RN-AUD-004`: la auditoría no debe depender del frontend.

## Eliminación

- `RN-DEL-001`: usuarios, capacitaciones y catálogos utilizan soft delete.
- `RN-DEL-002`: pagos y asistencias se anulan, no se borran.
- `RN-DEL-003`: certificados se revocan, no se borran.
