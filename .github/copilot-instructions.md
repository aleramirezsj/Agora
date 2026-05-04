# Agora Copilot Instructions

## Build and test commands

```powershell
# Backend API
dotnet build Backend\Backend.csproj --configuration Debug
dotnet run --project Backend\Backend.csproj --launch-profile https

# Blazor WebAssembly frontend
dotnet build WebBlazor\WebBlazor.csproj --configuration Debug
dotnet run --project WebBlazor\WebBlazor.csproj --launch-profile https

# Test suite
dotnet test TestAgora\TestAgora.csproj

# Run a single test
dotnet test TestAgora\TestAgora.csproj --filter FullyQualifiedName~TestAgora.UnitTestCapacitacionService.TestGetCapacitacionesAbiertasAsync
```

The test project is not isolated from infrastructure. `TestAgora` exercises the shared HTTP client services in `Service\Services`, so the backend must already be running on `https://localhost:7000` and the local HTTPS dev certificate must be trusted with `dotnet dev-certs https --trust`.

Local API calls default to `Service\Properties\Resources.resx` (`UrlApiLocal`), and the backend currently boots with the connection string selected in `Backend\Program.cs`. If API tests start returning `500`, check backend startup and MySQL connectivity before changing test code.

## High-level architecture

The solution is organized around a shared .NET class library, `Service`, that contains the domain models (`Capacitacion`, `Usuario`, `Inscripcion`, `TipoInscripcion`, `TipoInscripcionCapacitacion`), enums, API endpoint mapping, and reusable HTTP client services. `Backend`, `WebBlazor`, `Desktop`, `MovilApp`, and `TestAgora` all reference this project, so model or endpoint changes ripple across the whole solution.

`Backend` is an ASP.NET Core Web API over EF Core + Pomelo MySQL. `AgoraContext` defines the entity sets, seed data, and global query filters for soft deletes. Controllers expose REST endpoints under `/api/*`, plus a few custom actions such as `capacitaciones/abiertas`, `capacitaciones/futuras`, `inscripciones/inscriptos/{id}`, `deleteds`, and `restore/{id}`. `Program.cs` also enables Swagger, ignores JSON reference cycles, and allows CORS from the Blazor local/production origins.

`WebBlazor` is the main browser UI. It uses the shared service abstractions for CRUD calls and a separate `FirebaseAuthService` (JS interop) for login state. Admin pages under `Pages\Admin\Capacitaciones` call the shared services directly and gate navigation through Firebase auth checks.

`Desktop` (WinForms) and `MovilApp` (.NET MAUI) are additional clients for the same domain. Both depend on `Service` for shared models/configuration, and both contain Firebase-based login flows instead of API-backed auth.

Only `Backend` and `WebBlazor` are wired into GitHub Actions deployment. The workflows in `.github\workflows` build and publish those two projects to Azure Web Apps on pushes to `master`.

Copilot cloud-agent browser automation should use Playwright MCP rather than inventing ad hoc browser scripts. `.github\workflows\copilot-setup-steps.yml` prepares the cloud agent with Node.js plus a Chromium install for that workflow.

## Key conventions

- Treat `Service` as the shared source of truth. When renaming a model or adding a new API-backed entity, update `Service\Models`, `Service\Utils\ApiEndpoints.cs`, backend controllers, and any client/tests that consume that endpoint together.
- Route names are convention-based and lowercase/plural. `GenericService<T>` builds URLs from `ApiEndpoints.GetEndpoint(typeof(T).Name)`, so mismatches between model names, endpoint mapping, and controller routes break every consumer.
- Soft delete is the default deletion strategy. Entities expose `IsDeleted`, `AgoraContext` applies `HasQueryFilter(p => !p.IsDeleted)`, and controllers use `IgnoreQueryFilters()` for `deleteds` and `restore` endpoints.
- `Capacitacion` updates are aggregate-style, not flat entity updates. `CapacitacionesController.PutCapacitacion` manually attaches related `TipoInscripcion` entities, diffs child collections, and nulls navigation properties on nested `Inscripcion` objects to avoid duplicate inserts and EF tracking conflicts.
- The local backend URL is coupled to launch settings and shared resources: the HTTPS profile serves `https://localhost:7000`, and `GenericService<T>` defaults to `UrlApiLocal`. If one changes, update the other or the clients/tests will silently target the wrong API.
- Authentication is split from the backend CRUD stack. Web, desktop, and mobile login flows use Firebase configuration from shared resources; the backend controllers shown here do not enforce that same auth boundary yet.
