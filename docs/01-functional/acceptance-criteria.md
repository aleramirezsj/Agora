# Criterios de aceptación

Los criterios se expresan en formato Given/When/Then para poder transformarlos en pruebas.

## `CA-CAP-001` Creación con jornada inicial
**Dado** un administrador autorizado  
**cuando** crea una capacitación indicando fecha, hora y lugar  
**entonces** se crea la capacitación  
**y** se crea exactamente una jornada inicial asociada  
**y** ambos registros se persisten dentro de una operación consistente.

## `CA-CAP-002` Catálogo ampliable
**Dado** un administrador  
**cuando** crea un nuevo tipo de capacitación  
**entonces** el nuevo tipo queda disponible para futuras capacitaciones sin desplegar código nuevo.

## `CA-INS-001` Inscripción con cupo
**Dado** una capacitación con inscripción abierta y cupo disponible  
**y** un usuario autenticado y verificado  
**cuando** se inscribe  
**entonces** se crea una inscripción vigente con tipo y precio congelados.

## `CA-INS-002` Duplicado
**Dado** un usuario con inscripción vigente  
**cuando** intenta inscribirse nuevamente a la misma capacitación  
**entonces** la operación se rechaza  
**y** no se crea un segundo registro vigente.

## `CA-INS-003` Concurrencia de último cupo
**Dado** una capacitación con un único lugar disponible  
**cuando** dos solicitudes válidas intentan ocuparlo simultáneamente  
**entonces** como máximo una inscripción queda confirmada  
**y** la otra se rechaza o pasa a lista de espera según política  
**y** nunca se supera el cupo.

## `CA-INS-004` Cancelación válida
**Dado** una inscripción vigente  
**y** faltan más de 24 horas para el inicio de la capacitación  
**cuando** el participante cancela  
**entonces** la inscripción cambia a cancelada  
**y** el cupo se libera.

## `CA-INS-005` Cancelación fuera de término
**Dado** una inscripción vigente  
**y** faltan menos de 24 horas para el inicio  
**cuando** el participante intenta cancelar  
**entonces** el sistema rechaza la operación.

## `CA-ESP-001` Promoción de lista de espera
**Dado** una capacitación completa con lista de espera  
**y** al menos una persona en espera  
**cuando** se libera un cupo  
**entonces** la persona ubicada primero es promovida automáticamente  
**y** se crea/actualiza su inscripción como confirmada  
**y** se genera un evento notificable.

## `CA-USR-001` Inscripción presencial sin cuenta
**Dado** un operador autorizado  
**cuando** registra una persona sin cuenta mediante DNI y datos mínimos  
**entonces** la inscripción se crea sin exigir `FirebaseUid`.

## `CA-USR-002` Vinculación futura exclusivamente por DNI
**Dado** una persona con una o más inscripciones presenciales previas cargadas por un administrativo  
**y** una cuenta autenticada que informa el mismo DNI normalizado  
**cuando** el sistema procesa la vinculación  
**entonces** vincula automáticamente a la cuenta las inscripciones previas asociadas a ese DNI  
**y** no solicita ninguna comprobación adicional de identidad  
**y** no duplica inscripciones  
**y** registra la vinculación en auditoría.

## `CA-ASI-001` Registro de asistencia
**Dado** un acreditador autorizado para una capacitación  
**cuando** busca un inscripto por DNI o apellido y marca presente en una jornada  
**entonces** la asistencia queda registrada para esa jornada  
**y** la operación queda auditada.

## `CA-ASI-002` Porcentaje
**Dado** una capacitación de cuatro jornadas y requisito de 75%  
**cuando** una persona registra tres asistencias válidas  
**entonces** cumple el requisito de asistencia.

## `CA-PAG-001` Efectivo
**Dado** un cobrador autorizado  
**cuando** registra un pago en efectivo  
**entonces** se persisten monto, fecha, medio, inscripción y actor.

## `CA-PAG-002` Transferencia
**Dado** un participante autenticado  
**cuando** registra una transferencia con comprobante válido  
**entonces** el archivo se almacena en ubicación privada  
**y** el pago queda `PENDIENTE_VALIDACION`.

## `CA-PAG-003` Validación de transferencia
**Dado** un pago pendiente  
**y** un usuario autorizado  
**cuando** lo aprueba  
**entonces** cambia a aprobado  
**y** queda registrado quién y cuándo lo validó.

## `CA-CER-001` Elegibilidad gratuita
**Dado** una capacitación gratuita  
**y** un participante que alcanza el porcentaje de asistencia  
**cuando** se procesa elegibilidad  
**entonces** puede generarse su certificado.

## `CA-CER-002` Elegibilidad paga
**Dado** una capacitación con costo  
**y** un participante que alcanza asistencia  
**pero** no completó pago aprobado  
**cuando** se procesa elegibilidad  
**entonces** no puede descargarse certificado.

## `CA-CER-003` Generación
**Dado** un participante elegible y una plantilla válida  
**cuando** se genera el certificado  
**entonces** se produce un PDF  
**con** los campos dinámicos posicionados según la configuración académica de la plantilla  
**y** un código único con formato `XXXXXXXX-DDMMAAAA-DNI`  
**y** QR de validación.

## `CA-CER-003A` Construcción del código
**Dado** una capacitación denominada `Programación Avanzada` cuya jornada inicial es el 31/08/2026  
**y** un asistente con DNI `30.123.456`  
**cuando** se genera el código de certificado  
**entonces** el prefijo se obtiene del nombre normalizado de la capacitación  
**y** la fecha se expresa como `31082026`  
**y** el DNI se expresa como `30123456` sin separadores  
**y** el valor generado permanece inmutable después de la emisión.

## `CA-CER-003B` Editor académico de plantilla
**Dado** una plantilla JPG/PNG válida  
**cuando** un gestor autorizado configura campos dinámicos  
**entonces** puede posicionarlos visualmente sobre la plantilla  
**y** configurar tipografía, tamaño, peso, estilo, color, alineación y dimensiones del área desde controles orientados a presentación académica  
**y** obtiene una previsualización consistente con el PDF que posteriormente generará Ágora.

## `CA-CER-004` Habilitación
**Dado** certificados generados en revisión  
**cuando** administración los habilita  
**entonces** los participantes elegibles pueden descargarlos desde Mi Ágora.

## `CA-CER-005` Revocación
**Dado** un certificado emitido  
**cuando** un gestor autorizado lo revoca  
**entonces** deja de ser válido  
**y** el registro se conserva  
**y** la página pública indica que está revocado.

## `CA-RBAC-001` Autorización contextual
**Dado** un usuario con rol `ACREDITADOR` en capacitación A  
**cuando** intenta acreditar capacitación B  
**entonces** recibe prohibición de acceso aunque esté autenticado.

## `CA-AUD-001` Auditoría
**Dado** una operación crítica exitosa  
**cuando** finaliza la transacción  
**entonces** existe un registro de auditoría con actor, acción, entidad y fecha  
**y**, cuando corresponde, valores anterior y nuevo.

## `CA-API-001` Paginación
**Dado** más elementos que `pageSize`  
**cuando** se consulta un listado paginado  
**entonces** la respuesta incluye `items`, `page`, `pageSize`, `totalItems` y `totalPages`.

## `CA-API-002` Error estándar
**Dado** una solicitud inválida  
**cuando** la API la rechaza  
**entonces** responde con `application/problem+json` siguiendo ProblemDetails.
