# Convenciones de API

## 1. Base URL y versión

```text
/api/v1
```

La API es para el cliente oficial Next.js; no se diseña como producto público de terceros.

## 2. Recursos iniciales

```text
/api/v1/trainings
/api/v1/training-types
/api/v1/registration-types
/api/v1/trainings/{id}/sessions
/api/v1/trainings/{id}/speakers
/api/v1/trainings/{id}/registrations
/api/v1/trainings/{id}/waitlist
/api/v1/trainings/{id}/attendance
/api/v1/registrations/{id}/payments
/api/v1/trainings/{id}/certificates
/api/v1/users
/api/v1/me
/api/v1/audit
/api/v1/reports
```

El equipo puede optar por nombres en español o inglés, pero debe elegir una sola convención para código y rutas. No mezclar idiomas dentro de la API.

## 3. DTOs

Nunca retornar entidades EF.

Separar DTOs según intención:
- CreateRequest;
- UpdateRequest;
- SummaryResponse;
- DetailResponse;
- ListItemResponse.

Evitar DTO universal bidireccional.

## 4. Paginación

Query:
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

Definir máximo de `pageSize` para evitar abuso.

## 5. Filtrado, búsqueda y ordenamiento

Ejemplo:
```text
GET /api/v1/trainings?page=1&pageSize=20&search=ia&status=OPEN&sort=startDate&order=asc
```

Los parámetros permitidos deben documentarse en OpenAPI y validarse contra whitelist.

## 6. Errores

Usar RFC ProblemDetails:

```http
Content-Type: application/problem+json
```

Campos recomendados:
- type;
- title;
- status;
- detail;
- instance;
- traceId;
- errors para validación.

## 7. Códigos HTTP

- `200`: consulta/actualización exitosa.
- `201`: recurso creado.
- `204`: operación sin contenido.
- `400`: request inválido.
- `401`: no autenticado/token inválido.
- `403`: autenticado sin permiso.
- `404`: recurso inexistente/no visible.
- `409`: conflicto de negocio/concurrencia.
- `422`: opcional si se adopta para reglas semánticas; decidir consistentemente.
- `429`: rate limit.
- `500`: error inesperado.

## 8. Validación

Validar:
1. forma del request;
2. reglas de aplicación;
3. invariantes de dominio;
4. restricciones DB.

No depender exclusivamente del frontend.

## 9. Seguridad

El header:
```text
Authorization: Bearer <firebase-id-token>
```

El backend valida token y aplica políticas.

## 10. Idempotencia

Evaluar idempotency key para operaciones sensibles a doble submit:
- inscripción;
- pagos;
- generación masiva.

Como mínimo, las restricciones de dominio/DB deben impedir duplicados críticos.

## 11. OpenAPI

Todo endpoint debe documentar:
- propósito;
- autorización;
- parámetros;
- DTO request/response;
- errores;
- paginación si aplica.

## 12. Health checks

Endpoints diferenciados:
- liveness;
- readiness.

Readiness debe comprobar dependencias críticas como PostgreSQL.
