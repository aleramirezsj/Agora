# AGENTS.md — Ágora

## 1. Propósito de este archivo

Este archivo define el contrato operativo para cualquier agente de código que trabaje sobre **Ágora**, plataforma de gestión de capacitaciones del Instituto N.º 20.

Su objetivo es asegurar que las modificaciones realizadas por agentes automáticos sean:

- trazables a requisitos documentados;
- coherentes con la arquitectura hexagonal definida;
- seguras;
- pequeñas y revisables;
- cubiertas por pruebas;
- compatibles con el roadmap;
- comprensibles para estudiantes y docentes;
- sostenibles para la evolución futura del producto.

Este archivo **no reemplaza** la documentación de `/docs`. Define cómo debe utilizarse esa documentación durante el desarrollo.

---

## 2. Fuente de verdad y orden de precedencia

Antes de implementar cualquier cambio funcional o técnico, leer la documentación relevante.

Orden de autoridad:

1. requerimiento explícito de la tarea o issue actual, siempre que no contradiga una decisión arquitectónica aceptada sin indicarlo;
2. ADR aceptados en `/docs/adr`;
3. reglas de negocio de `/docs/01-functional/business-rules.md`;
4. especificación funcional de `/docs/01-functional/functional-specification.md`;
5. criterios de aceptación de `/docs/01-functional/acceptance-criteria.md`;
6. arquitectura y guías de `/docs/02-architecture`;
7. roles y permisos de `/docs/00-product/roles-permissions.md`;
8. roadmap, plan de desarrollo y Definition of Done de `/docs/03-development`;
9. este archivo para normas operativas del agente;
10. código histórico, únicamente como referencia funcional secundaria.

Si dos fuentes del mismo nivel se contradicen:

- no elegir silenciosamente una interpretación;
- identificar la contradicción;
- detener únicamente la parte afectada;
- registrar la decisión necesaria;
- no introducir una nueva regla de negocio por inferencia.

El sistema histórico WinForms, Blazor y .NET MAUI **no es fuente de verdad arquitectónica**.

---

## 3. Documentos que deben consultarse según el tipo de tarea

### Producto y vocabulario

Leer:

- `/docs/00-product/vision.md`
- `/docs/00-product/glossary.md`
- `/docs/00-product/roles-permissions.md`

### Funcionalidad o regla de negocio

Leer:

- `/docs/01-functional/functional-specification.md`
- `/docs/01-functional/business-rules.md`
- `/docs/01-functional/acceptance-criteria.md`

### Backend, persistencia o API

Leer:

- `/docs/02-architecture/architecture.md`
- `/docs/02-architecture/domain-model.md`
- `/docs/02-architecture/api-guidelines.md`
- `/docs/02-architecture/security.md`

### Archivos, imágenes, comprobantes o plantillas

Leer además:

- `/docs/02-architecture/storage.md`
- `/docs/adr/ADR-004-firebase-storage.md`

### Autenticación o autorización

Leer además:

- `/docs/adr/ADR-002-firebase-auth.md`
- `/docs/00-product/roles-permissions.md`
- `/docs/02-architecture/security.md`

### Vinculación de inscripciones presenciales

Leer obligatoriamente:

- `/docs/adr/ADR-007-dni-account-linking.md`

### Certificados

Leer obligatoriamente:

- `/docs/adr/ADR-008-academic-certificate-format.md`

### Planificación de implementación

Leer:

- `/docs/03-development/roadmap.md`
- `/docs/03-development/development-plan.md`
- `/docs/03-development/definition-of-done.md`

---

## 4. Forma obligatoria de trabajar una tarea

Toda tarea debe abordarse como un **vertical slice** pequeño y verificable.

Antes de modificar código:

1. identificar el issue o tarea;
2. localizar los `RF-*` relacionados;
3. localizar las reglas `RN-*` aplicables;
4. localizar los `CA-*` que deben cumplirse;
5. revisar ADR relevantes;
6. inspeccionar el código existente relacionado;
7. identificar dependencias y posibles efectos laterales;
8. listar brevemente los archivos que se espera crear o modificar;
9. definir qué pruebas demostrarán que el cambio funciona.

Durante la implementación:

1. modificar primero el modelo/regla en la capa correcta;
2. implementar el caso de uso;
3. adaptar persistencia e infraestructura;
4. exponer el contrato HTTP mediante DTOs;
5. aplicar autenticación/autorización;
6. incorporar auditoría cuando corresponda;
7. implementar o actualizar frontend;
8. agregar pruebas;
9. actualizar documentación cuando cambie comportamiento o arquitectura.

