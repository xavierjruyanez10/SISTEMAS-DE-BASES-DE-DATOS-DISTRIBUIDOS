# Cuestionario de Bases de Datos Distribuidas
### 1. Describa brevemente el proceso de creación de instancias en SQL Server. ¿Cuáles son los pasos básicos de configuración y cuál es la importancia de esta actividad en el contexto de una BDD distribuida?
Se espera que se mencionen pasos como la instalación de SQL Server, configuración de la instancia, definición de parámetros de replicación y seguridad, y la verificación de la comunicación. La actividad es clave para que cada nodo (o instancia) pueda formar parte del sistema distribuido.

### 2. Identifique y explique al menos tres medidas o estrategias de seguridad que se deben implementar en una BDD distribuida.
Se deben incluir estrategias como la autenticación de usuarios en cada nodo, el cifrado de datos en tránsito, el control de acceso basado en roles y la auditoría de las operaciones de replicación y consulta.

### 3. Compare el modelo de Amazon DynamoDB con un sistema MySQL centralizado. ¿Qué ventajas ofrece cada uno en términos de escalabilidad, rendimiento y administración de datos?
Se espera un análisis donde se mencione que Amazon DynamoDB, al ser distribuido, ofrece una mayor escalabilidad y tolerancia a fallos, mientras que MySQL centralizado puede ser más sencillo de administrar pero presenta limitaciones en cuanto a escalabilidad y disponibilidad.

### 4. Describa las principales responsabilidades del administrador de bases de datos en un entorno distribuido.
La respuesta debe incluir funciones como la configuración y mantenimiento de instancias, gestión de seguridad, coordinación de transacciones distribuidas, monitoreo de rendimiento y planificación de recuperación ante fallos.

### 5. Describa en qué consiste el procesamiento distribuido de consultas en una BDD y mencione dos desafíos que se deben considerar en este proceso.
La respuesta debe explicar que el procesamiento distribuido de consultas involucra la ejecución de partes de una consulta en múltiples nodos y la posterior unión de los resultados, considerando retos como el costo de comunicación y la optimización de rutas de consulta.
### 6. Describa el rol de un Sistema de Gestión de Bases de Datos Distribuidas (DDBMS) y mencione al menos tres de sus componentes o funciones principales.
Se espera que se mencione que el DDBMS administra la distribución de datos, coordina transacciones entre nodos y oculta la complejidad de la distribución, entre otros componentes como el procesador de transacciones, el directorio de datos distribuidos y el gestor de consultas.

### 7. Defina los siguientes tipos de fragmentación en bases de datos distribuidas y mencione, al menos, una ventaja de cada uno:
- a) Fragmentación horizontal  
- b) Fragmentación vertical  
- c) Fragmentación mixta  
La fragmentación horizontal divide la tabla por filas, la vertical por columnas (manteniendo la clave primaria) y la mixta es una combinación de ambas, destacando ventajas como la optimización en el acceso y la distribución de la carga.

### 8. Describa cuáles son las principales responsabilidades de un DBA (Administrador de Bases de Datos) en un entorno distribuido, considerando aspectos de seguridad, replicación y recuperación.
Se espera que se mencionen funciones como monitoreo de la replicación, coordinación de transacciones distribuidas, implementación de políticas de seguridad, mantenimiento de la consistencia entre nodos y planificación para la recuperación ante fallos.

### 9. Explique el concepto de replicación en las bases de datos distribuidas y mencione al menos dos ventajas y un inconveniente de utilizar replicación.
La replicación consiste en mantener copias idénticas de datos en diferentes nodos para mejorar la disponibilidad y el rendimiento. Ventajas: aumento del paralelismo y tolerancia a fallos. Inconveniente: dificultad para mantener la consistencia.

### 10. Explique qué es una transacción distribuida y describa brevemente el protocolo de Two-Phase Commit (2PC) utilizado para asegurar la atomicidad en entornos distribuidos.
Una transacción distribuida abarca operaciones en varios nodos. El protocolo 2PC incluye una fase de consulta (voto) y una fase de confirmación para asegurar que todas las partes involucradas confirmen o aborten la transacción de forma coordinada.

