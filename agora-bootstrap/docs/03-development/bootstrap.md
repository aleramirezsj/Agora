# F0 — Bootstrap técnico

## Objetivo

Dejar Ágora en un repositorio nuevo, compilable, testeable, dockerizable y gobernado por la documentación existente.

## Baseline tecnológico

- .NET 10 LTS / ASP.NET Core 10.
- Entity Framework Core 10.
- PostgreSQL mediante Npgsql.
- Next.js 16 Active LTS.
- React 19.
- Node.js 24 LTS.
- Docker / Docker Compose.
- GitHub Actions.

La base PostgreSQL no forma parte del `docker-compose.yml` base. Durante **Development**, la API se conecta a una instancia PostgreSQL local del equipo (`localhost` / `127.0.0.1`) mediante `ConnectionStrings__AgoraDb`.

El PostgreSQL del VPS se crea y utiliza recién cuando Ágora alcance suficiente madurez para desplegar Production. Esa instancia productiva **no debe aceptar conexiones desde Internet**: sólo la aplicación desplegada en el propio VPS podrá acceder a ella mediante loopback o una red privada interna del servidor.

## Estructura

```text
AGENTS.md
Agora.sln
src/
  Agora.Domain/
  Agora.Application/
  Agora.Infrastructure/
  Agora.Api/
tests/
  Agora.Domain.Tests/
  Agora.Application.Tests/
  Agora.IntegrationTests/
web/
docs/
.github/
scripts/
```

## Restricciones

El bootstrap no implementa dominio de negocio. No se crean todavía entidades Usuario, Capacitacion, Inscripcion ni autenticación Firebase. Estas capacidades comienzan en F1 y fases posteriores siguiendo el roadmap.

## Verificación local

### Backend

```bash
dotnet restore Agora.sln
dotnet format Agora.sln --verify-no-changes
dotnet build Agora.sln
dotnet test Agora.sln
```

### Frontend

```bash
cd web
npm install
npm run lint
npm run typecheck
npm run build
npm run dev
```

### Docker

```bash
cp .env.example .env
# configurar una conexión a PostgreSQL LOCAL de Development
docker compose build
docker compose up -d
```

Endpoints de bootstrap:

- API: `GET /`
- liveness: `GET /health/live`
- readiness: `GET /health/ready`
- OpenAPI en Development: `/openapi/v1.json`
- web health: `GET /api/health`

## Definition of Done F0

- solución respeta dependencias hexagonales;
- API inicia contra PostgreSQL local en Development;
- health checks existen;
- ProblemDetails está habilitado;
- OpenAPI está habilitado en Development;
- logging JSON está activo;
- rate limiting base está activo;
- frontend Next.js construye;
- ambas aplicaciones tienen Dockerfile;
- Compose base no crea PostgreSQL ni presupone acceso remoto al VPS;
- CI valida backend, frontend y builds Docker;
- no hay secretos versionados;
- `AGENTS.md` y `/docs` permanecen en raíz.


## Política de conectividad PostgreSQL

### Development

Topología esperada:

```text
Equipo de desarrollo
├── Agora.Api
├── Agora.Web
└── PostgreSQL local :5432
```

Ejemplo conceptual de cadena:

```text
Host=127.0.0.1;Port=5432;Database=agora_dev;Username=...;Password=...
```

Cada desarrollador mantiene su propia base Development. Ningún entorno de desarrollo debe conectarse directamente al PostgreSQL productivo del VPS.

### Production

Topología objetivo:

```text
VPS
├── reverse proxy
├── Agora.Web
├── Agora.Api
└── PostgreSQL
    └── acceso exclusivamente local/privado

Internet
└── NO acceso TCP/5432
```

Si `Agora.Api` se ejecuta como proceso/servicio del host, PostgreSQL puede escuchar únicamente en `127.0.0.1`/`::1` y la API usar `Host=127.0.0.1`.

Si `Agora.Api` se ejecuta dentro de Docker, **no debe resolverse el problema publicando 5432**. `localhost` dentro del contenedor es el propio contenedor, por lo que el despliegue deberá utilizar una conectividad privada entre el contenedor y el host (por ejemplo interfaz/bridge privada explícita, o una estrategia equivalente aprobada) manteniendo PostgreSQL inaccesible desde Internet.

La elección exacta del mecanismo de red de Production se realiza en la fase de despliegue y debe documentarse en un ADR de infraestructura antes de habilitar el entorno.
