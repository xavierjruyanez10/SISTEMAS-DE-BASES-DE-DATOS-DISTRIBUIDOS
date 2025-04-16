# 📌 ¿Qué es una Base de Datos?

Una **base de datos (BD)** es un conjunto **organizado** de datos que se almacenan y gestionan electrónicamente para facilitar su acceso, consulta y manipulación.

Las bases de datos permiten **guardar información estructurada** y hacerla accesible de manera eficiente a través de sistemas de gestión de bases de datos (**DBMS - Database Management System**).

---

## 📌 Características de una Base de Datos

✅ **Organización de Datos** → La información se estructura en tablas, registros y campos.  
✅ **Persistencia** → Los datos se almacenan de forma permanente.  
✅ **Accesibilidad** → Los usuarios pueden buscar y recuperar información fácilmente.  
✅ **Seguridad** → Protege la información mediante permisos de acceso y encriptación.  
✅ **Consistencia e Integridad** → Garantiza que los datos sean correctos y confiables.  

---

## 📌 Tipos de Bases de Datos

🔹 **Bases de Datos Relacionales (SQL)** → Organizadas en tablas con relaciones entre ellas.  
Ejemplo: *MySQL, PostgreSQL, Oracle, SQL Server*

🔹 **Bases de Datos No Relacionales (NoSQL)** → Usan documentos, grafos o clave-valor.  
Ejemplo: *MongoDB, Cassandra, Redis*

🔹 **Bases de Datos Distribuidas** → Los datos están en varios servidores.  
Ejemplo: *Google Spanner, Apache Cassandra*

🔹 **Bases de Datos en Memoria** → Almacenan datos en RAM para mayor velocidad.  
Ejemplo: *Redis, Memcached*

---

# 📌 Base de Datos Distribuida (BDD)

Una **Base de Datos Distribuida (BDD)** es un sistema en el que los datos **no están almacenados en un solo servidor**, sino que están **distribuidos en múltiples nodos o servidores** conectados en red.

Estos sistemas permiten **acceder, consultar y manipular los datos** como si estuvieran en una sola base de datos, pero en realidad **los datos pueden estar en diferentes ubicaciones geográficas**.

---

## 📌 ¿Para qué se usan las Bases de Datos?

✅ **Sistemas empresariales** (Facturación, inventarios, clientes)  
✅ **Aplicaciones web y móviles** (Facebook, Amazon, Netflix)  
✅ **Big Data e Inteligencia Artificial** (Google, ChatGPT)  
✅ **Bancos y Finanzas** (Transacciones bancarias, tarjetas de crédito)  

---

## 📌 Características de Bases de Datos Distribuidas

✅ **Distribución de Datos** → Los datos se reparten entre varios servidores.  
✅ **Transparencia** → Los usuarios interactúan con la BD como si estuviera centralizada.  
✅ **Redundancia Controlada** → Se pueden replicar datos para mejorar disponibilidad.  
✅ **Escalabilidad** → Se pueden agregar más servidores sin afectar el rendimiento.  
✅ **Alta Disponibilidad** → Si un nodo falla, otro puede asumir su rol.  
✅ **Fragmentación** → Los datos pueden dividirse en fragmentos (sharding).  
✅ **Replicación** → Copias de datos en múltiples nodos para mejorar rendimiento y seguridad.  

---

## 📌 Diferencia entre Base de Datos Centralizada y Distribuida

### 📍 1. Base de Datos Centralizada

**Definición:**  
Es un sistema en el que **todos los datos se almacenan en un solo servidor o ubicación**.

**Ejemplo:**  
Un banco pequeño que tiene todos los datos de clientes y transacciones en un **único servidor SQL Server**.

**Características:**  
✅ Datos almacenados en **un solo lugar**  
✅ Fácil **administración y seguridad**  
✅ Puede manejar **transacciones consistentes** fácilmente  

**Ventajas:**  
✅ **Fácil de gestionar**  
✅ **Más seguro**  
✅ **Menos costos de infraestructura**

**Desventajas:**  
❌ **Un solo punto de falla**  
❌ **Mayor latencia**  
❌ **Difícil de escalar**

---

### 📍 2. Base de Datos Distribuida