### 11. ¿Qué es la fragmentación horizontal y cómo se implementaría en una BDD? Dé un ejemplo práctico.
La fragmentación horizontal divide una tabla en subconjuntos de filas (por ejemplo, por ciudad o rango de fechas) para mejorar el rendimiento de consultas locales. Ejemplo: fragmentar una tabla de estudiantes en “Estudiantes_Quito”, “Estudiantes_Ambato” y “Estudiantes_Cuenca”.

### 12. Defina qué es una Base de Datos Distribuida (BDD) y explique cómo difiere de una base de datos centralizada.
Una BDD es un conjunto de datos repartidos en distintos nodos de una red, que se gestionan de forma conjunta y se presentan de manera transparente al usuario. Una base centralizada almacena todos los datos en un solo servidor.

### 13. Describa brevemente los tres tipos de fragmentación (horizontal, vertical y mixta) que se pueden aplicar en una base de datos distribuida.
- Horizontal: división de una tabla en subconjuntos de filas.
- Vertical: división por columnas, manteniendo la clave primaria.
- Mixta: combinación de ambas para optimizar rendimiento y seguridad.

### 14. Explique cómo la distribución de datos en una BDD puede afectar el rendimiento de las consultas. ¿Qué estrategias se pueden utilizar para optimizar dicho rendimiento?
La distribución puede generar costos de comunicación entre nodos y mayor latencia en consultas globales. Estrategias para optimizar: fragmentación adecuada, caches locales y optimización de consultas distribuidas.

### 15. ¿Qué es el sharding en las BDD y cuáles son sus principales beneficios y desafíos?
El sharding es el particionamiento horizontal de datos en fragmentos (shards) que se distribuyen en distintos nodos. Beneficios: escalabilidad y distribución de la carga. Desafíos: mantener la consistencia y balanceo entre shards.
### 16. Mencione y explique al menos tres ventajas y dos desventajas de implementar una arquitectura de bases de datos distribuidas.
Ventajas: alta disponibilidad, tolerancia a fallos, escalabilidad.  
Desventajas: complejidad administrativa, problemas de consistencia y dificultad en la gestión de transacciones distribuidas.

### 17. ¿Qué estrategias se pueden implementar en una BDD distribuida para minimizar el costo y la sobrecarga de la transferencia de datos entre nodos y mejorar la eficiencia de las consultas?
Fragmentación adecuada, uso de caching, optimización de rutas de consulta, consultas locales y diseño inteligente del esquema de datos.

### 18. Explique cómo se puede configurar un nodo distribuido en Docker. Describa los pasos principales y mencione las ventajas de utilizar contenedores en la implementación de BDD distribuidas.
Crear contenedor con una instancia de base de datos (SQL Server, PostgreSQL), establecer red entre contenedores, configurar servicios. Ventajas: portabilidad, facilidad de escalado y entornos consistentes.

### 19. Analice cómo Docker y Docker Compose pueden facilitar el despliegue y la administración de sistemas de bases de datos distribuidas. Describa, en líneas generales, los pasos necesarios para configurar un entorno distribuido utilizando contenedores Docker.
Ventajas: simular nodos fácilmente, redes definidas, despliegue uniforme. Pasos: definir servicios en `docker-compose.yml`, levantar contenedores, establecer redes y configurar acceso entre nodos.

### 20. Defina qué es la fragmentación horizontal en el contexto de BDD y mencione sus principales ventajas. Ilustre su respuesta con un ejemplo práctico (por ejemplo, fragmentar una tabla de alumnos por ciudad).
Divide una tabla en subconjuntos de filas. Ventajas: mejora rendimiento de consultas locales, reduce tráfico entre nodos. Ejemplo: “Alumnos_Quito”, “Alumnos_Loja”.

### 21. ¿Qué es una instancia en SQL Server? Explique la diferencia entre una instancia Default y una instancia Named, ilustrando con ejemplos prácticos.
Instancia: entorno de ejecución independiente del motor SQL Server. Default: `localhost`; Named: `localhost\MiInstancia`. Se accede según el tipo.

### 22. Compare las bases de datos distribuidas homogéneas con las heterogéneas y mencione en qué escenarios se utilizaría cada tipo.
Homogéneas: todos los nodos usan el mismo DBMS, ideal para administración simple. Heterogéneas: integración de distintos DBMS, útil en entornos diversos.

