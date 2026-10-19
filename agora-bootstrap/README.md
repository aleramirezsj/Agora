# Ágora — Bootstrap de reconstrucción

Ágora es la plataforma de gestión de capacitaciones del Instituto N.º 20.

Este repositorio inicia la reconstrucción definida en `/docs`. Antes de implementar cualquier funcionalidad, leer [`AGENTS.md`](AGENTS.md).

## Stack base

- ASP.NET Core / .NET 10 LTS
- arquitectura hexagonal en monolito modular
- Entity Framework Core + PostgreSQL
- Next.js + TypeScript
- Firebase Authentication y Storage en fases funcionales posteriores
- Docker
- GitHub Actions

## Primer arranque

1. Instalar .NET SDK 10 y Node.js 24 LTS.
2. Levantar o verificar una instancia **local de PostgreSQL** para Development y copiar `.env.example` a `.env` con una conexión a `localhost`.
3. Backend: `dotnet restore Agora.sln && dotnet run --project src/Agora.Api`.
4. Frontend: `cd web && npm install && npm run dev`.
5. Alternativamente, ejecutar API/Web con Docker; PostgreSQL de Development sigue siendo un servicio local del equipo y nunca una base remota del VPS.

## Estado

El bootstrap F0 crea infraestructura técnica exclusivamente. La implementación funcional comienza en F1 según `docs/03-development/roadmap.md`.

## Validación pendiente del primer entorno

Consultar `BOOTSTRAP_VALIDATION.md`. El paquete define el scaffold y sus contratos, pero la primera máquina con SDK/Docker debe ejecutar restore/build/test y versionar el lockfile npm.


## Estrategia de base de datos por ambiente

- **Development:** PostgreSQL local en la máquina de desarrollo (`localhost` / `127.0.0.1`). No se conecta al PostgreSQL productivo del VPS.
- **Testing/CI:** PostgreSQL efímero y aislado, preferentemente mediante contenedor de CI/Testcontainers.
- **Production (cuando corresponda):** PostgreSQL reside en el mismo VPS que Ágora y **no expone el puerto 5432 a Internet**. La API accede a la base únicamente por conectividad local/privada del servidor.

La política de Ágora es explícita: **nunca abrir PostgreSQL al exterior para permitir desarrollo remoto ni para facilitar la conexión desde contenedores**.
