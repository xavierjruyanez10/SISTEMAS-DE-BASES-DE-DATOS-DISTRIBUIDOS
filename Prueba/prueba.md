1. Describa brevemente el proceso de creación de instancias en SQL Server. ¿Cuáles son los pasos básicos de configuración y cuál es la importancia de esta actividad en el contexto de una BDD distribuida?
Se espera que se mencionen pasos como la instalación de SQL Server, configuración de la instancia, definición de parámetros de replicación y seguridad, y la verificación de la comunicación. La actividad es clave para que cada nodo (o instancia) pueda formar parte del sistema distribuido.
2. Identifique y explique al menos tres medidas o estrategias de seguridad que se deben implementar en una BDD distribuida.
Se deben incluir estrategias como la autenticación de usuarios en cada nodo, el cifrado de datos en tránsito, el control de acceso basado en roles y la auditoría de las operaciones de replicación y consulta.
3. Compare el modelo de Amazon DynamoDB con un sistema MySQL centralizado. ¿Qué ventajas ofrece cada uno en términos de escalabilidad, rendimiento y administración de datos?
Se espera un análisis donde se mencione que Amazon DynamoDB, al ser distribuido, ofrece una mayor escalabilidad y tolerancia a fallos, mientras que MySQL centralizado puede ser más sencillo de administrar pero presenta limitaciones en cuanto a escalabilidad y disponibilidad.
4. Describa las principales responsabilidades del administrador de bases de datos en un entorno distribuido.
La respuesta debe incluir funciones como la configuración y mantenimiento de instancias, gestión de seguridad, coordinación de transacciones distribuidas, monitoreo de rendimiento y planificación de recuperación ante fallos.
5. Describa en qué consiste el procesamiento distribuido de consultas en una BDD y mencione dos desafíos que se deben considerar en este proceso.
La respuesta debe explicar que el procesamiento distribuido de consultas involucra la ejecución de partes de una consulta en múltiples nodos y la posterior unión de los resultados, considerando retos como el costo de comunicación y la optimización de rutas de consulta.
6. Describa el rol de un Sistema de Gestión de Bases de Datos Distribuidas (DDBMS) y mencione al menos tres de sus componentes o funciones principales.
Se espera que se mencione que el DDBMS administra la distribución de datos, coordina transacciones entre nodos y oculta la complejidad de la distribución, entre otros componentes como el procesador de transacciones, el directorio de datos distribuidos y el gestor de consultas.
7. Defina los siguientes tipos de fragmentación en bases de datos distribuidas y mencione, al menos, una ventaja de cada uno:
a) Fragmentación horizontal
b) Fragmentación vertical
c) Fragmentación mixta
Se espera que el estudiante explique que la fragmentación horizontal divide la tabla por filas, la vertical por columnas (manteniendo la clave primaria) y la mixta es una combinación de ambas, destacando ventajas como la optimización en el acceso y la distribución de la carga.
8. Describa cuáles son las principales responsabilidades de un DBA (Administrador de Bases de Datos) en un entorno distribuido, considerando aspectos de seguridad, replicación y recuperación.
Se espera que se mencionen funciones como monitoreo de la replicación, coordinación de transacciones distribuidas, implementación de políticas de seguridad, mantenimiento de la consistencia entre nodos y planificación para la recuperación ante fallos.
9. Explique el concepto de replicación en las bases de datos distribuidas y mencione al menos dos ventajas y un inconveniente de utilizar replicación.
La respuesta debe explicar que la replicación consiste en mantener copias idénticas de datos en diferentes nodos para mejorar la disponibilidad y el rendimiento, señalando ventajas como el aumento del paralelismo y la tolerancia a fallos, y mencionando la dificultad para mantener la consistencia como inconveniente.
10. Explique qué es una transacción distribuida y describa brevemente el protocolo de Two-Phase Commit (2PC) utilizado para asegurar la atomicidad en entornos distribuidos.
Se espera que se defina una transacción distribuida como aquella que abarca operaciones en varios nodos y se describa el protocolo 2PC, que incluye una fase de consulta (voto) y una fase de confirmación para asegurar que todas las partes involucradas confirmen o aborten la transacción de forma coordinada.
11. ¿Qué es la fragmentación horizontal y cómo se implementaría en una BDD? Dé un ejemplo práctico.
La fragmentación horizontal divide una tabla en subconjuntos de filas (por ejemplo, por ciudad o rango de fechas) para mejorar el rendimiento de consultas locales. Se debe ejemplificar, por ejemplo, fragmentando una tabla de estudiantes en “Estudiantes_Quito”, “Estudiantes_Ambato” y “Estudiantes_Cuenca”.
12. Defina qué es una Base de Datos Distribuida (BDD) y explique cómo difiere de una base de datos centralizada.
Se espera que se mencione que una BDD es un conjunto de datos repartidos en distintos nodos de una red, que se gestionan de forma conjunta y se presentan de manera transparente al usuario, a diferencia de una base centralizada donde todos los datos se encuentran en un solo servidor.
13. Describa brevemente los tres tipos de fragmentación (horizontal, vertical y mixta) que se pueden aplicar en una base de datos distribuida.
Se espera que se defina la fragmentación horizontal como la división de una tabla en subconjuntos de filas, la vertical como la división basada en columnas (manteniendo la clave primaria) y la mixta como una combinación de ambas.
14. Explique cómo la distribución de datos en una BDD puede afectar el rendimiento de las consultas. ¿Qué estrategias se pueden utilizar para optimizar dicho rendimiento?
Se debe explicar que la distribución puede generar costos de comunicación entre nodos y mayor latencia en consultas globales, y que para optimizar el rendimiento se pueden utilizar estrategias como la fragmentación de datos, el uso de caches locales, y la optimización de las consultas distribuidas.
15. ¿Qué es el sharding en las BDD y cuáles son sus principales beneficios y desafíos?
Se debe definir sharding como el particionamiento horizontal de datos en fragmentos (shards) que se distribuyen en distintos nodos, permitiendo escalabilidad y distribución de la carga, con el desafío de mantener la consistencia y balanceo entre shards.
16. Mencione y explique al menos tres ventajas y dos desventajas de implementar una arquitectura de bases de datos distribuidas.
Se buscan respuestas que incluyan aspectos como alta disponibilidad, tolerancia a fallos, escalabilidad, pero también se reconozcan desafíos como la complejidad administrativa, la consistencia en la replicación y la gestión de transacciones distribuidas.
17. ¿Qué estrategias se pueden implementar en una BDD distribuida para minimizar el costo y la sobrecarga de la transferencia de datos entre nodos y mejorar la eficiencia de las consultas?
La respuesta debe incluir estrategias como la fragmentación adecuada, el uso de caching, la optimización de rutas de consulta, reducción del tráfico mediante consultas locales y el diseño inteligente del esquema de datos.
18. Explique cómo se puede configurar un nodo distribuido en Docker. Describa los pasos principales y mencione las ventajas de utilizar contenedores en la implementación de BDD distribuidas.
Se debe explicar que con Docker se crea un contenedor que simula un nodo de una BDD, se establece una red entre contenedores (usando Docker Compose o comandos de red) y se configuran los servicios (por ejemplo, una instancia de SQL Server o PostgreSQL). Entre las ventajas se incluye la portabilidad, facilidad de escalado y uniformidad en el entorno.
19. Analice cómo Docker y Docker Compose pueden facilitar el despliegue y la administración de sistemas de bases de datos distribuidas. Describa, en líneas generales, los pasos necesarios para configurar un entorno distribuido utilizando contenedores Docker.
Se espera que la respuesta incluya la ventaja de usar contenedores para simular nodos, la creación de redes Docker, un ejemplo básico de archivo docker-compose.yml y la explicación de pasos como la creación de contenedores, definición de redes y puesta en marcha del sistema.
20. Defina qué es la fragmentación horizontal en el contexto de BDD y mencione sus principales ventajas. Ilustre su respuesta con un ejemplo práctico (por ejemplo, fragmentar una tabla de alumnos por ciudad).
La respuesta debe explicar que la fragmentación horizontal divide una tabla en subconjuntos de filas basándose en algún criterio (por ejemplo, ubicación geográfica), lo que permite acelerar las consultas locales y mejorar la escalabilidad del sistema.
21. ¿Qué es una instancia en SQL Server? Explique la diferencia entre una instancia Default y una instancia Named, ilustrando con ejemplos prácticos.
Se espera que se defina una instancia como un entorno de ejecución independiente del motor de SQL Server y se expliquen las diferencias en la forma de conexión (por ejemplo, “localhost” para Default y “localhost\NombreInstancia” para Named), con ejemplos prácticos.
22. Compare las bases de datos distribuidas homogéneas con las heterogéneas y mencione en qué escenarios se utilizaría cada tipo.
Se debe explicar que en las BDD homogéneas todos los nodos usan el mismo DBMS, lo que simplifica la administración, mientras que las heterogéneas permiten integrar distintos sistemas de gestión, siendo útiles en entornos con tecnologías variadas.
23. Defina la fragmentación horizontal y proponga un ejemplo práctico (por ejemplo, una tabla de estudiantes dividida por ciudad).
Se espera que el estudiante defina la fragmentación horizontal como la división de una tabla en fragmentos según criterios de filas (como ciudad o rango de fechas) y que proponga, por ejemplo, fragmentos como “Estudiantes_Quito”, “Estudiantes_Ambato” y “Estudiantes_Cuenca”.
24. Imagine que debe diseñar una base de datos distribuida para una universidad. Se requiere almacenar datos de estudiantes de diferentes ciudades mediante fragmentación horizontal basada en la ciudad.
a) Proponga un esquema de fragmentación horizontal para una tabla de estudiantes.
b) Explique cómo se podría implementar una vista global que permita consultar todos los datos de estudiantes, uniendo los fragmentos.
La respuesta debe incluir el diseño de tablas fragmentadas (por ejemplo, Estudiantes_Quito, Estudiantes_Ambato, Estudiantes_Cuenca) y la propuesta de una vista global que emplee la sentencia SQL UNION ALL para reconstruir la tabla original.
25. Compare brevemente los métodos de fragmentación horizontal, vertical e híbrida en una BDD. ¿Qué criterios se deben considerar para elegir cada método?
Se espera que la respuesta compare que la fragmentación horizontal se basa en criterios de filas, la vertical en columnas y la híbrida combina ambas para obtener ventajas en la distribución de datos. Además, se debe mencionar que la elección depende de los patrones de acceso, la seguridad y el desempeño requerido.
26. Defina qué es una base de datos distribuida y mencione sus características principales.
Se espera que el estudiante defina una BDD como una colección de bases de datos lógicamente interrelacionadas y distribuidas en diferentes ubicaciones físicas, y que resalte características como la transparencia, la replicación y la fragmentación.
27. ¿Qué es la fragmentación mixta en una base de datos distribuida? Explique sus ventajas y cómo se puede implementar combinando fragmentación horizontal y vertical.
Se espera que se defina la fragmentación mixta como la combinación de fragmentación horizontal y vertical, permitiendo aprovechar la localización de filas y la separación de atributos, lo que optimiza tanto la eficiencia de consultas como la seguridad en el acceso a determinados datos.
28. Explique los componentes de la arquitectura de una base de datos distribuida, mencionando los conceptos de esquema global, esquema de fragmentación, esquema de asignación y mapeo local.
Se debe mencionar que la arquitectura de una BDD consta de un esquema global (definición lógica completa), un esquema de fragmentación (que define cómo se dividen las relaciones), un esquema de asignación (que indica en qué nodos se almacenan los fragmentos) y un mapeo local que traduce los fragmentos a la estructura de cada base de datos local.
29. Defina qué son las bases de datos distribuidas y compare sus principales características con las bases de datos centralizadas.
Se espera que la respuesta incluya una definición de bases de datos distribuidas, señalando que los datos se encuentran repartidos en diferentes nodos y se accede a ellos de forma transparente, comparándolas con la centralización en un único servidor.
30. Realice un análisis comparativo entre Amazon DynamoDB y un sistema basado en MySQL centralizado. Identifique las principales diferencias en cuanto a escalabilidad, disponibilidad y administración.
El análisis debe mencionar que Amazon DynamoDB, al ser una BDD distribuida, ofrece escalabilidad horizontal, mayor disponibilidad y tolerancia a fallos, mientras que un MySQL centralizado generalmente se limita en términos de escalabilidad y presenta un único punto de fallo.
31. Describa los principales desafíos que pueden surgir en la recuperación y en el mantenimiento de la consistencia en sistemas de bases de datos distribuidas. Proponga al menos dos estrategias o mecanismos que pueden utilizarse para mitigar estos problemas.
La respuesta debe abordar problemas como la falla de nodos, la latencia en las comunicaciones, la gestión de transacciones distribuidas y sugerir mecanismos como protocolos de consenso, uso de Recovery Managers, replicación controlada, entre otros.
32. Explique el concepto de independencia de datos en las BDD distribuidas y por qué es fundamental para que los usuarios puedan interactuar sin preocuparse por la ubicación física de los datos.
Se debe explicar que la independencia de datos permite a los usuarios trabajar con un esquema global sin conocer los detalles físicos de almacenamiento, lo que mejora la transparencia y facilita el mantenimiento de la aplicación.
33. Describa la arquitectura cliente-servidor en el contexto de bases de datos distribuidas y explique cómo se coordinan los accesos a los datos.
Se debe explicar que los clientes se comunican con uno o más servidores que gestionan la BDD, a menudo a través de interfaces SQL o de servicios Web, y que la coordinación se realiza mediante protocolos de red y componentes centralizados (como un coordinador de transacciones).
34. Explique el concepto de autonomía local en las bases de datos distribuidas y su importancia para el funcionamiento general del sistema.
La respuesta debe explicar que la autonomía local implica que cada nodo puede procesar sus propias solicitudes y gestionar sus datos de forma independiente, lo que mejora la tolerancia a fallos y la eficiencia operativa.
35. ¿Cuáles son los principales métodos para controlar la concurrencia en un sistema de bases de datos distribuidas y cuáles son sus desafíos?
La respuesta debe mencionar técnicas de bloqueo distribuido, control de versiones y protocolos de consenso, subrayando los desafíos en la latencia y en la coordinación entre nodos.
36. Explique brevemente cuáles son los principales mecanismos para el control de concurrencia en sistemas de bases de datos distribuidas y cuáles son sus desafíos.
La respuesta debe incluir mecanismos como bloqueo distribuido, control de versiones y protocolos de consenso, además de señalar los desafíos de latencia y la coordinación entre nodos.
37. Explique cómo el ancho de banda y la latencia en la red impactan el rendimiento de una BDD distribuida.
Se debe indicar que un ancho de banda limitado o alta latencia puede aumentar el costo de comunicación entre nodos, afectando la velocidad de procesamiento de consultas y la sincronización de datos.
38. Explique las diferencias entre bases de datos distribuidas homogéneas y heterogéneas. ¿En qué escenarios se podría elegir cada una?
La respuesta debe explicar que en las BDD homogéneas todos los nodos utilizan el mismo sistema de gestión de bases de datos (DBMS), mientras que en las heterogéneas se utilizan distintos DBMS. Se debe señalar que las homogéneas son más simples de administrar pero menos flexibles, y las heterogéneas permiten integrar diferentes tecnologías.
39. Defina qué es el sharding en el contexto de bases de datos distribuidas, explique cómo funciona y mencione sus principales beneficios y desafíos.
La respuesta debe describir el sharding como particionamiento horizontal de datos en distintos nodos, sus beneficios (como escalabilidad horizontal, distribución de la carga y mejora en el rendimiento) y desafíos (como la gestión de la consistencia y la reconfiguración de shards).
40. Explique qué es la replicación maestro-esclavo y describa, paso a paso, el proceso para configurar la replicación entre un servidor maestro (en Windows) y un servidor esclavo (en Ubuntu) utilizando SQL Server.
La respuesta debe incluir la definición de replicación maestro-esclavo, la configuración inicial del servidor maestro (activación en SSMS, configuración de seguridad y respaldo) y los pasos necesarios para que el servidor esclavo se suscriba a la publicación generada.
41. ¿Qué estrategias pueden emplearse para optimizar el procesamiento de consultas en un entorno distribuido?
La respuesta debe mencionar estrategias como la fragmentación adecuada de datos, utilización de caches locales, minimización de la transferencia de datos entre nodos y la selección de rutas óptimas para la ejecución de consultas.
42. Explique el concepto de independencia de datos en una BDD distribuida y por qué es fundamental para la transparencia del sistema.
La respuesta debe indicar que la independencia de datos permite a los usuarios interactuar con un esquema global sin preocuparse por la ubicación o fragmentación física de los datos, lo que mejora la facilidad de uso y mantenimiento.
43. ¿Qué consideraciones de seguridad son importantes en el diseño de una BDD distribuida? Mencione al menos tres aspectos a tener en cuenta.
La respuesta debe incluir aspectos como la autenticación de usuarios en múltiples nodos, el cifrado de datos durante la transmisión y la implementación de políticas de acceso y replicación seguras.
44. Compare el modelo de Amazon DynamoDB con un sistema basado en MySQL centralizado, enfocándose en escalabilidad, disponibilidad y complejidad administrativa.
Se espera que se describa cómo DynamoDB, al ser un sistema distribuido, permite una mayor escalabilidad, tolerancia a fallos y disponibilidad, mientras que MySQL centralizado es más sencillo de administrar pero puede presentar limitaciones en escalabilidad y un único punto de fallo.
45. Explique las ventajas y limitaciones de utilizar una arquitectura distribuida para BDD en comparación con una centralizada, considerando aspectos como escalabilidad, disponibilidad y seguridad.
La respuesta debe abordar que la arquitectura distribuida facilita la escalabilidad, la tolerancia a fallos y la reducción de latencia, aunque introduce mayores retos en la coordinación, la seguridad y la integridad de los datos.
46. Explique la arquitectura ANSI-SPARC tradicional y cómo se extiende o modifica para soportar sistemas de bases de datos distribuidas.
La respuesta debe mencionar los tres niveles (interno, conceptual y externo) de la arquitectura ANSI-SPARC y cómo, en el contexto distribuido, se agregan esquemas de fragmentación y asignación para reflejar la distribución física de los datos.
47. Describa un ejemplo práctico de cómo fragmentar horizontalmente una tabla en PostgreSQL. Indique qué criterios utilizaría y cómo crear una vista global que reúna los fragmentos.
Se espera que se explique la división de una tabla (por ejemplo, de alumnos o clientes) en fragmentos basados en un criterio como la ciudad o el rango de fechas y que se mencione la utilización de la instrucción SQL UNION ALL para crear una vista que reconcilie los fragmentos en una consulta global.
48. Enumere y describa al menos cuatro ventajas que ofrecen los sistemas de bases de datos distribuidas.
Entre las ventajas se deben mencionar: mayor disponibilidad, reducción de la latencia, escalabilidad y tolerancia a fallos, además de la posibilidad de diseñar el sistema de acuerdo con la estructura organizacional.
49. Compare la arquitectura de una base de datos centralizada con la arquitectura de una base de datos distribuida, enfatizando las diferencias en la administración y el control.
Se espera que se destaque que en la arquitectura centralizada existe un único nodo o servidor que administra todos los datos, mientras que en la distribuida, la información se reparte en múltiples nodos, generando mayor tolerancia a fallos y escalabilidad, aunque a costa de una mayor complejidad.
50. Explique qué es la fragmentación vertical en una base de datos distribuida y proporcione un ejemplo práctico, mencionando la importancia de incluir la clave primaria en cada fragmento.
La respuesta debe explicar que la fragmentación vertical divide una tabla en subconjuntos de columnas y que para poder reconstruir la tabla original es necesario incluir la clave primaria en cada fragmento.
51. Describa dos de los principales inconvenientes o problemas que pueden presentarse en el diseño y operación de una base de datos distribuida.
Se espera mencionar aspectos como la mayor complejidad en el control de concurrencia y la gestión de transacciones, así como los desafíos en mantener la integridad y consistencia de los datos a través de la red.
52.	 ¿Cuáles de los siguientes son beneficios de aplicar sharding en bases de datos distribuidas? (Seleccione todas las correctas)       
A. Escalabilidad horizontal       
B. Mayor carga sobre un único nodo       
C. Reducción de la latencia al acercar los datos al usuario       
D. Mejora en la tolerancia a fallos     
Seleccione una o más de una:
a)	D
b)	C
c)	A
d)	B



