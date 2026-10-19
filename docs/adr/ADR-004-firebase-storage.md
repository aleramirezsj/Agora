# ADR-004 — Firebase Storage para archivos

**Estado:** Aceptado

## Decisión
Almacenar flyers, fotos, comprobantes y plantillas en Firebase Storage.

PostgreSQL almacena referencias y metadata, no binarios.

## Reglas
- comprobantes privados;
- fotos/flyers públicos;
- versionado de flyers/plantillas;
- uploads autorizados y validados.
