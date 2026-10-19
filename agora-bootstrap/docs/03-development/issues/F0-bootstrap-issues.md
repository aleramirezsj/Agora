# Issues sugeridos — F0

## F0-001 — Inicializar solución backend hexagonal

**Salida:** `Agora.sln`, cuatro proyectos productivos, tres proyectos de test y referencias válidas entre capas.

**Aceptación:** Domain no referencia infraestructura; Application sólo depende de Domain; Infrastructure depende de Application; Api compone Application + Infrastructure.

## F0-002 — Configurar persistencia PostgreSQL

**Salida:** `AgoraDbContext`, Npgsql y cadena externa por configuración.

**Aceptación:** Development utiliza PostgreSQL local; no depende del VPS; no existe una obligación de contenedor PostgreSQL en el Compose base; credenciales no están hardcodeadas; readiness detecta indisponibilidad de DB.

## F0-003 — Establecer baseline HTTP

**Salida:** ProblemDetails, OpenAPI Development, health checks, logging JSON y rate limiter base.

**Aceptación:** `/health/live` no depende de DB; `/health/ready` sí.

## F0-004 — Inicializar frontend Next.js

**Salida:** App Router, TypeScript strict, ESLint, endpoint de health y build standalone.

**Aceptación:** lint, typecheck y build verdes; `package-lock.json` generado y versionado después de la primera restauración npm validada.

## F0-005 — Dockerizar API y Web

**Salida:** imágenes multi-stage y Compose sin DB.

**Aceptación:** configuración se inyecta por variables; los contenedores corren como runtime mínimo y el web espera health de API.

## F0-006 — Implementar CI de Pull Request

**Salida:** workflow backend/frontend/docker.

**Aceptación:** PR no puede considerarse listo si falla formato, build, tests, lint, typecheck o build Docker.

## F0-007 — Gobierno de contribuciones

**Salida:** `.editorconfig`, `.gitignore`, PR template, CODEOWNERS pendiente de reemplazar y `.env.example`.

**Aceptación:** ningún secreto real está en Git; PR template obliga trazabilidad RF/RN/CA/ADR.

## F0-008 — Validar bootstrap en entorno real

**Salida:** primera ejecución en Development contra una instancia PostgreSQL local del equipo.

**Aceptación:** API y web responden, readiness es saludable, pipeline queda verde y ninguna configuración Development apunta al PostgreSQL productivo del VPS.


## F0-009 — Aislar configuración de base por ambiente

**Salida:** configuración explícita para Development, Testing/CI y Production sin reutilizar endpoints de DB entre ambientes.

**Aceptación:** Development usa `localhost`/`127.0.0.1`; Testing/CI usa una DB efímera aislada; Production queda documentado para una DB residente en el mismo VPS y sin exposición pública de TCP/5432.