**Definición:**  
Los datos están distribuidos en múltiples servidores pero se presentan como una única base de datos.

**Ejemplo:**  
Amazon usa **bases de datos distribuidas** en todo el mundo para atender millones de transacciones.

**Características:**  
✅ **Datos repartidos en varios servidores**  
✅ **Alta disponibilidad**  
✅ **Escalabilidad**

**Ventajas:**  
✅ **Mejor rendimiento**  
✅ **Menor riesgo de pérdida de datos**  
✅ **Tolerancia a fallos**

**Desventajas:**  
❌ **Mayor complejidad**  
❌ **Riesgo de inconsistencias**  
❌ **Costos altos**

---

# 📌 Conceptos Claves en Arquitectura de Sistemas y Bases de Datos

## 📍 1. Escalabilidad

**Definición:**  
Capacidad de un sistema para **manejar más carga de trabajo** sin perder rendimiento.

**Tipos:**  
🔹 **Escalabilidad Vertical (Scaling Up):** Mejorar un solo servidor.  
🔹 **Escalabilidad Horizontal (Scaling Out):** Agregar más servidores.

**Ejemplo:**  
- Vertical: Migrar MySQL a un servidor con más RAM.  
- Horizontal: Sharding en MongoDB.

**Ventajas:**  
✅ Mejora el rendimiento.  
✅ Permite más usuarios.

**Desventajas:**  
❌ Límite físico al escalar verticalmente.  
❌ Mayor complejidad al escalar horizontalmente.

---

## 📍 2. Alta Disponibilidad (High Availability, HA)

**Definición:**  
Sistema que sigue funcionando incluso si falla una parte.

**Cómo se logra:**  
🔹 Replicación de servidores  
🔹 Balanceo de carga  
🔹 Cluster de bases de datos

**Ejemplo:**  
Google usa bases de datos replicadas en varias regiones.

**Ventajas:**  
✅ Evita tiempos de inactividad  
✅ Recuperación rápida

**Desventajas:**  
❌ Mayor costo  
❌ Más complejidad

---

## 📍 3. Tolerancia a Fallos (Fault Tolerance)

**Definición:**  
Capacidad de un sistema para **seguir operando aunque haya fallos**.

**Diferencia con Alta Disponibilidad:**  
- **Alta Disponibilidad** → Minimiza el tiempo de inactividad.  
- **Tolerancia a Fallos** → El sistema **no se cae**.

**Cómo se logra:**  
🔹 Redundancia  
🔹 Failover automático  
🔹 RAID

**Ejemplo:**  
Sistemas bancarios replicados en diferentes regiones.

**Ventajas:**  
✅ Funciona sin interrupciones  
✅ Protege los datos

**Desventajas:**  
❌ Costos altos  
❌ Más consumo de recursos

---

## 📍 4. Reducción de Latencia

**Definición:**  
Latencia es el **tiempo que tarda una solicitud en ser respondida**. Reducirla = mayor velocidad.

**Cómo se logra:**  
🔹 CDN (servidores cerca del usuario)  
🔹 Caching (Redis, Memcached)  
🔹 Bases de Datos Distribuidas

**Ejemplo:**  
Netflix usa CDNs para entregar videos rápidamente.

**Ventajas:**  
✅ Mejor experiencia del usuario  
✅ Menor carga en servidores

**Desventajas:**  
❌ Requiere más infraestructura  
❌ Costo elevado

---

# 📍 Arquitecturas Comunes en Bases de Datos y Sistemas Distribuidos

## 1️⃣ Amo-Esclavo (Master-Slave)

**Definición:**  
- Un **nodo Master** realiza escrituras.  
- Los **nodos Slaves** replican y solo leen datos.

## 2️⃣ Peer-to-Peer (P2P)

**Definición:**  
- Todos los nodos tienen el mismo rol.  
- Pueden **leer y escribir**.  
- Ideal para redes descentralizadas.

## 3️⃣ Multi-Master

**Definición:**  
- Todos los nodos son **Masters**.  
- Pueden **leer y escribir**.  
- Replicación **síncrona o asíncrona**.
![Texto alternativo](Comparacion.png)

---

