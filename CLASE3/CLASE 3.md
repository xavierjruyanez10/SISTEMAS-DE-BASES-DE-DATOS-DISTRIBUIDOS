# Introducción a las Bases de Datos Distribuidas

- **Definición:** sistema que almacena datos en diferentes ubicaciones físicas, conectadas mediante redes.
- **Objetivos:** confiabilidad, eficiencia, escalabilidad, accesibilidad y tolerancia a fallos.

---

## 2. Clasificación de Bases de Datos Distribuidas

### Según la distribución de los datos:

- **Fragmentadas**
  - *Fragmentación horizontal:* divide registros por filas según condiciones específicas.
  - *Fragmentación vertical:* divide registros por columnas según el uso de los atributos.
  - *Fragmentación mixta:* combinación de fragmentación horizontal y vertical.

- **Replicadas**
  - *Replicación completa:* cada nodo posee una copia completa de los datos.
  - *Replicación parcial:* ciertos datos se replican según necesidades específicas.

- **Híbridas**
  - Combina fragmentación y replicación, según requerimientos operativos y estratégicos.

---

## 3. Según la Homogeneidad del Sistema

- **Homogéneas**
  - Todos los nodos ejecutan el mismo tipo de software de gestión de base de datos.
  - Ejemplos: MySQL distribuido, MongoDB Sharded Cluster.

- **Heterogéneas**
  - Nodos con diferentes sistemas de gestión de base de datos que interactúan mediante estándares comunes.
  - Ejemplos: Oracle Gateway, SQL Server Integration Services (SSIS)

---

## 4. Según la Autonomía del Nodo

- **Bases de datos federadas**
  - Alta autonomía local, cada nodo mantiene control propio de sus datos.
  - Gestión descentralizada.

- **Bases de datos multidatabase**
  - Colección de bases de datos independientes que cooperan mediante acuerdos explícitos.
  - Autonomía y heterogeneidad son características esenciales.

---

## 5. Ventajas de Bases de Datos Distribuidas

- Mayor disponibilidad y confiabilidad.
- Escalabilidad eficiente.
- Distribución de carga.
- Flexibilidad y adaptación geográfica.

---

## 6. Desafíos de las Bases de Datos Distribuidas

- Complejidad administrativa.
- Seguridad y coherencia de datos.
- Gestión eficiente de transacciones distribuidas.
- Problemas asociados al rendimiento por la latencia en redes.

---

## 7. Aplicaciones típicas

- Comercio electrónico global.
- Sistemas financieros multinacionales.
- Aplicaciones de big data.
- Servicios en la nube.

---

## 8. Conclusión

- Las bases de datos distribuidas ofrecen ventajas importantes en escenarios modernos, aunque implican complejidades y desafíos técnicos relevantes.
- Seleccionar el tipo adecuado depende de las necesidades específicas y estratégicas de cada organización.

---

## Configuración Horizontal y Vertical en Bases de Datos Distribuidas

### Fragmentación Horizontal

**Cuándo utilizarla:**
- Cuando los datos pueden dividirse lógicamente en subconjuntos basados en filas.
- Cuando diferentes sitios requieren acceso a diferentes subconjuntos de datos.
- Para mejorar el rendimiento de consultas específicas.
- Para distribuir la carga de trabajo entre múltiples servidores.

**Casos de uso:**
- Bases de datos de clientes por región geográfica.
- Bases de datos de ventas divididas por año o mes.

**Cómo configurarla:**
- Definir un predicado de fragmentación.
- Almacenar cada fragmento en un sitio diferente.
- Implementar mecanismos de transparencia para ocultar la ubicación física.

---

### 🧩 Ejemplo: ¿Qué es la Fragmentación Horizontal?

**Definición:**  
Es una técnica de distribución de datos en la que una tabla se divide en subconjuntos de filas (tuplas), normalmente basándose en un criterio lógico, como el valor de una columna. Esto permite almacenar estos fragmentos en diferentes nodos o servidores, mejorando la eficiencia y localización de los datos.

---

**🧩 Caso: Fragmentación de una tabla "Estudiantes" por ciudad**

```sql
-- Tabla original
CREATE TABLE Estudiantes (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    carrera VARCHAR(50),
    ciudad VARCHAR(50)
);
```

**Criterio de fragmentación:** ciudad del estudiante.

---

🔹 **Fragmento 1: Estudiantes en Quito**

```sql
CREATE TABLE Estudiantes_Quito (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    carrera VARCHAR(50),
    ciudad VARCHAR(50)
);

INSERT INTO Estudiantes_Quito VALUES
(1, 'Ana Pérez', 'Ingeniería', 'Quito'),
(3, 'Carla Ruiz', 'Ingeniería', 'Quito');
```

---

🔹 **Fragmento 2: Estudiantes en Ambato**

```sql
CREATE TABLE Estudiantes_Ambato (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    carrera VARCHAR(50),
    ciudad VARCHAR(50)
);

INSERT INTO Estudiantes_Ambato VALUES
(2, 'Luis Mora', 'Medicina', 'Ambato'),
(5, 'Rosa Vega', 'Medicina', 'Ambato');
```

---

🔹 **Fragmento 3: Estudiantes en Cuenca**