Antes de declarar la tarea terminada:

1. compilar;
2. ejecutar format/lint;
3. ejecutar pruebas relevantes;
4. comprobar criterios de aceptación;
5. revisar que no se hayan expuesto secretos o datos privados;
6. revisar autorización en backend;
7. revisar migraciones si existen cambios de persistencia;
8. revisar OpenAPI si existen cambios HTTP;
9. comprobar que no quedaron `TODO`, `FIXME` o `TBD` ocultando trabajo necesario para el alcance;
10. informar claramente qué se hizo y qué no se hizo.

No declarar éxito si los checks requeridos fallan.

---

## 5. Estrategia de reconstrucción

Ágora se reconstruye sobre una arquitectura nueva.

El código histórico puede utilizarse para comprender:

- flujos existentes;
- vocabulario;
- ideas de interfaz;
- comportamiento explorado;
- casos de uso previamente implementados.

No debe reutilizarse automáticamente:

- `GenericService<T>` como abstracción central;
- entidades históricas;
- DTOs históricos;
- controladores históricos;
- esquema de base de datos histórico;
- Firebase handlers históricos;
- lógica de WinForms;
- lógica de Blazor;
- lógica de .NET MAUI.

Toda reutilización requiere que la pieza cumpla la arquitectura nueva.

No migrar pantalla por pantalla. Migrar **capacidades del negocio**.

---

## 6. Arquitectura obligatoria del backend

Estilo:

- monolito modular;
- arquitectura hexagonal;
- ASP.NET Core Web API;
- PostgreSQL;
- Entity Framework Core como adaptador de persistencia;
- Firebase Authentication como proveedor de identidad;
- Firebase Storage para archivos.

Estructura objetivo:

```text
src/
├── Agora.Domain/
├── Agora.Application/
├── Agora.Infrastructure/
└── Agora.Api/

tests/
├── Agora.Domain.Tests/
├── Agora.Application.Tests/
└── Agora.IntegrationTests/
```

### Dependencias permitidas

Flujo conceptual:

```text
Agora.Api ────────┐
                  ↓
Agora.Infrastructure → Agora.Application → Agora.Domain
                  ↑
Agora.Api ────────┘
```

La dirección exacta de referencias de proyecto debe preservar el principio de inversión de dependencias.

### `Agora.Domain`

Puede contener:

- entidades;
- agregados;
- value objects;
- invariantes;
- reglas de dominio;
- estados;
- eventos de dominio;
- excepciones de dominio;
- abstracciones puras estrictamente necesarias.

No puede depender de:

- ASP.NET Core;
- Entity Framework Core;
- Firebase;
- PostgreSQL;
- HTTP;
- Next.js;
- implementaciones de almacenamiento.

### `Agora.Application`

Puede contener:

- casos de uso;
- comandos y queries;
- DTOs de aplicación;
- validación de casos de uso;
- autorización contextual de aplicación;
- puertos de salida;
- orquestación transaccional.

Los casos de uso deben expresar intención de negocio.

Preferir nombres como:

```text
CreateTraining
AddTrainingSession
OpenRegistration
RegisterParticipant
CancelRegistration
PromoteWaitlistedParticipant
RecordAttendance
RegisterCashPayment
SubmitTransfer
ApproveTransfer
GenerateCertificate
EnableCertificates
RevokeCertificate
```

Evitar que el diseño del sistema se reduzca a `Create<T>`, `Update<T>`, `Delete<T>` genéricos cuando existe comportamiento de negocio específico.

### `Agora.Infrastructure`

Contiene adaptadores para:

- EF Core;
- PostgreSQL;
- Firebase Admin SDK;
- Firebase Storage;
- generación PDF;
- QR;
- almacenamiento;
- auditoría persistente;
- reloj del sistema;
- servicios externos.

No ubicar reglas de negocio dentro de repositorios o adaptadores.

### `Agora.Api`

Debe limitarse a responsabilidad HTTP:

- routing;
- autenticación;
- autorización;
- request/response mapping;
- DTOs HTTP cuando corresponda;
- ProblemDetails;
- middleware;
- OpenAPI;
- rate limiting;
- health checks.

Los controladores/endpoints no deben contener lógica de negocio sustancial.

