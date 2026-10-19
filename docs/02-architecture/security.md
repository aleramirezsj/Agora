# Seguridad

## 1. Modelo de confianza

Firebase Authentication es el proveedor de identidad.

Ágora no confía en:
- roles enviados por el frontend;
- IDs de usuario enviados como autoridad;
- visibilidad de UI como mecanismo de autorización.

## 2. Autenticación

Métodos:
- email + contraseña;
- Google.

Requisito:
- email verificado para acciones protegidas definidas.

Flujo:
1. usuario autentica en Firebase;
2. frontend obtiene ID Token;
3. frontend envía Bearer token;
4. backend valida token con Firebase Admin SDK;
5. backend resuelve `FirebaseUid` → `UsuarioId`;
6. backend aplica autorización.

## 3. Autorización

Usar policies/handlers.

Ejemplos conceptuales:
- `RequireGlobalAdmin`;
- `CanManageTraining(trainingId)`;
- `CanRecordAttendance(trainingId)`;
- `CanManagePayments(trainingId)`;
- `CanManageCertificates(trainingId)`.

El acceso contextual debe consultar asignaciones vigentes.

## 4. DNI y vinculación de cuentas

El DNI es información personal.

Por decisión funcional, la vinculación automática de una cuenta Firebase con registros creados presencialmente se basa exclusivamente en la coincidencia exacta del DNI informado por el usuario con el DNI registrado previamente por un administrativo.

Reglas:
- normalizar el DNI antes de comparar, eliminando puntos, espacios y separadores;
- una coincidencia válida vincula automáticamente las inscripciones presenciales previas a la cuenta autenticada;
- no se solicita prueba adicional de identidad;
- la operación de vinculación debe quedar auditada con usuario, registros vinculados, fecha/hora e IP cuando esté disponible;
- una vez vinculados los registros, el proceso debe ser idempotente y no duplicar inscripciones.

Esta política implica un riesgo conocido de apropiación de registros por conocimiento del DNI. El riesgo fue aceptado expresamente como decisión de producto y no debe ser modificado por un agente de código sin una nueva decisión arquitectónica.

## 5. Archivos privados

Los comprobantes:
- no deben tener URL pública permanente;
- deben accederse mediante reglas seguras o URLs firmadas/de corta duración;
- requieren permiso para lectura;
- deben registrar metadata y propietario.

## 6. Certificados públicos

La validación pública debe revelar únicamente los datos necesarios para probar autenticidad.

Debe evitar exponerse información personal adicional innecesaria.

El código público del certificado utiliza el formato `XXXXXXXX-DDMMAAAA-DNI`, por lo que expone el DNI como parte del identificador verificable. Esta exposición es una decisión funcional explícita. La página pública de validación no debe revelar datos personales adicionales que no sean necesarios para validar el certificado.

## 7. Rate limiting

Aplicar especialmente en:
- login-related backend endpoints si existiesen;
- validación pública de certificados;
- búsquedas públicas;
- endpoints de carga;
- acciones sensibles.

## 8. CORS

Permitir únicamente orígenes definidos por ambiente.

## 9. Secrets

Nunca versionar:
- service account;
- Firebase admin credentials;
- DB password;
- signing secrets;
- production API keys.

Usar:
- GitHub Secrets/Environments;
- variables de entorno;
- secretos del servidor.

## 10. Logging

No registrar:
- tokens;
- contraseñas;
- comprobantes;
- datos sensibles completos;
- credenciales Firebase.

Enmascarar DNI cuando aparezca en logs técnicos.

## 11. Auditoría

Auditoría y logs técnicos tienen objetivos distintos.

Auditar:
- cambios de roles;
- pagos;
- asistencia;
- certificados;
- cambios críticos de capacitación;
- vinculación de cuentas;
- anulaciones/revocaciones.

## 12. Subidas

Validar:
- tipo MIME real;
- extensión permitida;
- tamaño máximo;
- categoría;
- autorización;
- nombre generado por servidor.

No confiar en filename del cliente.
