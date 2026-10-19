# Especificación funcional del sistema

## 1. Módulos

### `MOD-PUB` Portal público
Permite descubrir la oferta de capacitaciones sin autenticación.

Funciones:
- landing institucional;
- listado de capacitaciones;
- detalle;
- flyer;
- expositores;
- jornadas;
- lugar;
- disponibilidad de cupo;
- precios por tipo de inscripción;
- historial de capacitaciones pasadas;
- acceso a inscripción;
- validación pública de certificados.

### `MOD-AUT` Autenticación
- registro con email/contraseña;
- login con email/contraseña;
- login con Google;
- verificación de email;
- cierre de sesión;
- vinculación con perfil interno.

### `MOD-USR` Usuarios y perfiles
Datos:
- nombre;
- apellido;
- DNI;
- email;
- teléfono;
- institución;
- localidad;
- provincia;
- domicilio.

Funciones:
- ver perfil;
- editar datos permitidos;
- gestión administrativa;
- soft delete;
- restauración;
- vinculación de registros presenciales por DNI.

### `MOD-CAT` Catálogos
Catálogos administrables:
- tipos de capacitación;
- tipos de inscripción.

No deben modelarse como enums rígidos cuando deban ser ampliables por administración.

### `MOD-CAP` Capacitaciones
Funciones:
- alta;
- edición;
- soft delete/restauración;
- estado;
- cupo;
- política ante cupo completo;
- porcentaje de asistencia requerido;
- configuración de certificados;
- configuración de precios por tipo de inscripción;
- asignación de expositores;
- asignación de responsables;
- publicación.

### `MOD-JOR` Jornadas
- creación automática de primera jornada;
- agregar jornadas;
- editar jornada;
- ordenar cronológicamente;
- fecha;
- hora de inicio;
- hora de finalización;
- lugar.

### `MOD-EXP` Expositores
- alta sin cuenta;
- nombre;
- apellido;
- biografía;
- institución;
- cargo;
- fotografía;
- asignación múltiple a capacitaciones.

### `MOD-RBAC` Roles y permisos
- roles globales;
- roles por capacitación;
- asignación;
- revocación;
- validación backend;
- auditoría.

### `MOD-INS` Inscripciones
- inscripción online;
- inscripción presencial;
- congelamiento de tipo/precio;
- estado;
- cancelación;
- consulta;
- búsqueda;
- origen;
- validación de duplicados.

### `MOD-ESP` Lista de espera
- alta automática cuando cupo completo y política habilitada;
- orden de ingreso;
- promoción automática;
- reserva transaccional de cupo;
- evento de dominio para notificación futura.

### `MOD-ASI` Asistencia
- listado por capacitación/jornada;
- búsqueda por DNI;
- búsqueda por apellido;
- botón presente;
- correcciones auditadas;
- cálculo de porcentaje global.

### `MOD-PAG` Pagos
- múltiples pagos por inscripción;
- efectivo;
- transferencia;
- carga de comprobante;
- validación/rechazo;
- observaciones;
- usuario registrador;
- anulación;
- estado de deuda.

### `MOD-CER` Certificados
- plantilla;
- campos posicionables;
- generación individual;
- generación masiva;
- PDF;
- código único;
- QR;
- estado;
- habilitación de descarga;
- revocación;
- validación pública.

### `MOD-MIA` Mi Ágora
```text
Mi perfil

Mis capacitaciones
├── Próximas
├── En curso
└── Finalizadas

Mis inscripciones
├── estado
├── pago
├── comprobante
└── asistencia

Mis certificados
├── disponible
├── descargar
└── verificar
```

### `MOD-REP` Reportes y dashboard
Formatos:
- vista web;
- PDF;
- Excel/CSV.

Dashboard por capacitación:
- cupo;
- inscriptos;
- acreditados;
- pagaron;
- pendientes;
- recaudado;
- certificados emitidos.

Reporte económico institucional:
- capacitación;
- fechas;
- cobrado;
- por cobrar;
- efectivo;
- transferencia;
- usuario que registró cada pago.

### `MOD-AUD` Auditoría
Consulta administrativa de acciones críticas.

### `MOD-STO` Archivos
- flyers;
- fotos;
- comprobantes;
- plantillas;
- versiones;
- políticas de acceso.

## 2. Requisitos funcionales principales