---

## 7. Principios de dominio

Las reglas críticas deben existir en el dominio o en casos de uso y no depender de la UI.

Ejemplos de invariantes que no pueden resolverse sólo con controles visuales:

- transiciones válidas de estado de capacitación;
- cupo máximo;
- unicidad de inscripción vigente;
- promoción transaccional de lista de espera;
- plazo de cancelación;
- precio congelado al inscribirse;
- requisitos de asistencia para certificado;
- requisitos de pago para certificado;
- revocación de certificados;
- anulación de pagos;
- permisos contextuales.

Utilizar restricciones de base de datos como defensa adicional para invariantes críticas cuando corresponda.

---

## 8. Reglas funcionales que el agente no puede reinterpretar

Las siguientes decisiones son intencionales y sólo pueden cambiar mediante una nueva decisión explícita y, cuando corresponda, un ADR.

### Capacitaciones

- modalidad inicial: exclusivamente presencial;
- una capacitación se crea con una jornada inicial;
- puede tener jornadas adicionales;
- el catálogo de tipos de capacitación es configurable;
- puede tener varios expositores;
- un expositor no necesita cuenta Ágora;
- expositor y organizador son conceptos distintos aunque una persona pueda cumplir ambos roles;
- estados: `BORRADOR`, `PUBLICADA`, `INSCRIPCION_ABIERTA`, `INSCRIPCION_CERRADA`, `EN_CURSO`, `FINALIZADA`, `CANCELADA`, `ARCHIVADA`;
- las transiciones se validan y no se asignan arbitrariamente.

### Cupos y lista de espera

- el cupo es global por capacitación;
- la política al alcanzar cupo es configurable;
- puede cerrar inscripción o usar lista de espera;
- una cancelación válida libera cupo;
- si hay lista de espera, se promueve automáticamente a la primera persona;
- la promoción debe impedir sobrecupo por concurrencia;
- Firebase Cloud Messaging queda previsto como evolución para notificar promociones.

### Inscripciones

- la inscripción online requiere login;
- no puede haber dos inscripciones vigentes del mismo usuario en la misma capacitación;
- el participante puede cancelar hasta 24 horas antes del inicio aplicable;
- un administrativo puede inscribir presencialmente a una persona sin cuenta;
- el tipo de inscripción pertenece a la inscripción, no al usuario;
- el precio queda congelado al momento de inscribirse;
- debe conservarse el origen `ONLINE` o `PRESENCIAL`.

### Vinculación por DNI

La vinculación de una futura cuenta con inscripciones presenciales anteriores se realiza **únicamente mediante coincidencia exacta del DNI normalizado**.

No agregar:

- OTP;
- email coincidente obligatorio;
- aprobación administrativa;
- documento fotografiado;
- segundo factor;
- ninguna validación adicional.

La decisión y su riesgo están aceptados en `ADR-007`.

La operación debe ser:

- idempotente;
- auditada;
- sin duplicación de inscripciones.

### Pagos

- medios iniciales: efectivo y transferencia;
- una inscripción puede tener múltiples pagos;
- no existe módulo de caja;
- no existen becas/descuentos/bonificaciones en el alcance inicial;
- los precios diferenciales pertenecen a tipos de inscripción;
- transferencias requieren comprobante privado;
- estado inicial de transferencia: pendiente de validación;
- administración institucional y cobradores/autorizados de la capacitación pueden validar;
- pagos se anulan, no se borran físicamente.

### Asistencia

- acreditación significa asistencia;
- la asistencia se registra por jornada;
- se gestiona mediante listado, búsqueda por DNI/apellido y acción de presente;
- el porcentaje exigido para certificado es configurable;
- correcciones quedan auditadas.

### Certificados

- salida final: PDF;
- fondo: JPG/PNG versionado;
- Ágora superpone campos dinámicos;
- firmas, logos y textos estáticos pueden venir incluidos en la imagen;
- editor formal, sobrio y académico;
- cada certificado tiene código único e inmutable;
- formato oficial: `XXXXXXXX-DDMMAAAA-DNI`;
- `XXXXXXXX`: primeros ocho caracteres alfanuméricos normalizados del nombre de la capacitación; si hay menos de ocho se utiliza el valor completo;
- `DDMMAAAA`: fecha de la jornada inicial;
- `DNI`: DNI normalizado sin puntos ni separadores;
- incluye QR de validación pública;
- estados: `NO_GENERADOS`, `EN_REVISION`, `HABILITADOS`, `REVOCADOS`;
- un certificado revocado conserva historial;
- el participante sólo descarga certificados habilitados cuyos requisitos cumple.