### 23. Defina la fragmentación horizontal y proponga un ejemplo práctico.
División de tabla por filas, por criterios como ciudad o rango de fechas. Ejemplo: “Ventas_Quito”, “Ventas_Guayaquil”.

### 24. Imagine que debe diseñar una base de datos distribuida para una universidad. Se requiere almacenar datos de estudiantes de diferentes ciudades mediante fragmentación horizontal basada en la ciudad.  
- a) Proponga un esquema de fragmentación horizontal para una tabla de estudiantes.  
- b) Explique cómo se podría implementar una vista global que permita consultar todos los datos de estudiantes, uniendo los fragmentos.
a) Tablas: `Estudiantes_Quito`, `Estudiantes_Loja`, `Estudiantes_Ambato`.  
b) Vista: `CREATE VIEW EstudiantesGlobal AS SELECT * FROM Estudiantes_Quito UNION ALL SELECT * FROM Estudiantes_Loja UNION ALL SELECT * FROM Estudiantes_Ambato;`

### 25. Compare brevemente los métodos de fragmentación horizontal, vertical e híbrida en una BDD. ¿Qué criterios se deben considerar para elegir cada método?
Horizontal: por filas, útil cuando los datos se acceden por ubicación.  
Vertical: por columnas, útil cuando se requieren ciertos atributos con frecuencia.  
Mixta: combina ambas. Depende de patrones de acceso, seguridad y eficiencia.
### 26. Defina qué es una base de datos distribuida y mencione sus características principales.
Una BDD es un conjunto de datos lógicamente relacionados distribuidos en distintas ubicaciones físicas, manejados por un DDBMS. Características: transparencia, autonomía local, replicación, fragmentación, concurrencia distribuida y disponibilidad.

### 27. ¿Qué es la fragmentación mixta en una base de datos distribuida? Explique sus ventajas y cómo se puede implementar combinando fragmentación horizontal y vertical.
Es la combinación de fragmentación horizontal (filas) y vertical (columnas). Ventajas: eficiencia en acceso y seguridad. Se implementa fragmentando por filas y luego dividiendo cada fragmento por columnas relevantes.

### 28. Explique los componentes de la arquitectura de una base de datos distribuida, mencionando los conceptos de esquema global, esquema de fragmentación, esquema de asignación y mapeo local.
- Esquema global: vista lógica unificada de los datos.  
- Fragmentación: define cómo se dividen las relaciones.  
- Asignación: especifica en qué nodos están los fragmentos.  
- Mapeo local: traduce fragmentos al formato de la base local.

### 29. Defina qué son las bases de datos distribuidas y compare sus principales características con las bases de datos centralizadas.
Las BDD distribuidas almacenan datos en múltiples ubicaciones, mientras que las centralizadas en una sola. Las BDD ofrecen escalabilidad, tolerancia a fallos y mayor disponibilidad, pero son más complejas de administrar.

### 30. Realice un análisis comparativo entre Amazon DynamoDB y un sistema basado en MySQL centralizado. Identifique las principales diferencias en cuanto a escalabilidad, disponibilidad y administración.
DynamoDB: escalabilidad horizontal, alta disponibilidad, administración compleja.  
MySQL: administración simple, pero limitado en escalabilidad y disponibilidad (único punto de fallo).

### 31. Describa los principales desafíos que pueden surgir en la recuperación y en el mantenimiento de la consistencia en sistemas de bases de datos distribuidas. Proponga al menos dos estrategias o mecanismos que pueden utilizarse para mitigar estos problemas.
Desafíos: fallos de nodos, latencia, sincronización.  
Estrategias: protocolos de consenso, replicación controlada, uso de gestores de recuperación (Recovery Managers).

### 32. Explique el concepto de independencia de datos en las BDD distribuidas y por qué es fundamental para que los usuarios puedan interactuar sin preocuparse por la ubicación física de los datos.
Permite trabajar con los datos sin conocer dónde están almacenados físicamente. Mejora la transparencia, reduce errores y facilita el desarrollo de aplicaciones.

### 33. Describa la arquitectura cliente-servidor en el contexto de bases de datos distribuidas y explique cómo se coordinan los accesos a los datos.
Clientes envían solicitudes a servidores que gestionan las BDD. Coordinación mediante protocolos y transacciones distribuidas controladas por un coordinador o middleware.