### Capacitaciones
- `RF-CAP-001` Crear capacitación con jornada inicial.
- `RF-CAP-002` Editar capacitación.
- `RF-CAP-003` Gestionar estados.
- `RF-CAP-004` Configurar cupo global.
- `RF-CAP-005` Configurar política de lista de espera.
- `RF-CAP-006` Configurar porcentaje requerido de asistencia.
- `RF-CAP-007` Publicar capacitación.
- `RF-CAP-008` Consultar capacitaciones públicas pasadas y futuras.

### Jornadas
- `RF-JOR-001` Agregar jornadas.
- `RF-JOR-002` Editar jornadas.
- `RF-JOR-003` Validar cronología y horarios.

### Inscripciones
- `RF-INS-001` Inscripción online autenticada.
- `RF-INS-002` Inscripción presencial por personal autorizado.
- `RF-INS-003` Evitar inscripción vigente duplicada.
- `RF-INS-004` Controlar cupo de forma consistente ante concurrencia.
- `RF-INS-005` Cancelar hasta 24 h antes.
- `RF-INS-006` Liberar cupo al cancelar.
- `RF-INS-007` Vincular automáticamente inscripciones presenciales futuras por coincidencia exclusiva de DNI, sin comprobación adicional y con auditoría.
- `RF-INS-008` Congelar tipo y precio aplicado.

### Lista de espera
- `RF-ESP-001` Encolar al superar cupo si la política está habilitada.
- `RF-ESP-002` Mantener orden.
- `RF-ESP-003` Promover automáticamente ante liberación.
- `RF-ESP-004` Emitir evento notificable para futura integración FCM.

### Asistencia
- `RF-ASI-001` Listar inscriptos por jornada.
- `RF-ASI-002` Buscar por DNI o apellido.
- `RF-ASI-003` Marcar presente.
- `RF-ASI-004` Calcular porcentaje.
- `RF-ASI-005` Auditar cambios.

### Pagos
- `RF-PAG-001` Registrar efectivo.
- `RF-PAG-002` Registrar transferencia.
- `RF-PAG-003` Subir comprobante privado.
- `RF-PAG-004` Validar/rechazar transferencia.
- `RF-PAG-005` Admitir pagos parciales/múltiples.
- `RF-PAG-006` Calcular saldo.
- `RF-PAG-007` Anular pago preservando historial.

### Certificados
- `RF-CER-001` Gestionar plantilla JPG/PNG.
- `RF-CER-002` Configurar campos, coordenadas y presentación tipográfica mediante un editor visual formal orientado a certificados académicos.
- `RF-CER-003` Generar PDF individual.
- `RF-CER-004` Generar lote.
- `RF-CER-005` Verificar requisitos.
- `RF-CER-006` Generar código único inmutable con formato `XXXXXXXX-DDMMAAAA-DNI`.
- `RF-CER-007` Generar QR de validación.
- `RF-CER-008` Habilitar descarga.
- `RF-CER-009` Descargar desde Mi Ágora.
- `RF-CER-010` Revocar.
- `RF-CER-011` Validar públicamente.

### Roles
- `RF-RBAC-001` Gestionar roles globales.
- `RF-RBAC-002` Gestionar roles por capacitación.
- `RF-RBAC-003` Aplicar políticas backend.
- `RF-RBAC-004` Auditar asignaciones.

### Reportes
- `RF-REP-001` Dashboard de capacitación.
- `RF-REP-002` Reporte de inscriptos.
- `RF-REP-003` Reporte de asistencia.
- `RF-REP-004` Reporte de pagos.
- `RF-REP-005` Reporte económico institucional.
- `RF-REP-006` Exportar PDF.
- `RF-REP-007` Exportar Excel/CSV.

## 3. Requisitos no funcionales clave

- `RNF-SEC-001`: todas las operaciones privadas requieren JWT Firebase válido.
- `RNF-SEC-002`: la autorización se resuelve en backend.
- `RNF-PERF-001`: listados administrativos paginados.
- `RNF-PERF-002`: consultas filtrables y ordenables.
- `RNF-API-001`: ProblemDetails para errores HTTP.
- `RNF-API-002`: OpenAPI actualizado.
- `RNF-OBS-001`: logging estructurado.
- `RNF-OBS-002`: health checks.
- `RNF-AUD-001`: operaciones críticas auditadas.
- `RNF-DEP-001`: backend y frontend dockerizables.
- `RNF-CI-001`: pipeline automático de calidad.
