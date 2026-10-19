# Estrategia de archivos — Firebase Storage

## 1. Principio

Los archivos se almacenan en Firebase Storage. PostgreSQL persiste metadata y referencias.

## 2. Rutas lógicas

```text
/capacitaciones/{id}/flyers/
/capacitaciones/{id}/expositores/
/capacitaciones/{id}/certificados/plantillas/
/inscripciones/{id}/comprobantes/
```

Se recomienda agregar identificador/versionado al nombre físico para evitar colisiones.

## 3. Visibilidad

| Categoría | Visibilidad |
|---|---|
| Flyer | Pública |
| Foto de expositor | Pública |
| Plantilla de certificado | Privada administrativa |
| Comprobante de transferencia | Privada |
| PDF de certificado | Privada para descarga autenticada; validación pública por datos, no necesariamente por archivo |

## 4. Versionado

Conservar versiones anteriores de:
- flyers;
- plantillas.

Cada versión debe registrar:
- versión;
- fecha;
- usuario;
- storage path;
- activa/inactiva.

No sobrescribir silenciosamente un objeto si se necesita trazabilidad.

## 5. Metadata en PostgreSQL

Entidad `Asset`:
- UUID;
- categoría;
- storage path;
- public URL opcional;
- MIME;
- tamaño;
- hash opcional;
- visibilidad;
- versión;
- created by;
- created at;
- deleted/disabled metadata.

## 6. Carga

Preferencia arquitectónica:
- backend autoriza la intención de carga;
- se genera mecanismo de subida seguro o el backend recibe y reenvía;
- el cliente nunca obtiene privilegios amplios de Storage.

La estrategia concreta entre upload directo firmado o proxy backend se decidirá durante implementación considerando tamaño y simplicidad.

## 7. Eliminación

En recursos versionados, preferir marcar versión inactiva antes que eliminar inmediatamente.

Los comprobantes asociados a pagos anulados deben conservarse según política institucional de retención.

## 8. Certificados

La plantilla es imagen. El PDF puede:
- persistirse una vez generado, o
- regenerarse de manera determinística.

Para auditoría y estabilidad se recomienda persistir el PDF final emitido/revisionado con referencia a la versión exacta de plantilla usada.