### 34. Explique el concepto de autonomía local en las bases de datos distribuidas y su importancia para el funcionamiento general del sistema.
Cada nodo puede procesar sus propias solicitudes y gestionar sus datos. Mejora tolerancia a fallos, disponibilidad y escalabilidad.

### 35. ¿Cuáles son los principales métodos para controlar la concurrencia en un sistema de bases de datos distribuidas y cuáles son sus desafíos?
Métodos: bloqueo distribuido, control de versiones, protocolos de consenso.  
Desafíos: latencia, coordinación compleja, riesgo de interbloqueos y mantener consistencia global.

### 36. Explique brevemente cuáles son los principales mecanismos para el control de concurrencia en sistemas de bases de datos distribuidas y cuáles son sus desafíos.
Mecanismos: bloqueo distribuido, control de versiones, algoritmos de timestamp y protocolos de consenso.  
Desafíos: sincronización entre nodos, latencia de red, mantenimiento de la consistencia y prevención de interbloqueos.

### 37. Explique cómo el ancho de banda y la latencia en la red impactan el rendimiento de una BDD distribuida.
Ancho de banda limitado o alta latencia afectan la velocidad de consultas, replicación y sincronización de datos, lo que puede provocar demoras en la disponibilidad de resultados y operaciones más costosas.

### 38. Explique las diferencias entre bases de datos distribuidas homogéneas y heterogéneas. ¿En qué escenarios se podría elegir cada una?
Homogéneas: todos los nodos usan el mismo DBMS, más fáciles de administrar.  
Heterogéneas: nodos con distintos DBMS, útiles cuando se integran sistemas legados o de múltiples proveedores.

### 39. Defina qué es el sharding en el contexto de bases de datos distribuidas, explique cómo funciona y mencione sus principales beneficios y desafíos.
Sharding: particionamiento horizontal de una tabla en fragmentos almacenados en distintos nodos.  
Beneficios: escalabilidad, rendimiento, distribución de la carga.  
Desafíos: balanceo de datos, mantenimiento de consistencia, rediseño complejo.

### 40. Explique qué es la replicación maestro-esclavo y describa, paso a paso, el proceso para configurar la replicación entre un servidor maestro (en Windows) y un servidor esclavo (en Ubuntu) utilizando SQL Server.
Replicación maestro-esclavo: un nodo actúa como fuente principal y los demás reciben copias.  
Pasos: configurar publicación en maestro (Windows), establecer roles y permisos, crear suscripción en esclavo (Ubuntu), sincronizar y probar.

### 41. ¿Qué estrategias pueden emplearse para optimizar el procesamiento de consultas en un entorno distribuido?
- Fragmentación adecuada  
- Uso de cachés locales  
- Minimizar transferencias de datos  
- Rutas de ejecución optimizadas  
- Consultas dirigidas a nodos específicos

### 42. Explique el concepto de independencia de datos en una BDD distribuida y por qué es fundamental para la transparencia del sistema.
Permite a los usuarios acceder a los datos sin conocer su ubicación o fragmentación. Mejora la experiencia del usuario y facilita el mantenimiento del sistema.

### 43. ¿Qué consideraciones de seguridad son importantes en el diseño de una BDD distribuida? Mencione al menos tres aspectos a tener en cuenta.
- Autenticación y autorización por nodo  
- Cifrado de datos en tránsito y en reposo  
- Políticas de replicación seguras y monitoreo de accesos

### 44. Compare el modelo de Amazon DynamoDB con un sistema basado en MySQL centralizado, enfocándose en escalabilidad, disponibilidad y complejidad administrativa.
DynamoDB: escalabilidad automática, alta disponibilidad global, administración abstracta.  
MySQL: más fácil de administrar localmente, pero con limitaciones de crecimiento y mayor riesgo de fallos únicos.

