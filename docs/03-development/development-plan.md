# Plan técnico de desarrollo

## 1. Estrategia

El sistema se reconstruye mediante **vertical slices funcionales** sobre una arquitectura estable.

No migrar pantalla por pantalla desde WinForms. Migrar capacidades del negocio.

Cada slice debe incluir, cuando aplique:

```text
Dominio
→ Caso de uso
→ Persistencia
→ API
→ Autorización
→ Auditoría
→ Tests
→ Frontend
→ Documentación
```

## 2. Convención de trabajo con OpenCode

Antes de implementar una tarea, el agente debe:

1. identificar `RF-*` y `CA-*`;
2. leer reglas `RN-*`;
3. revisar ADRs relevantes;
4. listar archivos que espera modificar;
5. implementar el cambio mínimo coherente;
6. agregar pruebas;
7. ejecutar checks;
8. reportar decisiones no especificadas como bloqueo/TBD.

El agente **no debe inventar reglas de negocio**.

## 3. Granularidad recomendada de issues

Ejemplo F3:

```text
F3-01 Crear entidad TipoCapacitacion
F3-02 CRUD API TipoCapacitacion
F3-03 UI catálogo de tipos
F3-04 Crear agregado Capacitacion
F3-05 Crear Jornada y creación inicial atómica
F3-06 Estados y transiciones
F3-07 Precios por tipo de inscripción
F3-08 Gestión de expositores
F3-09 Upload de flyer
F3-10 Portal público listado paginado
F3-11 Portal público detalle
F3-12 Tests de integración
```

Evitar issues como “hacer módulo capacitaciones completo”.

## 4. Política de ramas

```text
feature/<issue>-descripcion
fix/<issue>-descripcion
refactor/<issue>-descripcion
docs/<issue>-descripcion
```

## 5. Pull Requests

Todo PR:
- pequeño;
- vinculado a issue/requisito;
- con descripción;
- con evidencia de tests;
- con migración si aplica;
- sin cambios no relacionados.

## 6. Testing

### Dominio
Pruebas rápidas sin infraestructura.

### Application
Casos de uso con puertos mock/fake cuando corresponda.

### Integration
Usar PostgreSQL real aislado en CI, preferentemente containerizado durante tests.

Casos críticos:
- autenticación;
- autorización contextual;
- cupo concurrente;
- lista de espera;
- pagos;
- certificados;
- auditoría.

### Frontend
- componentes críticos;
- validaciones;
- navegación;
- flujos E2E seleccionados.

## 7. Base de datos

No hay datos reales que preservar.

Consecuencia:
- crear migraciones limpias;
- no arrastrar esquema histórico;
- generar seed únicamente para desarrollo/testing;
- no copiar decisiones accidentales del modelo anterior.

## 8. Migración funcional desde aplicaciones históricas

Utilizar WinForms/Blazor/MAUI como referencia de:
- flujos;
- vocabulario;
- funcionalidades ya exploradas.

No reutilizar automáticamente:
- estructuras CRUD;
- DTOs existentes;
- GenericService;
- handlers;
- modelos;
- esquema DB.

Cada pieza reutilizada debe cumplir la arquitectura nueva.

## 9. Despliegue

Producción:
- VPS;
- PostgreSQL alojado en VPS;
- `agora-api` Docker;
- `agora-web` Docker;
- reverse proxy;
- TLS.

No incluir PostgreSQL en `docker-compose` productivo si la DB se administra como servicio del VPS.

Para Development/CI sí puede utilizarse PostgreSQL containerizado para reproducibilidad.

## 10. Ambientes

### Development
- emulaciones o proyecto Firebase de desarrollo;
- DB local/container;
- datos seed.

### Testing/CI
- credenciales mínimas;
- DB efímera;
- tests automatizados.

### Production
- secretos separados;
- Firebase proyecto productivo;
- DB productiva;
- backups.

## 11. Decisiones previamente pendientes — resueltas

### `TBD-001` Código de certificado — RESUELTO
Formato oficial: `XXXXXXXX-DDMMAAAA-DNI`.

- `XXXXXXXX`: primeros ocho caracteres alfanuméricos del nombre de la capacitación normalizado a mayúsculas, sin tildes, espacios ni signos; si el valor normalizado posee menos de ocho caracteres se utiliza completo.
- `DDMMAAAA`: fecha de la jornada inicial.
- `DNI`: DNI normalizado sin puntos ni separadores.
- el valor es inmutable una vez emitido el certificado.

### `TBD-002` Vinculación por DNI — RESUELTO
La coincidencia de DNI es suficiente para vincular automáticamente una futura cuenta con inscripciones presenciales cargadas previamente por un administrativo. No existe un segundo factor de validación. La decisión y su riesgo de suplantación quedan aceptados y documentados; toda vinculación debe auditarse.

### `TBD-003` Certificado PDF — RESUELTO
El editor de plantillas tendrá una interfaz formal y profesional orientada a formatos académicos. Debe permitir posicionamiento visual de tokens, controles tipográficos esenciales, alineación, dimensiones, guías y previsualización fiel del PDF. Se prioriza sobriedad y legibilidad y se excluyen efectos decorativos innecesarios.

No quedan TBD funcionales abiertos derivados de estos tres puntos.
