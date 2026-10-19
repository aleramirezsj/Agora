# Roadmap de implementación

El roadmap prioriza construir primero las bases que reducen retrabajo.

## F0 — Bootstrap y gobierno técnico

Objetivo: repositorio limpio y ejecutable.

Entregables:
- solución .NET nueva;
- aplicación Next.js nueva;
- estructura hexagonal;
- Dockerfiles;
- configuración por ambientes;
- PostgreSQL;
- EF Core inicial;
- GitHub Actions;
- format/lint;
- testing base;
- OpenAPI;
- ProblemDetails;
- logging;
- health checks;
- documentación `/docs`.

Salida:
- API y web ejecutan en Development;
- pipeline de PR verde.

## F1 — Identidad, usuarios y RBAC global

Entregables:
- Firebase Auth frontend;
- Firebase Admin validation backend;
- entidad Usuario;
- vínculo FirebaseUid;
- perfil;
- roles globales;
- policies;
- administración básica de usuarios;
- soft delete;
- auditoría inicial.

Requisitos:
- `RF-RBAC-001`
- parte de `MOD-AUT`
- parte de `MOD-USR`

## F2 — Catálogos y vinculación por DNI

Entregables:
- tipos de capacitación;
- tipos de inscripción;
- persona creada presencialmente sin cuenta;
- vinculación automática posterior exclusivamente por coincidencia de DNI;
- auditoría de la vinculación;
- idempotencia para evitar duplicados;
- restricciones para cambio de DNI.

Decisión cerrada:
- no se exige una validación adicional de identidad para la vinculación por DNI; el riesgo asociado se registra como decisión de producto.

## F3 — Capacitaciones, jornadas, expositores y publicación

Entregables:
- CRUD administrativo;
- estados;
- jornada inicial automática;
- jornadas adicionales;
- expositores;
- imágenes;
- precios por tipo;
- cupo;
- política cupo completo;
- porcentaje requerido;
- portal público listado/detalle;
- historial.

Requisitos:
- `RF-CAP-*`
- `RF-JOR-*`

## F4 — Roles contextuales por capacitación

Entregables:
- asignación de organizador;
- acreditador;
- cobrador;
- gestor certificados;
- policies contextuales;
- pantallas administrativas;
- auditoría.

Requisitos:
- `RF-RBAC-002..004`

## F5 — Inscripción online y presencial

Entregables:
- flujo autenticado;
- inscripción presencial;
- precio congelado;
- tipo congelado;
- control de duplicados;
- paginación;
- filtros;
- cancelación hasta 24 h;
- Mi Ágora inicial.

Requisitos:
- `RF-INS-*`

## F6 — Cupos y lista de espera

Entregables:
- control transaccional de cupo;
- comportamiento configurable;
- cola;
- promoción automática;
- evento de dominio;
- prueba de concurrencia.

Requisitos:
- `RF-ESP-*`

Nota:
Firebase Cloud Messaging queda preparado arquitectónicamente pero puede integrarse en F13.

## F7 — Asistencia por jornada

Entregables:
- listado;
- filtros DNI/apellido;
- botón presente;
- control por rol;
- edición/corrección;
- porcentaje;
- auditoría.

Requisitos:
- `RF-ASI-*`

## F8 — Pagos

Entregables:
- efectivo;
- pagos múltiples;
- transferencia;
- carga privada;
- validación;
- rechazo;
- saldo;
- anulación;
- auditoría;
- sección Mi Ágora.

Requisitos:
- `RF-PAG-*`

## F9 — Motor de certificados

Entregables:
- plantillas;
- versionado;
- editor visual formal de plantilla orientado a certificados académicos;
- coordenadas, tipografía, alineación y previsualización;
- tokens;
- generación PDF;
- QR;
- código único `XXXXXXXX-DDMMAAAA-DNI`;
- validación pública;
- generación individual/masiva;
- estados;
- descarga;
- revocación.

Requisitos:
- `RF-CER-*`

Decisiones cerradas:
- código único `XXXXXXXX-DDMMAAAA-DNI`;
- editor con presentación formal/profesional y criterios tipográficos académicos.

## F10 — Reportes y dashboard

Entregables:
- dashboard de capacitación;
- inscriptos;
- asistencia;
- pagos;
- económico institucional;
- PDF;
- Excel/CSV.

Requisitos:
- `RF-REP-*`

## F11 — Auditoría administrativa completa

Aunque la captura de auditoría existe desde F1, en esta fase se completa:
- navegador de auditoría;
- filtros;
- búsqueda;
- detalle before/after;
- permisos;
- exportación si se requiere.

## F12 — Hardening de producción

- rate limiting final;
- CORS productivo;
- backups DB;
- health/readiness;
- reverse proxy;
- headers;
- secretos;
- límites de uploads;
- pruebas de carga focalizadas;
- observabilidad;
- procedimiento de despliegue/rollback.

## F13 — Evolución: notificaciones

- Firebase Cloud Messaging;
- aviso de promoción desde lista de espera;
- eventos de dominio consumibles;
- preferencia de notificaciones.

## F14 — Evolución: QR para acreditación

- QR por inscripción;
- scanner;
- antifraude básico;
- registro rápido de asistencia.

## Dependencias principales

```text
F0
 ↓
F1 → F2
 ↓
F3
 ↓
F4
 ↓
F5
 ↓
F6
 ↓
F7 → F8
       ↓
       F9
       ↓
      F10
       ↓
 F11 / F12
       ↓
 F13 / F14
```
