# ADR-002 — Firebase Authentication como proveedor de identidad

**Estado:** Aceptado

## Decisión
Autenticar usuarios con Firebase mediante email/contraseña y Google.

El frontend obtiene Firebase ID Token. El backend valida ese token y resuelve el usuario interno.

Ágora no generará un JWT propio para reemplazar Firebase en el flujo normal.

## Autorización
Roles y permisos se almacenan/resuelven en Ágora.

## Consecuencias
- identidad externalizada;
- autorización controlada por dominio;
- dependencia explícita de Firebase;
- necesidad de manejar vinculación `FirebaseUid`/`UsuarioId`.