Ejemplo conceptual:

```text
PROGRAMAC-31082026-30123456
```

No cambiar el formato del código para ocultar el DNI: su exposición es una decisión funcional explícita documentada.

---

## 9. Autenticación y autorización

### Autenticación

Firebase Authentication es el único proveedor de identidad definido.

Métodos:

- email + contraseña;
- Google.

Flujo:

```text
Next.js
  ↓
Firebase Authentication
  ↓ Firebase ID Token
Agora API
  ↓
Firebase Admin SDK valida token
  ↓
Ágora resuelve usuario interno
  ↓
Ágora aplica roles y permisos
```

No crear un JWT propio para sustituir el Firebase ID Token.

Identificadores:

- `FirebaseUid`: identidad técnica externa;
- `UsuarioId`: UUID interno Ágora;
- DNI: dato de negocio.

No usar DNI ni Firebase UID como PK principal del dominio.

### Autorización

Modelo:

- RBAC global;
- RBAC contextual por capacitación.

Roles globales:

- `SUPER_ADMIN`;
- `ADMIN_INSTITUCIONAL`;
- `USUARIO`.

Roles contextuales:

- `ORGANIZADOR`;
- `ACREDITADOR`;
- `COBRADOR`;
- `GESTOR_CERTIFICADOS`.

Toda autorización real debe ocurrir en backend.

Nunca confiar en:

- botones ocultos;
- rutas de frontend;
- roles enviados por el cliente;
- `userId` recibido desde el frontend como prueba de identidad.

Utilizar policies/handlers o abstracciones equivalentes coherentes con ASP.NET Core.

---

## 10. API HTTP

Base:

```text
/api/v1
```

La API está orientada al cliente oficial Next.js. No agregar complejidad específicamente para consumidores externos no requeridos.

### DTOs

Nunca exponer entidades EF directamente.

Separar contratos según intención, por ejemplo:

- `CreateRequest`;
- `UpdateRequest`;
- `ListItemResponse`;
- `SummaryResponse`;
- `DetailResponse`.

Evitar un DTO universal usado para create/update/read.

### Paginación

Formato base:

```text
?page=1&pageSize=20
```

Respuesta:

```json
{
  "items": [],
  "page": 1,
  "pageSize": 20,
  "totalItems": 0,
  "totalPages": 0
}
```

Definir y respetar máximo de `pageSize`.

### Filtrado y ordenamiento

- documentar parámetros;
- validar nombres permitidos contra whitelist;
- no construir SQL inseguro a partir de parámetros de ordenamiento.

### Errores

Utilizar `ProblemDetails` consistente.

No devolver stack traces o detalles internos en producción.

### HTTP status

Usar semántica consistente con `/docs/02-architecture/api-guidelines.md`.

Conflictos de negocio/concurrencia deben expresarse apropiadamente, normalmente como `409` cuando corresponda.

### Idempotencia

Considerar doble submit y retries especialmente en:

- inscripción;
- pagos;
- promoción de lista de espera;
- generación masiva de certificados.

Como mínimo deben existir invariantes de dominio y restricciones de DB que eviten duplicados críticos.

### Idioma de rutas y nombres

La documentación actual permite elegir español o inglés pero prohíbe mezclarlos.

El agente **no debe decidir silenciosamente esta convención** si el repositorio nuevo todavía no la fijó.

Al iniciar el contrato API por primera vez:

1. verificar si existe una convención ya adoptada por el código nuevo;
2. si existe, mantenerla;
3. si no existe, registrar la decisión mediante ADR antes de propagar nombres a gran escala.

---

## 11. Persistencia y EF Core

Base oficial: PostgreSQL.

Reglas:

- IDs internos mediante UUID;
- timestamps en UTC;
- migraciones versionadas;
- restricciones de DB para invariantes críticas;
- índices explícitos para patrones de consulta importantes;
- evitar N+1;
- no cargar grafos completos si una proyección es suficiente;
- consultas de listados deben paginar;
- no persistir imágenes o PDFs como BLOB cuando corresponden a Firebase Storage.

No existe información productiva histórica que deba migrarse.

Por lo tanto:

