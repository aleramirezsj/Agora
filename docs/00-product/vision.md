# Visión del producto — Ágora

## 1. Propósito

Ágora es la plataforma institucional para organizar, publicar, administrar y auditar capacitaciones del Instituto N.º 20.

Debe cubrir el ciclo completo:

```text
Planificación
  ↓
Publicación
  ↓
Inscripción
  ↓
Acreditación de asistencia
  ↓
Registro y validación de pagos
  ↓
Finalización
  ↓
Emisión y validación de certificados
```

## 2. Problema que resuelve

La institución necesita centralizar procesos que, de otra manera, quedarían distribuidos entre formularios, planillas, listados impresos, comprobantes, registros manuales y aplicaciones independientes.

Ágora debe brindar una fuente de verdad única para:

- capacitaciones;
- jornadas;
- participantes;
- responsables;
- inscripciones;
- lista de espera;
- asistencias;
- pagos;
- certificados;
- permisos;
- reportes;
- auditoría.

## 3. Usuarios del producto

### Público general
Consulta capacitaciones públicas, crea una cuenta, se inscribe y accede a su historial.

### Participante autenticado
Administra su perfil, consulta inscripciones, pagos, asistencias y certificados.

### Personal de acreditación
Registra asistencia para las capacitaciones en las que fue autorizado.

### Personal de cobro
Registra pagos y valida transferencias de las capacitaciones en las que fue autorizado.

### Organizador
Administra operativamente una capacitación determinada dentro de los permisos asignados.

### Gestor de certificados
Gestiona generación, revisión, habilitación y revocación de certificados.

### Administración institucional
Gestiona el sistema a nivel institucional, capacitaciones, usuarios, roles, catálogos, responsables, reportes y auditoría.

### Superadministración
Posee control total de configuración y administración.

## 4. Alcance inicial

La primera versión profesional debe incluir:

- portal público;
- autenticación con Firebase;
- gestión de perfiles;
- gestión de capacitaciones y jornadas;
- tipos de capacitación configurables;
- tipos de inscripción configurables;
- expositores;
- organizadores y permisos contextuales;
- cupos;
- lista de espera configurable;
- inscripción online;
- inscripción presencial;
- acreditación por jornada;
- pagos en efectivo;
- transferencias con comprobante y validación;
- certificados PDF;
- plantillas de certificado basadas en imagen;
- QR de validación pública;
- reportes operativos y económicos;
- dashboard;
- auditoría;
- soft delete donde corresponda;
- API REST versionada;
- frontend Next.js;
- despliegue Docker sobre VPS;
- CI/CD con GitHub Actions.

## 5. Restricciones de alcance

Fuera del alcance inicial:

- modalidad virtual;
- modalidad híbrida;
- sistema de caja/arqueo;
- descuentos, becas o bonificaciones;
- API pública para terceros;
- aplicación WinForms, Blazor o MAUI como clientes oficiales;
- firma digital criptográfica de certificados.

## 6. Objetivos de calidad

Ágora debe ser:

- mantenible;
- testeable;
- auditable;
- seguro;
- accesible desde dispositivos móviles y escritorio;
- resiliente frente a concurrencia de inscripciones;
- explícito en sus reglas de negocio;
- modular y preparado para evolución;
- didácticamente comprensible para estudiantes de programación.

## 7. Evolución prevista

La arquitectura deberá permitir incorporar más adelante:

- Firebase Cloud Messaging;
- acreditación mediante QR;
- diseñador visual de certificados;
- notificaciones por distintos canales;
- métricas institucionales avanzadas;
- integración con otros sistemas del Instituto;
- eventos y procesos asíncronos.
