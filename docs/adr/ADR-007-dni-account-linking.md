# ADR-007 — Vinculación de cuentas por DNI

## Estado
Aceptada — 2026-08-31

## Contexto
Ágora permite que personal administrativo registre presencialmente una inscripción para una persona que todavía no posee una cuenta. Posteriormente esa persona puede crear una identidad mediante Firebase Authentication.

## Decisión
La vinculación entre la nueva cuenta y los registros presenciales previos se realizará exclusivamente por coincidencia del DNI normalizado.

No se exigirá email coincidente, código de verificación, revisión administrativa ni otro factor adicional. La coincidencia exacta del DNI será suficiente para ejecutar el vínculo.

La implementación deberá:
- normalizar DNI eliminando puntos, espacios y separadores;
- vincular todos los registros presenciales compatibles asociados al DNI;
- ser idempotente;
- evitar duplicar inscripciones;
- auditar actor, registros afectados, fecha/hora e IP cuando esté disponible.

## Consecuencias
### Positivas
- flujo simple para asistentes;
- recuperación automática de historial presencial;
- baja carga operativa para administración.

### Riesgos aceptados
Una persona que conozca el DNI de otra podría intentar apropiarse de sus registros previos. Este riesgo es conocido y aceptado como decisión de producto. No debe introducirse un control adicional sin una nueva decisión funcional/arquitectónica.
