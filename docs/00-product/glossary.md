# Glosario de dominio

## Capacitación
Actividad formativa organizada por la institución. Puede tener una o varias jornadas.

## Jornada
Encuentro concreto perteneciente a una capacitación, con fecha, hora y lugar. Al crear una capacitación se crea inicialmente una primera jornada.

## Tipo de capacitación
Catálogo configurable: curso, charla, taller, jornada, seminario, congreso u otros incorporados por administración.

## Expositor
Persona que participa como disertante. No requiere cuenta en Ágora.

## Organizador
Usuario con responsabilidades operativas sobre una capacitación determinada. Es diferente del expositor, aunque una misma persona puede cumplir ambos roles.

## Usuario
Identidad interna de Ágora, identificada por `UsuarioId` UUID.

## Identidad Firebase
Identidad técnica autenticada por Firebase Authentication, identificada por `FirebaseUid`.

## DNI
Dato de negocio utilizado para identificar a una persona y para vincular futuras cuentas con inscripciones presenciales previamente cargadas. No es clave primaria.

## Tipo de inscripción
Categoría aplicada a una inscripción determinada y utilizada, entre otras cosas, para definir el precio aplicable. Ejemplos: estudiante, docente, público general, jubilado.

## Inscripción
Vínculo entre una persona y una capacitación. Conserva el tipo y precio aplicados al momento de registrarse.

## Inscripción vigente
Inscripción que no fue cancelada, anulada ni reemplazada por un estado terminal equivalente. La definición exacta debe reflejarse en el enum de estados y en la restricción de unicidad lógica.

## Lista de espera
Cola ordenada de personas interesadas cuando el cupo está completo y la capacitación tiene esta funcionalidad habilitada.

## Acreditación
En Ágora significa registro de asistencia. La asistencia se registra por jornada.

## Pago
Movimiento asociado a una inscripción. Una inscripción puede tener varios pagos.

## Transferencia pendiente
Pago por transferencia cuyo comprobante fue cargado pero todavía no fue validado.

## Certificado
Documento PDF emitido para un participante que cumple las condiciones definidas por la capacitación.

## Plantilla de certificado
Imagen JPG/PNG utilizada como fondo del certificado, sobre la que Ágora posiciona campos dinámicos configurables.

## Código de certificado
Identificador único del certificado con formato `XXXXXXXX-DDMMAAAA-DNI`, donde el primer segmento corresponde a los primeros ocho caracteres alfanuméricos normalizados del nombre de la capacitación, el segundo a la fecha de su jornada inicial y el tercero al DNI del asistente sin separadores. El código es determinístico e inmutable una vez emitido.

## QR de validación
Código QR incluido en el certificado y que dirige a una página pública de validación.

## Rol global
Rol aplicable a todo el sistema: `SUPER_ADMIN`, `ADMIN_INSTITUCIONAL`, `USUARIO`.

## Rol contextual
Rol válido sobre una capacitación concreta: `ORGANIZADOR`, `ACREDITADOR`, `COBRADOR`, `GESTOR_CERTIFICADOS`.

## Permiso
Capacidad concreta derivada de un rol y, cuando corresponde, del contexto de una capacitación.

## Soft delete
Baja lógica que conserva el registro.

## Anulación
Cambio explícito de estado utilizado para transacciones que no deben borrarse, como pagos o asistencias.

## Revocación
Invalidación explícita de un certificado previamente emitido.

## Auditoría
Registro inmutable o protegido de quién realizó una operación, cuándo, sobre qué recurso y qué cambió.
