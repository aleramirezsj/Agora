# ADR-006 — Monolito modular

**Estado:** Aceptado

## Contexto
Ágora contiene varios subdominios, pero el tamaño del equipo, contexto educativo y operación institucional no justifican microservicios.

## Decisión
Implementar un único backend desplegable, organizado internamente por módulos y arquitectura hexagonal.

## Consecuencias
- despliegue simple;
- transacciones locales;
- menor complejidad operativa;
- límites de módulo deben seguir siendo explícitos para una posible separación futura.
