# ADR-005 — PostgreSQL como base de datos

**Estado:** Aceptado

## Decisión
Usar PostgreSQL como base relacional del nuevo Ágora.

## Consecuencias
- esquema nuevo, ya que no existen datos reales a preservar;
- migraciones EF Core limpias;
- posibilidad de aprovechar restricciones, índices y transacciones para invariantes críticas;
- PostgreSQL productivo alojado en VPS.
