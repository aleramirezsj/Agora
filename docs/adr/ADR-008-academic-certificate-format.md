# ADR-008 — Formato de código y editor académico de certificados

## Estado
Aceptada — 2026-08-31

## Contexto
Ágora genera certificados PDF a partir de una imagen JPG/PNG que ya contiene el diseño institucional, firmas, logos y textos estáticos. El sistema superpone únicamente campos dinámicos y un mecanismo de validación.

## Decisión
### Código único
El código oficial tiene formato:

```text
XXXXXXXX-DDMMAAAA-DNI
```

- `XXXXXXXX`: primeros ocho caracteres alfanuméricos del nombre de la capacitación normalizado a mayúsculas, sin tildes, espacios ni signos. Si el nombre normalizado posee menos de ocho caracteres, se utiliza completo.
- `DDMMAAAA`: fecha de la jornada inicial de la capacitación.
- `DNI`: DNI del asistente sin puntos ni separadores.

El código generado es inmutable una vez emitido el certificado.

### Editor de plantilla
El editor será una herramienta específica para documentos académicos, no un editor gráfico generalista.

Debe permitir:
- cargar/versionar fondo JPG/PNG;
- ubicar tokens dinámicos sobre el lienzo;
- editar coordenadas y dimensiones;
- seleccionar familia tipográfica desde un catálogo controlado;
- configurar tamaño, peso, estilo, color y alineación;
- utilizar guías y ayudas de alineación;
- previsualizar el resultado final;
- garantizar que la salida PDF reproduzca fielmente la previsualización.

El criterio visual será formal, sobrio, profesional y compatible con documentación académica. No se priorizan filtros, efectos decorativos ni herramientas propias de diseño publicitario.

## Consecuencias
- la generación debe usar una misma lógica de layout para previsualización y PDF;
- las fuentes utilizadas deben estar disponibles de forma determinística en el entorno de generación;
- cambios de plantilla deberán versionarse para preservar certificados previamente emitidos;
- el código incluye DNI y, por decisión funcional, puede ser visible en la validación pública.