- crear esquema limpio;
- no reproducir el esquema legado sólo por compatibilidad;
- seeds únicamente para development/testing;
- no incorporar datos demo a producción.

### Concurrencia

Tratar como crítico:

- último cupo disponible;
- promoción desde lista de espera;
- doble cancelación;
- doble pago/submit;
- generación masiva.

Usar mecanismos transaccionales y restricciones apropiadas. No resolver concurrencia sólo con un `if` previo al `SaveChanges`.

---

## 12. Firebase Storage y archivos

Rutas lógicas esperadas:

```text
/capacitaciones/{id}/flyers/
/capacitaciones/{id}/expositores/
/capacitaciones/{id}/certificados/plantillas/
/inscripciones/{id}/comprobantes/
```

Persistir en PostgreSQL:

- object path;
- URL sólo cuando corresponda;
- MIME type;
- tamaño;
- versión;
- relación de negocio;
- visibilidad;
- fecha de carga.

### Públicos

Pueden ser públicos:

- flyers;
- fotos de expositores.

### Privados

Los comprobantes de transferencia son privados.

No almacenar una URL pública permanente para comprobantes.

Utilizar acceso controlado o URL firmada/de corta duración según el adaptador implementado.

### Versionado

Conservar versiones históricas de:

- flyers;
- plantillas de certificados.

No modificar retroactivamente un certificado emitido por reemplazar su plantilla.

---

## 13. Editor y generación de certificados

El editor de plantillas es especializado en documentos académicos.

Debe priorizar:

- sobriedad;
- legibilidad;
- precisión geométrica;
- reproducción determinística;
- consistencia entre preview y PDF.

Debe permitir como mínimo:

- subir/versionar JPG/PNG;
- posicionar tokens;
- editar coordenadas;
- editar dimensiones;
- familia tipográfica desde catálogo controlado;
- tamaño;
- peso;
- estilo;
- color;
- alineación;
- guías de alineación;
- previsualización.

Tokens iniciales:

```text
{{nombreCompleto}}
{{dni}}
{{capacitacion}}
{{fecha}}
{{cargaHoraria}}
```

No convertirlo en un editor de diseño publicitario generalista.

No priorizar:

- filtros;
- sombras decorativas;
- stickers;
- efectos artísticos;
- herramientas no relacionadas con certificados académicos.

La misma lógica de layout o una representación matemática equivalente debe gobernar preview y PDF para evitar desplazamientos.

Las fuentes requeridas deben estar disponibles de manera determinística en el ambiente que genera el PDF.

---

## 14. Auditoría

La auditoría forma parte del MVP y no es opcional en operaciones críticas.

Registrar cuando aplique:

- actor;
- acción;
- entidad;
- identificador de entidad;
- fecha/hora;
- valor anterior;
- valor nuevo;
- IP cuando esté disponible;
- correlation/request ID cuando ayude a trazabilidad.

Operaciones críticas iniciales:

- pagos;
- validación/rechazo de transferencias;
- asistencia y correcciones;
- asignación/revocación de roles;
- capacitaciones;
- inscripciones;
- vinculación por DNI;
- certificados;
- revocación de certificados.

La auditoría no sustituye al logging técnico y el logging técnico no sustituye a la auditoría.

No registrar secretos, tokens completos ni contenido sensible innecesario.

---

## 15. Soft delete, anulación y revocación

Utilizar soft delete para:

- usuarios;
- capacitaciones;
- catálogos.

No borrar físicamente transacciones sensibles.

Usar:

- pagos → anulación;
- asistencias → corrección/anulación con trazabilidad;
- certificados → revocación.

Evitar endpoints `DELETE` que destruyan información cuya historia debe conservarse.

---

## 16. Frontend oficial

Frontend oficial: **Next.js + TypeScript + React**.

No desarrollar nuevas funcionalidades en:

- WinForms;
- Blazor;
- .NET MAUI.

Esas aplicaciones son legado/referencia.

Una sola aplicación Next.js debe cubrir:

```text
/
├── portal público
├── login
├── mi-agora
├── gestion
└── admin
```

### Portal público

Debe contemplar:

- landing institucional;
- listado de capacitaciones;
- detalle;
- flyer;
- expositores;
- jornadas/fechas;
- lugar;
- disponibilidad/cupo;
- costos;
- acción de inscripción;
- archivo de capacitaciones anteriores;
- validación pública de certificado.

### Mi Ágora

