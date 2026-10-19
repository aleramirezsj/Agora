# Arquitectura técnica base

## 1. Estilo arquitectónico

Ágora se implementa como **monolito modular con arquitectura hexagonal**.

La arquitectura busca separar:

- dominio;
- casos de uso;
- persistencia;
- autenticación externa;
- almacenamiento;
- HTTP;
- UI.

## 2. Backend

Tecnología base:

- ASP.NET Core Web API;
- C#;
- Entity Framework Core;
- PostgreSQL;
- Firebase Admin SDK;
- OpenAPI;
- JWT/Firebase ID Token;
- Docker;
- xUnit;
- pruebas de integración con infraestructura aislada.

Estructura sugerida:

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

### `Agora.Domain`
Contiene:
- entidades;
- value objects;
- enums de estados internos estables;
- reglas;
- excepciones de dominio;
- eventos de dominio;
- interfaces estrictamente necesarias para expresar puertos.

No depende de:
- EF Core;
- ASP.NET;
- Firebase;
- PostgreSQL;
- HTTP.

### `Agora.Application`
Contiene:
- casos de uso;
- comandos/queries;
- DTOs de aplicación;
- validadores;
- interfaces de puertos de salida;
- autorización contextual de aplicación;
- orquestación de transacciones.

Ejemplos:

```text
CreateTraining
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

### `Agora.Infrastructure`
Implementa adaptadores:
- EF Core;
- repositorios;
- PostgreSQL;
- Firebase Storage;
- Firebase token validation;
- generador PDF;
- generador QR;
- auditoría;
- reloj del sistema;
- almacenamiento.

### `Agora.Api`
Adaptador de entrada HTTP:
- endpoints/controladores;
- DTOs HTTP;
- middleware;
- ProblemDetails;
- OpenAPI;
- rate limiting;
- authentication;
- authorization policies;
- health checks.

## 3. Frontend

Tecnología oficial:

- Next.js;
- TypeScript;
- React;
- diseño responsive;
- acceso a API HTTP;
- Firebase Web SDK para autenticación.

Una sola aplicación debe resolver:

```text
/
├── portal público
├── /login
├── /mi-agora
├── /gestion
└── /admin
```

La navegación y acciones se adaptan a permisos, pero la API siempre vuelve a validar autorización.

## 4. Persistencia

Base:
- PostgreSQL alojado en VPS.

Principios:
- migraciones versionadas;
- restricciones DB para invariantes críticas;
- índices para búsquedas frecuentes;
- UUID para IDs internos;
- timestamps UTC;
- concurrencia controlada en cupos/lista de espera;
- no persistir blobs de imágenes.

## 5. Archivos

Firebase Storage:
- flyers;
- fotos;
- comprobantes;
- plantillas.

La DB persiste:
- object path;
- URL cuando corresponda;
- tipo MIME;
- tamaño;
- versión;
- propietario de negocio;
- visibilidad;
- fecha de carga.

## 6. Autenticación y autorización

```text
Next.js
  ↓ Firebase Login
Firebase Authentication
  ↓ ID Token JWT
Next.js → Agora API
             ↓
      valida firma/claims
             ↓
      busca Usuario interno
             ↓
      aplica roles/permisos
```

No se emite JWT propio para reemplazar Firebase salvo futura decisión explícita.

## 7. API

Base:
```text
/api/v1/
```

Características:
- REST;
- paginación;
- filtros;
- búsqueda;
- ordenamiento;
- DTOs;
- validación;
- ProblemDetails;
- OpenAPI;
- políticas de autorización;
- rate limiting;
- logs;
- health checks.

## 8. Observabilidad

MVP:
- logging estructurado;
- correlation/request ID;
- health endpoint;
- registro de errores;
- auditoría separada del logging técnico.

## 9. Despliegue

```text
VPS
├── agora-api (Docker)
├── agora-web (Docker)
├── reverse proxy
└── PostgreSQL (servicio alojado en VPS)

Externos
├── Firebase Authentication
└── Firebase Storage
```

Ambientes:
- Development;
- Testing/CI;
- Production.

## 10. CI/CD

GitHub + GitHub Actions:

```text
Pull Request
  ↓
Restore/install
  ↓
Build
  ↓
Format/lint
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

El despliegue a producción debe quedar separado de la validación de PR y protegido por secretos/entornos.