### 45. Explique las ventajas y limitaciones de utilizar una arquitectura distribuida para BDD en comparación con una centralizada, considerando aspectos como escalabilidad, disponibilidad y seguridad.
Ventajas: mejor escalabilidad, tolerancia a fallos, menor latencia.  
Limitaciones: administración más compleja, mayores riesgos de seguridad en múltiples nodos, dificultades de sincronización.
### 46. Explique la arquitectura ANSI-SPARC tradicional y cómo se extiende o modifica para soportar sistemas de bases de datos distribuidas.
La arquitectura ANSI-SPARC tiene tres niveles: externo (vistas de usuario), conceptual (modelo lógico) e interno (almacenamiento físico).  
En sistemas distribuidos se agregan:
- Esquema de fragmentación  
- Esquema de asignación  
- Esquema de mapeo local

### 47. Describa un ejemplo práctico de cómo fragmentar horizontalmente una tabla en PostgreSQL. Indique qué criterios utilizaría y cómo crear una vista global que reúna los fragmentos.
Ejemplo: fragmentar la tabla `Clientes` por ciudad.  
Tablas: `Clientes_Quito`, `Clientes_Cuenca`  
Vista global:
```sql
CREATE VIEW Clientes_Todos AS 
SELECT * FROM Clientes_Quito
UNION ALL
SELECT * FROM Clientes_Cuenca;

### 48. Enumere y describa al menos cuatro ventajas que ofrecen los sistemas de bases de datos distribuidas.
- Escalabilidad horizontal: permite añadir más nodos fácilmente.  
- Alta disponibilidad: los datos están accesibles incluso si un nodo falla.  
- Reducción de latencia: los datos pueden almacenarse más cerca del usuario.  
- Tolerancia a fallos: el sistema continúa funcionando ante errores parciales.

### 49. Compare la arquitectura de una base de datos centralizada con la arquitectura de una base de datos distribuida, enfatizando las diferencias en la administración y el control.
- Centralizada: un solo servidor, más simple de administrar, pero con punto único de fallo.  
- Distribuida: múltiples nodos, más compleja de administrar, pero con mayor resiliencia y escalabilidad.

### 50. Explique qué es la fragmentación vertical en una base de datos distribuida y proporcione un ejemplo práctico, mencionando la importancia de incluir la clave primaria en cada fragmento.
La fragmentación vertical divide una tabla por columnas.  
Ejemplo: `Clientes_Info(nombre, email, id)` y `Clientes_Ventas(id, monto)`.  
La clave primaria (`id`) debe estar presente en ambos fragmentos para permitir reconstrucción con JOIN.

### 51. Describa dos de los principales inconvenientes o problemas que pueden presentarse en el diseño y operación de una base de datos distribuida.
- Complejidad en el manejo de transacciones distribuidas.  
- Dificultad para mantener la consistencia e integridad de los datos entre nodos.

### 52. ¿Cuáles de los siguientes son beneficios de aplicar sharding en bases de datos distribuidas? (Seleccione todas las correctas)  
A. Escalabilidad horizontal  
B. Mayor carga sobre un único nodo  
C. Reducción de la latencia al acercar los datos al usuario  
D. Mejora en la tolerancia a fallos  
Correctas: A, C, D

### 53. Mencione al menos tres ventajas que ofrece el uso de bases de datos distribuidas en comparación con sistemas centralizados.
- Escalabilidad  
- Disponibilidad y tolerancia a fallos  
- Reducción de latencia  
- Autonomía local

### 54. Explique el concepto de transparencia en las BDD y mencione al menos dos niveles de transparencia que se deben garantizar.
Transparencia: ocultar al usuario los detalles de implementación.  
Niveles importantes:  
- De ubicación: el usuario no sabe dónde están los datos.  
- De fragmentación: el usuario no sabe cómo están divididos.

### 55. Describa el rol de un Sistema de Gestión de Bases de Datos Distribuidas (DDBMS) y enumere al menos tres funciones críticas que debe cumplir.
El DDBMS gestiona la distribución de datos, transacciones y replicación.  
Funciones:  
- Procesamiento de consultas distribuidas  
- Control de concurrencia  
- Recuperación ante fallos

### 56. Explique qué es la fragmentación mixta en el contexto de BDD y en qué casos resulta útil.
Es la combinación de fragmentación horizontal (filas) y vertical (columnas).  
Útil cuando se requiere eficiencia y seguridad en el acceso a diferentes partes de los datos.

### 57. Explique la fragmentación vertical en una BDD y por qué es importante incluir la clave primaria en cada fragmento. Proporcione un ejemplo práctico.
Divide por columnas.  
Ejemplo: `Empleado_Personal(id, nombre)` y `Empleado_Salario(id, sueldo)`.  
La clave primaria (`id`) permite unir los fragmentos correctamente.

### 58. Explique el concepto de “transparencia” en las bases de datos distribuidas. ¿Cuáles son los diferentes niveles de transparencia (por ejemplo, localización, fragmentación y replicación) y por qué son importantes para el usuario final?
Transparencia es la ocultación de la complejidad del sistema al usuario.  
Niveles:  
- Localización  
- Fragmentación  
- Replicación  
Importantes para que el usuario trabaje como si todo fuera una sola base centralizada.

### 59. Seleccione las afirmaciones correctas sobre las bases de datos distribuidas:  
A. Permiten la localización de datos en diferentes nodos geográficos, mejorando la disponibilidad y el rendimiento.  
B. La replicación de datos en un sistema distribuido incrementa el riesgo de inconsistencias, por lo que generalmente se evita su uso.  
C. La fragmentación horizontal divide una tabla en fragmentos basados en criterios de filas.  
D. El sharding consiste en dividir la base de datos en fragmentos que se almacenan en distintos servidores para mejorar la escalabilidad.  
Correctas: A, C, D

### 60. Explique qué es una transacción distribuida y describa brevemente el protocolo de Two-Phase Commit (2PC) para asegurar la atomicidad de la transacción.
Una transacción distribuida involucra múltiples nodos.  
El 2PC tiene dos fases:  
1. Preparación (todos los nodos votan por commit o abort)  
2. Confirmación (se ejecuta o se aborta en todos)

### 61. Mencione al menos tres ventajas y dos desafíos o desventajas que presentan las BDD en comparación con las bases de datos centralizadas.
Ventajas:  
- Alta disponibilidad  
- Reducción de latencia  
- Escalabilidad  
Desafíos:  
- Complejidad de administración  
- Dificultad para asegurar la consistencia

### 62. ¿Qué es la fragmentación mixta en el contexto de BDD y en qué situaciones resulta útil? Explique cómo se combina la fragmentación horizontal y vertical.
Es una combinación de fragmentación por filas y por columnas.  
Útil cuando se necesitan optimizar accesos locales y proteger ciertos datos. Se aplica horizontalmente y luego se fragmenta cada subconjunto verticalmente.

### 63. Describa dos desafíos o inconvenientes que deben enfrentar las bases de datos distribuidas en comparación con las centralizadas.
- Coordinación de transacciones entre nodos  
- Seguridad de los datos en múltiples ubicaciones

### 64. Compare brevemente las bases de datos centralizadas con las bases de datos distribuidas, señalando ventajas y desventajas de cada enfoque.
Centralizadas:  
- ✅ Más simples  
- ❌ Menor tolerancia a fallos  
Distribuidas:  
- ✅ Más robustas y escalables  
- ❌ Más complejas de mantener y sincronizar

### 65. Describa en qué consiste el procesamiento distribuido de consultas en un sistema de bases de datos distribuido y señale los principales desafíos que se deben afrontar en este proceso.
El procesamiento distribuido implica dividir una consulta global en subconsultas locales, ejecutarlas en diferentes nodos y unir los resultados.  
Desafíos:  
- Minimizar tráfico de red  
- Optimizar tiempos de respuesta  
- Sincronizar resultados entre nodos
### 66. Compare los sistemas de bases de datos distribuidas con los centralizados en cuanto a administración, rendimiento y tolerancia a fallos.
- Administración: más simple en centralizados, más compleja en distribuidos.  
- Rendimiento: mejor en distribuidos si se optimizan consultas locales.  
- Tolerancia a fallos: limitada en centralizados, alta en distribuidos.

### 67. Enumere y explique al menos tres desafíos técnicos que se deben enfrentar al implementar una BDD distribuida y proponga posibles soluciones o estrategias para mitigarlos.
1. **Consistencia** → solución: protocolos de consenso (Paxos, Raft)  
2. **Recuperación ante fallos** → solución: replicación controlada  
3. **Latencia de red** → solución: fragmentación eficiente y uso de cachés

### 68. Describa los principales desafíos que se presentan en el diseño de una base de datos distribuida y proponga al menos dos estrategias para mitigar estos problemas.
Desafíos:
- Fragmentación incorrecta  
- Coordinación de nodos  
- Recuperación compleja  
Estrategias:
- Diseño con modelo entidad-relación distribuido  
- Protocolos de transacción robustos como 2PC o 3PC

### 69. Explique la importancia de seguir una metodología sistemática (por ejemplo, el modelo entidad-relación y la normalización) en el diseño de bases de datos distribuidas.
Ayuda a:
- Minimizar redundancias  
- Mantener integridad  
- Facilitar el mantenimiento  
- Asegurar consistencia lógica entre nodos

### 70. Explique cómo se procesan las consultas en una BDD distribuida y cuál es el principal reto en la optimización de dichas consultas.
Se descomponen en subconsultas en distintos nodos.  
El reto principal es minimizar el costo de comunicación y determinar el orden óptimo de ejecución para unir los resultados rápidamente.

### 71. Defina qué es una Base de Datos Distribuida (BDD) y explique cómo se diferencia de una base de datos centralizada.
Una BDD es un conjunto de datos lógicamente relacionados distribuidos entre nodos.  
Diferencias: en BDD los datos están repartidos y se gestionan coordinadamente; en centralizadas todo reside en un solo lugar.

### 72. ¿Qué mecanismos se utilizan para la recuperación en bases de datos distribuidas ante fallos de nodos o de comunicación?
- Protocolos de recuperación (logs, checkpoints)  
- Coordinación entre nodos mediante Recovery Manager  
- Replicación para mantener copias actualizadas

### 73. Explique el concepto de transparencia en las bases de datos distribuidas y describa al menos dos niveles de transparencia (por ejemplo, localización y fragmentación).
Transparencia: ocultar detalles técnicos al usuario.  
- Localización: no se conoce dónde está el dato  
- Fragmentación: no se percibe cómo están divididas las tablas

### 74. Defina la fragmentación vertical en una BDD y explique la importancia de incluir la clave primaria en cada fragmento.
Divide una tabla en columnas, manteniendo la clave primaria.  
Permite reconstruir la tabla original con operaciones de `JOIN` sin perder la integridad de los datos.

### 75. Explique cómo Docker y la contenerización pueden facilitar el despliegue y la administración de sistemas de bases de datos distribuidas. Mencione al menos dos ventajas de utilizar contenedores en este contexto.
Docker permite:
- Crear nodos aislados fácilmente  
- Escalabilidad y portabilidad entre entornos  
Ventajas: homogeneidad de entornos, despliegue rápido, pruebas reproducibles

### 76. Explique el concepto de replicación en las bases de datos distribuidas y mencione dos ventajas y un inconveniente asociado.
Replicación: copia de datos entre nodos.  
Ventajas: disponibilidad y rendimiento.  
Inconveniente: sobrecarga para mantener la consistencia.

### 77. ¿Qué parámetros se deben considerar en la red de comunicación de una BDD y por qué son importantes?
- Latencia: afecta tiempos de respuesta  
- Ancho de banda: limita transferencia de datos  
- Fiabilidad: garantiza la entrega de transacciones

### 78. Defina el concepto de sharding en el contexto de almacenamiento distribuido. ¿Cuáles son sus principales beneficios y desafíos?
Sharding: partición horizontal de datos en distintos nodos.  
Beneficios: escalabilidad, rendimiento, distribución de carga.  

### 79. Describa los conceptos de Global Schema, Fragmentation Schema, Allocation Schema y Local Mapping Schema en el contexto de una BDD distribuida.
- **Global Schema**: definición lógica total  
- **Fragmentation Schema**: cómo se divide cada tabla  
- **Allocation Schema**: dónde se almacena cada fragmento  
- **Local Mapping Schema**: mapeo entre fragmentos y bases locales

### 80. Explique cómo se coordinan y sincronizan los nodos en una BDD para garantizar la integridad de los datos.
Mediante:
- Transacciones distribuidas  
- Protocolos de bloqueo (2PL)  
- Coordinadores de transacciones (TM)  
- Recovery Managers (RM) para gestionar errores