Debe contemplar:

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

### UX mínima por pantalla asíncrona

Toda pantalla relevante debe considerar:

- loading state;
- empty state;
- error state;
- success feedback cuando corresponda;
- responsive layout;
- accesibilidad básica;
- estado de autorización;
- prevención de doble submit en acciones sensibles.

La validación del frontend mejora UX, pero nunca sustituye la validación backend.

---

## 17. Testing obligatorio

No implementar funcionalidad nueva sin pruebas proporcionales a su riesgo.

### Domain tests

Deben ser rápidos y no depender de infraestructura.

Cubrir:

- invariantes;
- estados;
- transiciones;
- cálculos;
- requisitos para certificados;
- cancelación;
- normalización cuando sea lógica pura.

### Application tests

Cubrir casos de uso con puertos fake/mock cuando sea apropiado.

Verificar:

- orquestación;
- permisos;
- errores;
- idempotencia;
- efectos esperados.

### Integration tests

Usar PostgreSQL real aislado en CI, preferentemente efímero/containerizado para tests.

Prioridad alta:

- constraints;
- EF mappings;
- endpoints;
- auth/authz;
- cupo concurrente;
- lista de espera;
- pagos;
- certificados;
- auditoría.

### Frontend tests

Cubrir:

- componentes críticos;
- formularios;
- validaciones;
- permisos visibles;
- estados async;
- flujos E2E seleccionados.

### Casos mínimos por historia

Siempre que aplique:

- caso feliz;
- al menos un caso inválido;
- caso de autorización;
- borde temporal;
- borde de concurrencia cuando afecte cupos o listas.

No borrar o debilitar tests para conseguir que CI pase salvo que el requisito haya cambiado y la actualización del test esté justificada.

---

## 18. Seguridad

### Secrets

Nunca versionar:

- Firebase service account;
- private keys;
- connection strings productivos;
- access tokens;
- cookies;
- passwords;
- signing material.

Usar variables de entorno/secret store según ambiente.

### Logs

No registrar:

- Firebase ID Token completo;
- contraseñas;
- service account JSON;
- comprobantes completos;
- datos personales sin necesidad operativa.

### Uploads

Validar al menos:

- MIME permitido;
- extensión coherente;
- tamaño máximo;
- destino autorizado;
- ownership/contexto.

No confiar únicamente en el nombre del archivo.

### CORS

Permitir únicamente orígenes definidos por ambiente.

### Rate limiting

Aplicar especialmente en:

- validación pública de certificados;
- búsquedas públicas;
- uploads;
- acciones sensibles o abusables.

### Datos personales

Aplicar minimización de datos en respuestas públicas.

La página pública de certificado debe exponer sólo lo necesario para verificar autenticidad, además del identificador cuyo DNI forma parte por decisión funcional explícita.

---

## 19. Observabilidad

MVP mínimo:

- logging estructurado;
- request/correlation ID;
- manejo global de errores;
- liveness;
- readiness;
- registro de errores;
- auditoría separada.

Readiness debe validar dependencias críticas como PostgreSQL.

No usar health checks que modifiquen datos.

---

## 20. Infraestructura y despliegue

Producción:

```text
VPS
├── agora-api       Docker
├── agora-web       Docker
├── reverse proxy
└── PostgreSQL      servicio del VPS

Servicios externos
├── Firebase Authentication
└── Firebase Storage
```

No agregar PostgreSQL como contenedor del `docker-compose` productivo si la infraestructura sigue la decisión actual.

En Development y Testing/CI sí puede utilizarse PostgreSQL containerizado para reproducibilidad.

Ambientes oficiales:

- Development;
- Testing/CI;
- Production.

Mantener configuración y secretos separados por ambiente.

---

## 21. CI/CD

Repositorio oficial: GitHub.

CI/CD oficial: GitHub Actions.

Pipeline esperado:

```text
Pull Request
  ↓
Restore / install
  ↓
Build
  ↓
Format / lint
  ↓
Unit tests
  ↓
Integration tests
  ↓
Frontend tests
  ↓
Production build
  ↓
Docker build
```

No omitir checks porque una tarea parezca pequeña.

Si el repositorio define scripts/comandos oficiales, utilizarlos en lugar de inventar variantes locales.

---

## 22. Comandos y herramientas

Antes de ejecutar comandos destructivos o generar migraciones:

