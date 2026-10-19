# Definition of Done

Una historia, requisito o tarea funcional no se considera terminada hasta cumplir lo aplicable.

## Código
- compilación exitosa;
- nombres y estructura consistentes;
- sin lógica de negocio nueva en controladores;
- sin entidades EF expuestas como contrato HTTP;
- sin secretos;
- sin warnings nuevos relevantes;
- format/lint aprobado.

## Dominio
- regla de negocio implementada en capa apropiada;
- invariantes testeadas;
- estados/transiciones explícitos;
- errores de dominio definidos.

## API
- DTO request/response;
- validación;
- autorización;
- ProblemDetails;
- OpenAPI;
- paginación/filtros cuando corresponda;
- códigos HTTP consistentes.

## Persistencia
- migración EF Core;
- índice/restricción necesaria;
- rollback o estrategia de migración clara;
- query razonable y sin N+1 evidente.

## Seguridad
- autenticación aplicada;
- autorización backend;
- no exposición de datos privados;
- input validado;
- subida de archivos validada si aplica.

## Auditoría
Toda operación crítica nueva genera auditoría.

## Pruebas
- unit tests;
- application/use-case tests;
- integration tests para endpoints/persistencia crítica;
- caso feliz;
- al menos un caso de error;
- concurrencia testeada cuando afecta cupos/lista de espera.

## Frontend
- loading;
- empty state;
- error state;
- responsive;
- control de permisos en UX;
- validación cliente sin sustituir backend;
- accesibilidad básica.

## Documentación
- requisito relacionado;
- OpenAPI actualizado;
- ADR si existe decisión arquitectónica nueva;
- README/documento modificado si cambia comportamiento.

## CI
Todos los checks requeridos en Pull Request deben pasar.

## Revisión
- code review realizado;
- criterios de aceptación verificados;
- no quedan TODO/TBD ocultos relacionados con el alcance de la historia.
