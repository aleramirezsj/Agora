# Roles y permisos

## 1. Modelo de autorización

Ágora utiliza:

- **RBAC global** para privilegios institucionales.
- **RBAC contextual** para privilegios sobre una capacitación específica.

La autenticación no determina autorización. Firebase prueba identidad; Ágora decide permisos.

## 2. Roles globales

| Rol | Alcance |
|---|---|
| `SUPER_ADMIN` | Control total del sistema y configuración |
| `ADMIN_INSTITUCIONAL` | Administración funcional institucional |
| `USUARIO` | Acceso autenticado estándar |

## 3. Roles por capacitación

| Rol | Propósito |
|---|---|
| `ORGANIZADOR` | Gestión operativa de la capacitación |
| `ACREDITADOR` | Registro de asistencia |
| `COBRADOR` | Registro y validación de pagos |
| `GESTOR_CERTIFICADOS` | Gestión de certificados |

Una misma persona puede poseer varios roles contextuales sobre la misma capacitación.

## 4. Matriz inicial de permisos

| Acción | Super Admin | Admin Institucional | Organizador | Acreditador | Cobrador | Gestor Certificados | Usuario |
|---|---:|---:|---:|---:|---:|---:|---:|
| Administrar catálogos | ✓ | ✓ |  |  |  |  |  |
| Crear capacitación | ✓ | ✓ |  |  |  |  |  |
| Modificar configuración estructural | ✓ | ✓ | según política futura |  |  |  |  |
| Asignar roles contextuales | ✓ | ✓ |  |  |  |  |  |
| Ver inscriptos de capacitación | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |  |
| Inscripción presencial | ✓ | ✓ | ✓ |  |  |  |  |
| Registrar asistencia | ✓ | ✓ | según permiso | ✓ |  |  |  |
| Registrar pago | ✓ | ✓ | según permiso |  | ✓ |  |  |
| Validar transferencia | ✓ | ✓ | según permiso |  | ✓ |  |  |
| Gestionar certificados | ✓ | ✓ | según permiso |  |  | ✓ |  |
| Consultar reportes de capacitación | ✓ | ✓ | ✓ | limitado | limitado | limitado |  |
| Reporte económico institucional | ✓ | ✓ |  |  |  |  |  |
| Auditoría institucional | ✓ | ✓ |  |  |  |  |  |
| Ver portal público | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |
| Inscribirse online | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |
| Descargar certificado propio habilitado | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ | ✓ |

## 5. Reglas de asignación

1. Sólo `SUPER_ADMIN` o `ADMIN_INSTITUCIONAL` autorizados pueden asignar roles contextuales.
2. Ningún rol administrativo se obtiene por autorregistro.
3. Los roles contextuales deben incluir `CapacitacionId`.
4. Un usuario puede ser expositor, organizador y participante en distintas capacitaciones simultáneamente.
5. Los endpoints deben verificar permiso y contexto en backend. Ocultar botones en frontend no constituye autorización.
6. Todas las asignaciones y revocaciones de roles se auditan.