1. inspeccionar estructura real del repositorio;
2. revisar archivos de solución/proyecto/package manager;
3. utilizar tooling ya adoptado por el proyecto.

Cuando la estructura esperada exista, comandos típicos pueden incluir:

```bash
dotnet restore
dotnet build
dotnet test
```

Y para frontend, utilizar el package manager detectado por el lockfile (`npm`, `pnpm`, `yarn` u otro ya adoptado).

No crear un lockfile de un segundo package manager si ya existe uno oficial.

No cambiar versiones mayores de framework o dependencias como efecto colateral de una feature.

No ejecutar una migración destructiva contra Production desde una tarea de desarrollo.

---

## 23. Política de dependencias

Antes de agregar una dependencia:

- verificar si el framework/BCL ya resuelve el problema;
- justificar su necesidad;
- comprobar mantenimiento y compatibilidad;
- evitar paquetes redundantes;
- no incorporar frameworks arquitectónicos completos para resolver un caso pequeño;
- no agregar una abstracción sólo porque sea popular.

Las dependencias externas pertenecen a los adaptadores cuando implementan infraestructura.

El dominio debe permanecer libre de dependencias tecnológicas innecesarias.

---

## 24. Estilo y mantenibilidad

Priorizar:

- claridad;
- nombres que expresen dominio;
- funciones pequeñas con una responsabilidad coherente;
- composición;
- separación explícita de responsabilidades;
- código fácil de explicar en contexto educativo;
- invariantes visibles;
- errores explícitos.

Evitar:

- clases `Manager`, `Helper`, `Utils` como contenedores genéricos sin cohesión;
- `GenericService<T>` como sustituto de casos de uso;
- controladores enormes;
- repositorios que contienen reglas de negocio;
- booleanos múltiples que representan implícitamente una máquina de estados ya modelada;
- `catch (Exception)` que oculta errores sin manejo real;
- comentarios que describen código obvio;
- duplicar reglas en backend y frontend como dos fuentes de verdad.

---

## 25. Migraciones de base de datos

Cada cambio persistente debe evaluar:

- migración EF Core;
- constraint;
- índice;
- nulabilidad;
- valor por defecto;
- compatibilidad del esquema;
- estrategia de rollback o forward fix.

Aunque hoy no existan datos productivos a preservar durante la reconstrucción inicial, escribir migraciones como si el sistema fuera a evolucionar de forma permanente.

No editar manualmente una migración histórica ya desplegada salvo motivo excepcional y documentado.

---

## 26. Git y Pull Requests

Ramas:

```text
feature/<issue>-descripcion
fix/<issue>-descripcion
refactor/<issue>-descripcion
docs/<issue>-descripcion
```

Los PR deben ser:

- pequeños;
- enfocados;
- trazables;
- revisables;
- sin refactors no relacionados;
- con evidencia de pruebas.

No mezclar en una misma tarea:

- feature funcional grande;
- upgrade de dependencias;
- reformateo global;
- refactor transversal no requerido.

No hacer force push, reset destructivo o reescritura de historia salvo instrucción explícita.

---

## 27. Documentación y trazabilidad

Convenciones:

- `MOD-*`: módulo;
- `RF-*`: requisito funcional;
- `RN-*`: regla de negocio;
- `CA-*`: criterio de aceptación;
- `ADR-*`: decisión arquitectónica;
- `F-*`: fase del roadmap.

Toda feature significativa debe poder responder:

```text
¿Qué RF implementa?
¿Qué RN aplica?
¿Qué CA demuestra?
¿Qué tests lo prueban?
¿Qué ADR condiciona la solución?
```

Cuando una decisión técnica tenga consecuencias duraderas, crear ADR.

Ejemplos:

- cambio del proveedor de autenticación;
- nuevo patrón de persistencia transversal;
- cambio de lenguaje oficial de API si aún no se fijó;
- cambio del modelo de despliegue;
- cambio del formato de certificado;
- cambio de la política de vinculación por DNI.

No crear ADR para decisiones triviales y locales.

---

## 28. Definition of Done obligatoria

Una tarea no está terminada hasta cumplir todo lo aplicable de `/docs/03-development/definition-of-done.md`.

Como mínimo verificar:

### Código

- build exitoso;
- format/lint exitoso;
- sin warnings nuevos relevantes;
- sin secretos;
- sin lógica de negocio nueva en controladores;
- sin entidades EF como contrato HTTP.

### Dominio

