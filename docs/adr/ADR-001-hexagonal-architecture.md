# ADR-001 — Arquitectura hexagonal

**Estado:** Aceptado

## Contexto
El sistema histórico contiene lógica distribuida entre clientes, servicios y controladores. La reconstrucción busca separar reglas de negocio de frameworks.

## Decisión
Utilizar arquitectura hexagonal con proyectos Domain, Application, Infrastructure y Api.

## Consecuencias
Positivas:
- testabilidad;
- bajo acoplamiento;
- casos de uso explícitos;
- reemplazo de adaptadores.

Costos:
- más disciplina;
- más tipos/interfaces;
- riesgo de sobrearquitectura si se crean abstracciones sin necesidad.

## Regla
No crear interfaces por reflejo. Crear puertos donde exista una frontera real.