53.  Mencione al menos tres ventajas que ofrece el uso de bases de datos distribuidas en comparación con sistemas centralizados.
Entre las ventajas se espera que el estudiante mencione mayor escalabilidad, tolerancia a fallos, disponibilidad, reducción de latencia y autonomía local.
54. Explique el concepto de transparencia en las BDD y mencione al menos dos niveles de transparencia que se deben garantizar.
La transparencia permite ocultar al usuario los detalles de la distribución de los datos. Se deben mencionar niveles como la transparencia de ubicación y la de fragmentación, entre otros.
55. Describa el rol de un Sistema de Gestión de Bases de Datos Distribuidas (DDBMS) y enumere al menos tres funciones críticas que debe cumplir.
Se debe explicar que el DDBMS coordina la distribución, replicación, procesamiento de consultas y transacciones en múltiples nodos, y funciones como el control de concurrencia, recuperación ante fallos y mantenimiento de la integridad y consistencia de los datos.
56. Explique qué es la fragmentación mixta en el contexto de BDD y en qué casos resulta útil.
La fragmentación mixta es la combinación de fragmentación horizontal y vertical para aprovechar las ventajas de ambas técnicas, adecuándose a requerimientos complejos de rendimiento y seguridad.
57. Explique la fragmentación vertical en una BDD y por qué es importante incluir la clave primaria en cada fragmento. Proporcione un ejemplo práctico.
La respuesta debe explicar que la fragmentación vertical divide una tabla por columnas y que, para poder reconstruir la información original, cada fragmento debe contener la clave primaria. Se puede ejemplificar separando una tabla de clientes en información personal y datos de facturación.
58. Explique el concepto de “transparencia” en las bases de datos distribuidas. ¿Cuáles son los diferentes niveles de transparencia (por ejemplo, localización, fragmentación y replicación) y por qué son importantes para el usuario final?
Se espera que se defina la transparencia como la capacidad del sistema para ocultar detalles de implementación y se describan los niveles relacionados con la localización, fragmentación y replicación, enfatizando su importancia para mantener la independencia de datos ante el usuario.
59. Seleccione las afirmaciones correctas sobre las bases de datos distribuidas:
A. Permiten la localización de datos en diferentes nodos geográficos, mejorando la disponibilidad y el rendimiento.
B. La replicación de datos en un sistema distribuido incrementa el riesgo de inconsistencias, por lo que generalmente se evita su uso.
C. La fragmentación horizontal divide una tabla en fragmentos basados en criterios de filas.
D. El sharding consiste en dividir la base de datos en fragmentos que se almacenan en distintos servidores para mejorar la escalabilidad.
a) D
b) A
c) B
d) C
60.	Explique qué es una transacción distribuida y describa brevemente el protocolo de Two-Phase Commit (2PC) para asegurar la atomicidad de la transacción.
Se debe definir una transacción distribuida como aquella que involucra operaciones en varios nodos y describir el protocolo 2PC, que cuenta con una fase de votación y otra de compromiso o abortado. 
61.	 Mencione al menos tres ventajas y dos desafíos o desventajas que presentan las BDD en comparación con las bases de datos centralizadas. 
 