- reglas en capa apropiada;
- invariantes testeadas;
- estados/transiciones explícitos.

### API

- DTOs;
- validación;
- autorización;
- ProblemDetails;
- OpenAPI.

### Persistencia

- migración si aplica;
- constraint/índice si aplica;
- queries razonables.

### Seguridad

- autenticación/autorización backend;
- privacidad de archivos;
- inputs validados.

### Auditoría

- operaciones críticas auditadas.

### Tests

- caso feliz;
- error;
- integración cuando corresponda;
- concurrencia cuando sea relevante.

### Frontend

- loading;
- empty;
- error;
- responsive;
- accesibilidad básica;
- permisos reflejados en UX.

### Documentación

- referencias actualizadas;
- OpenAPI actualizado;
- ADR si la decisión lo requiere.

---

## 29. Qué hacer ante una ambigüedad

No todas las ambigüedades requieren detener toda la tarea.

Clasificar:

### A. Detalle de implementación local sin impacto funcional

Puede resolverse con una decisión conservadora y estándar, documentándola en el resumen del cambio.

Ejemplo: nombre de una variable privada.

### B. Decisión técnica transversal

No propagarla silenciosamente.

Ejemplo: elegir por primera vez español o inglés para toda la API.

Crear/proponer ADR antes de extender la decisión.

### C. Regla funcional o de seguridad no especificada

No inventarla.

Registrar la decisión pendiente y avanzar sólo con las partes que no dependan de ella.

Ejemplo: agregar un segundo factor al vínculo por DNI sería incorrecto porque contradice una decisión existente.

---

## 30. Prohibiciones explícitas

Un agente no debe:

1. reemplazar Firebase Authentication por autenticación propia;
2. emitir JWT propio como sustituto del Firebase ID Token sin ADR nuevo;
3. autorizar operaciones sólo desde frontend;
4. exponer entidades EF directamente;
5. poner lógica de negocio sustancial en controllers/endpoints;
6. introducir `GenericService<T>` como arquitectura central;
7. reconstruir WinForms, Blazor o MAUI como clientes oficiales;
8. guardar comprobantes de transferencia con URL pública permanente;
9. almacenar blobs de imágenes en PostgreSQL cuando corresponden a Firebase Storage;
10. borrar físicamente pagos, asistencias o certificados para “simplificar”;
11. agregar validación extra al vínculo por DNI;
12. cambiar el código de certificado definido por `ADR-008`;
13. crear automáticamente administradores mediante autorregistro;
14. confiar en roles provenientes del cliente;
15. omitir auditoría de operaciones críticas;
16. ignorar concurrencia en cupos/lista de espera;
17. copiar el esquema histórico como nueva base sin justificación;
18. realizar refactors masivos no relacionados con la tarea;
19. cambiar dependencias mayores como efecto secundario;
20. declarar una tarea terminada con tests relevantes fallando;
21. introducir secretos en código, fixtures, logs o documentación;
22. inventar reglas de negocio faltantes.

---

## 31. Formato recomendado del informe final del agente

Al terminar una tarea, responder de forma breve y verificable con:

### Implementado

- cambios principales;
- RF/RN/CA cubiertos.

### Archivos principales

- archivos creados/modificados más relevantes.

### Validación

- comandos ejecutados;
- tests ejecutados;
- resultado de build/lint.

### Persistencia

- migraciones/constraints/índices creados, si aplica.

### Seguridad y autorización

- policies/permisos aplicados, si aplica.

### Pendientes

- sólo pendientes reales fuera del alcance;
- nunca ocultar un fallo necesario para considerar terminada la tarea.

---

## 32. Regla final

Ágora debe evolucionar como un sistema de gestión de capacitaciones profesional y como un proyecto educativo comprensible.

Cuando exista tensión entre una solución ingeniosa y una solución clara, testeable y coherente con el dominio, preferir la segunda.

Cuando exista tensión entre avanzar rápido e inventar una regla de negocio, **no inventar la regla**.

Cuando exista tensión entre copiar el sistema histórico y respetar la arquitectura nueva, **respetar la arquitectura nueva**.

La trazabilidad esperada es:

```text
Necesidad del producto
      ↓
RF
      ↓
RN
      ↓
CA
      ↓
Caso de uso
      ↓
Código
      ↓
Tests
      ↓
PR
```

Ese flujo debe permanecer visible durante toda la reconstrucción de Ágora.