```sql
CREATE TABLE Estudiantes_Cuenca (
    id INT PRIMARY KEY,
    nombre VARCHAR(50),
    carrera VARCHAR(50),
    ciudad VARCHAR(50)
);

INSERT INTO Estudiantes_Cuenca VALUES
(4, 'Mario León', 'Derecho', 'Cuenca'),
(6, 'J. Ortega', 'Derecho', 'Cuenca');
```

---

### 🧩 Vista global (reconstrucción de la tabla original)

```sql
CREATE VIEW Estudiantes_Todos AS
SELECT * FROM Estudiantes_Quito
UNION ALL
SELECT * FROM Estudiantes_Ambato
UNION ALL
SELECT * FROM Estudiantes_Cuenca;
```

---

### ✅ Ventajas de esta fragmentación

- Mejora el rendimiento local de las consultas.
- Permite mantener la información más cerca del usuario o de los sistemas que la necesitan.
- Facilita la escalabilidad horizontal.

---

### Fragmentación Vertical

**Cuándo utilizarla:**
- Cuando diferentes usuarios requieren distintos subconjuntos de columnas.
- Para mejorar el rendimiento de ciertas consultas.
- Para aumentar la seguridad limitando el acceso a columnas sensibles.

**Casos de uso:**
- Información personal separada de la operativa en clientes.
- Datos de productos separados en información básica y técnica.

**Cómo configurarla:**
- Definir un esquema de fragmentación de columnas.
- Almacenar cada fragmento en un sitio diferente.
- Mantener una clave primaria común en todos los fragmentos.

---

# Tipos de Fragmentación y Almacenamiento en BDD

## 1. Tipos de Fragmentación

### Fragmentación Horizontal

**Definición:**  
Consiste en dividir una tabla en subconjuntos de filas. Cada fragmento contiene registros que cumplen con ciertos criterios (por ejemplo, ubicación geográfica, rango de fechas o segmentos de clientes).

**Ventajas:**  
- Reduce la cantidad de datos que cada nodo debe procesar.  
- Mejora el rendimiento de las consultas al acceder solo a los datos relevantes para cada sitio.  
- Facilita la paralelización de procesos y el mantenimiento de la base de datos.

### Fragmentación Vertical

**Definición:**  
Divide una tabla en fragmentos basados en columnas. Cada fragmento agrupa atributos relacionados, siempre conservando la clave primaria o un identificador único que permita reconstruir la tabla original.

**Ventajas:**  
- Permite optimizar el acceso a datos cuando las aplicaciones requieren solo ciertos campos.  
- Mejora la seguridad al separar información sensible en fragmentos diferentes.  
- Facilita la gestión del ancho de banda, ya que se transfieren solo los datos necesarios.

### Fragmentación Mixta (o Híbrida)

**Definición:**  
Combina la fragmentación horizontal y vertical. Inicialmente, se puede realizar una división horizontal y, posteriormente, cada fragmento se subdivide verticalmente, o viceversa.

**Ventajas:**  
- Ofrece una mayor flexibilidad para adaptar la distribución de los datos a las necesidades específicas de las aplicaciones y usuarios.  
- Permite aprovechar las ventajas de ambos métodos, optimizando tanto el rendimiento como la seguridad.

---

## 2. Almacenamiento en Bases de Datos Distribuidas

### Asignación de Fragmentos a Nodos

- Cada fragmento se asigna a uno o varios nodos según criterios como la proximidad geográfica, la carga de trabajo y la capacidad de procesamiento.  
- La ubicación de los fragmentos puede optimizar el tiempo de respuesta, ya que los datos se sitúan cerca de los usuarios que los consultan con mayor frecuencia.

### Replicación

- Además de la fragmentación, se suele implementar la replicación. Esto significa que se mantienen copias de ciertos fragmentos en varios nodos.  
- La replicación aumenta la tolerancia a fallos, ya que, si un nodo falla, otro puede tomar el relevo sin interrumpir el servicio.

### Control de Consistencia y Sincronización

- Es fundamental implementar mecanismos de sincronización para mantener la coherencia de los datos entre nodos, especialmente cuando se realizan actualizaciones en fragmentos replicados.  
- Se pueden utilizar protocolos de control de concurrencia y algoritmos de consenso para garantizar que las transacciones sean atómicas y consistentes en todo el sistema.

---

## 3. Consideraciones en el Diseño

- **Patrones de Acceso:** La elección del método de fragmentación depende en gran medida de los patrones de acceso y consulta. Si la mayoría de las consultas son locales a un conjunto de datos, la fragmentación horizontal es muy adecuada.  
- **Carga y Escalabilidad:** Una buena distribución de los fragmentos ayuda a equilibrar la carga entre nodos, permitiendo que el sistema escale eficientemente conforme aumenta el volumen de datos y usuarios.  
- **Seguridad y Privacidad:** Al fragmentar y almacenar datos en diferentes ubicaciones, es posible implementar políticas de seguridad diferenciadas, protegiendo mejor la información sensible.

---

**Resumen:**  
La fragmentación de bases de datos a través de métodos horizontal, vertical y mixto permite distribuir los datos de manera eficiente y optimizar tanto la consulta como el almacenamiento en entornos distribuidos. Estas técnicas, combinadas con estrategias de replicación y mecanismos de sincronización, constituyen la base para construir sistemas robustos, escalables y seguros en el contexto de bases de datos distribuidas.