Se deben mencionar ventajas como mayor disponibilidad, reducción de latencia, escalabilidad y tolerancia a fallos; mientras que los desafíos incluyen la complejidad de la coordinación de transacciones, la sincronización entre nodos y la gestión de la seguridad. 

62.	¿Qué es la fragmentación mixta en el contexto de BDD y en qué situaciones resulta útil? Explique cómo se combina la fragmentación horizontal y vertical.
Se debe explicar que la fragmentación mixta es la combinación de la fragmentación horizontal (por filas) y vertical (por columnas) en una tabla, lo que permite optimizar el acceso a los datos según los requerimientos de consulta y seguridad.  
63.	 Describa dos desafíos o inconvenientes que deben enfrentar las bases de datos distribuidas en comparación con las centralizadas. 
Se debe mencionar la complejidad de coordinación y sincronización de transacciones, además de problemas en la seguridad y la gestión de la comunicación entre nodos.     
64.	 Compare brevemente las bases de datos centralizadas con las bases de datos distribuidas, señalando ventajas y desventajas de cada enfoque. 
Se espera que se mencione que en las bases de datos centralizadas toda la información se almacena en un solo nodo, lo que facilita la administración, pero también crea un único punto de fallo; mientras que en las bases de datos distribuidas los datos se reparten en varios nodos, lo que mejora la disponibilidad y escalabilidad, pero incrementa la complejidad de administración y sincronización.  
65.	Describa en qué consiste el procesamiento distribuido de consultas en un sistema de bases de datos distribuido y señale los principales desafíos que se deben afrontar en este proceso. 
Se espera que se aborde el tema de cómo se realizan consultas en entornos donde los datos se encuentran en nodos distintos, considerando aspectos como el costo de comunicación, la optimización y la minimización de la transferencia de datos.    
66.	Compare los sistemas de bases de datos distribuidas con los centralizados en cuanto a administración, rendimiento y tolerancia a fallos.
La respuesta debe resaltar que mientras en sistemas centralizados la administración es más simple (un único DBA, una sola ubicación), en sistemas distribuidos se mejora la tolerancia a fallos, escalabilidad y disponibilidad, a costa de mayor complejidad.  
67.	Enumere y explique al menos tres desafíos técnicos que se deben enfrentar al implementar una BDD distribuida y proponga posibles soluciones o estrategias para mitigarlos.    
Se espera que se mencionen desafíos como la gestión de transacciones distribuidas, la consistencia y sincronización de réplicas, y la complejidad de la recuperación ante fallos. Las soluciones pueden incluir el uso de protocolos de consenso, estrategias de bloqueo distribuido y herramientas de monitoreo avanzado.    
68.	Describa los principales desafíos que se presentan en el diseño de una base de datos distribuida y proponga al menos dos estrategias para mitigar estos problemas.   
La respuesta debe abordar problemas tales como la complejidad en la fragmentación, la replicación y el manejo de transacciones, además de proponer estrategias como la utilización de protocolos de consenso, la optimización de consultas distribuidas y la implementación de mecanismos avanzados de recuperación.  
69.	Explique la importancia de seguir una metodología sistemática (por ejemplo, el modelo entidad-relación y la normalización) en el diseño de bases de datos distribuidas.
Se debe indicar que un diseño sistemático ayuda a garantizar la integridad de los datos, minimizar redundancias y facilitar el escalado y mantenimiento del sistema.   
70.	Explique cómo se procesan las consultas en una BDD distribuida y cuál es el principal reto en la optimización de dichas consultas. 
Se debe indicar que el procesamiento distribuido implica descomponer consultas globales y ejecutarlas localmente en cada nodo, para luego combinar los resultados. El reto principal es minimizar el costo de transmisión de datos y optimizar el orden de las operaciones.     
71.	Defina qué es una Base de Datos Distribuida (BDD) y explique cómo se diferencia de una base de datos centralizada.    
Se espera que el estudiante defina una BDD como un conjunto de datos distribuidos en varios nodos que, mediante un software de administración, se presentan de forma lógica como una única base. Además, debe señalar que las BDD ofrecen ventajas en escalabilidad y disponibilidad, aunque con una mayor complejidad de administración en comparación con las centralizadas.    
72.	¿Qué mecanismos se utilizan para la recuperación en bases de datos distribuidas ante fallos de nodos o de comunicación? 
La respuesta debe incluir mecanismos como el uso de un único catálogo, Data Manager, y protocolos de recuperación, además de la coordinación a través de nodos para mantener la consistencia tras fallos.
73.	 Explique el concepto de transparencia en las bases de datos distribuidas y describa al menos dos niveles de transparencia (por ejemplo, localización y fragmentación). 
Se espera que se defina la transparencia como la capacidad del sistema para ocultar detalles de implementación (como la ubicación física de los datos o su división en fragmentos) al usuario, haciendo que la interacción sea similar a la de una base de datos centralizada.
74.	 Defina la fragmentación vertical en una BDD y explique la importancia de incluir la clave primaria en cada fragmento.
La fragmentación vertical divide una tabla en subconjuntos de columnas, y cada fragmento debe incluir la clave primaria para permitir la reconstrucción de la tabla original mediante una operación JOIN.  
75.	 Explique cómo Docker y la contenerización pueden facilitar el despliegue y la administración de sistemas de bases de datos distribuidas. Mencione al menos dos ventajas de utilizar contenedores en este contexto. 
Se espera que se destaque la portabilidad, la facilidad de escalado y la homogeneidad de ambientes (desarrollo, prueba y producción) como ventajas del uso de Docker para simular entornos distribuidos.   
76.	Explique el concepto de replicación en las bases de datos distribuidas y mencione dos ventajas y un inconveniente asociado.
La respuesta debe definir replicación como la copia de datos en varios nodos para mejorar la disponibilidad y el paralelismo; mencionar ventajas como tolerancia a fallos y mejora del rendimiento, y señalar la sobrecarga para mantener la consistencia como desventaja.  
77.	¿Qué parámetros se deben considerar en la red de comunicación de una BDD y por qué son importantes?    
Se deben considerar parámetros como el retraso en la entrega, el costo de transmisión y la confiabilidad, ya que afectan el desempeño y la coordinación entre nodos. 
78.	Defina el concepto de sharding en el contexto de almacenamiento distribuido. ¿Cuáles son sus principales beneficios y desafíos?
La respuesta debe definir sharding como la división de los datos en fragmentos (shards) que se almacenan en distintos nodos, lo que permite escalar horizontalmente el sistema. Entre los beneficios se encuentra la distribución de la carga y la mejora en el rendimiento, y entre los desafíos, la complejidad en mantener la consistencia entre shards. 
79.	Describa los conceptos de Global Schema, Fragmentation Schema, Allocation Schema y Local Mapping Schema en el contexto de una BDD distribuida. 
La respuesta debe explicar que el Global Schema representa la vista lógica de todos los datos; el Fragmentation Schema establece cómo se divide una relación; el Allocation Schema indica en qué nodos se almacenan los fragmentos; y el Local Mapping Schema traduce los fragmentos al formato local de cada nodo. 
80.	Explique cómo se coordinan y sincronizan los nodos en una BDD para garantizar la integridad de los datos. 

Se debe explicar que la coordinación se logra mediante protocolos de bloqueo, transacciones distribuidas, y el uso de componentes como el Transaction Manager (TM) y el Recovery Manager (RM) que aseguran que todas las operaciones se ejecuten de forma coherente.  
 

