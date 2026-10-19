# Validación del bootstrap

## Validado durante la generación

- estructura de proyectos y referencias diseñada según `AGENTS.md`;
- JSON parseable;
- archivos MSBuild (`.csproj`, `.props`) XML válidos;
- Docker Compose base no define un servicio PostgreSQL ni requiere acceso al PostgreSQL del VPS;
- la configuración Development debe apuntar a PostgreSQL local;
- API y Web poseen Dockerfiles independientes;
- CI separa backend, frontend y build de imágenes;
- no se incluyeron secretos reales;
- documentación F0 e issues iniciales incorporados.

## Validación que debe ejecutar el primer entorno con toolchain completo

Este paquete fue generado en un entorno sin `dotnet` ni Docker. La resolución npm no pudo finalizar por conectividad, por lo cual **no debe afirmarse que F0 está completada hasta ejecutar lo siguiente**:

```bash
# backend
dotnet --info
dotnet restore Agora.sln
dotnet format Agora.sln --verify-no-changes
dotnet build Agora.sln -c Release --no-restore
dotnet test Agora.sln -c Release --no-build

# frontend
cd web
npm install
npm run lint
npm run typecheck
npm run build
cd ..

# Docker
docker compose config
docker compose build
```

Después del primer `npm install`, revisar y **versionar `web/package-lock.json`**. A continuación se recomienda cambiar CI y Docker a `npm ci` para instalaciones determinísticas.

## Criterio

Cualquier incompatibilidad de paquetes descubierta por restore/build debe resolverse manteniendo las versiones mayores fijadas por el baseline (`.NET 10`, `Next.js 16`, `Node 24`) y sin alterar decisiones de negocio o arquitectura para hacer pasar el build.


## Validación adicional de aislamiento de base

Antes de considerar F0 cerrado, verificar que:

```text
Development -> PostgreSQL local
Testing/CI  -> PostgreSQL efímero/aislado
Production  -> PostgreSQL local al VPS (futuro)
```

No debe existir en `.env`, `appsettings.Development.json`, secretos de usuario ni documentación operativa una IP pública o DNS del VPS usado como host PostgreSQL de Development.

Cuando se despliegue Production, validar además que el puerto `5432` no sea accesible desde Internet y que `pg_hba.conf`/`listen_addresses` sólo autoricen los orígenes locales o privados estrictamente necesarios.
