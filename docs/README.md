# Ágora — Documentación rectora del desarrollo

Esta carpeta contiene la documentación funcional, técnica y de ejecución que rige la reconstrucción de **Ágora**, plataforma de gestión de capacitaciones del Instituto N.º 20.

El objetivo de estos documentos es servir simultáneamente como:

- especificación del producto;
- contrato funcional para docentes, estudiantes y equipo de gestión;
- guía técnica para el equipo de desarrollo;
- contexto estable para agentes de código como OpenCode;
- material didáctico para enseñar desarrollo profesional, arquitectura, pruebas y trazabilidad.

## Principios rectores

1. El código nuevo se construye sobre una arquitectura nueva; el sistema histórico se usa como referencia funcional y fuente de aprendizaje.
2. Las reglas de negocio deben estar expresadas en el dominio y en casos de uso, no dispersas entre controladores y pantallas.
3. La API nunca expone entidades de persistencia directamente.
4. Firebase Authentication resuelve identidad; Ágora resuelve autorización y permisos.
5. Toda operación crítica debe ser auditable.
6. El frontend oficial es Next.js.
7. El backend oficial es ASP.NET Core Web API.
8. PostgreSQL es la base relacional.
9. Firebase Storage almacena archivos; PostgreSQL almacena referencias y metadatos.
10. La implementación se realiza incrementalmente según el roadmap y los criterios de aceptación.

## Estructura

```text
docs/
├── 00-product/
│   ├── vision.md
│   ├── glossary.md
│   └── roles-permissions.md
├── 01-functional/
│   ├── functional-specification.md
│   ├── business-rules.md
│   └── acceptance-criteria.md
├── 02-architecture/
│   ├── architecture.md
│   ├── domain-model.md
│   ├── api-guidelines.md
│   ├── security.md
│   └── storage.md
├── 03-development/
│   ├── roadmap.md
│   ├── development-plan.md
│   └── definition-of-done.md
└── adr/
    ├── ADR-001-hexagonal-architecture.md
    ├── ADR-002-firebase-auth.md
    ├── ADR-003-nextjs-frontend.md
    ├── ADR-004-firebase-storage.md
    ├── ADR-005-postgresql.md
    ├── ADR-006-modular-monolith.md
    ├── ADR-007-dni-account-linking.md
    └── ADR-008-academic-certificate-format.md
```

## Convención de identificadores

- `MOD-*`: módulo funcional.
- `RF-*`: requisito funcional.
- `RN-*`: regla de negocio.
- `CA-*`: criterio de aceptación.
- `ADR-*`: decisión arquitectónica.
- `F-*`: fase del roadmap.

## Estado del documento

Versión: **1.1**  
Fecha base: **2026-08-31**

Los `TBD-001`, `TBD-002` y `TBD-003` originales fueron resueltos y documentados. Cualquier nuevo punto no especificado debe registrarse explícitamente como decisión pendiente y no ser inferido silenciosamente por un agente de código.
