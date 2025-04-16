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

## Consideraciones Adicionales

- **Fragmentación Mixta:** combinación de horizontal y vertical para necesidades complejas.
- **Transparencia:** el SGBDD debe ocultar la fragmentación a las aplicaciones.
- **Replicación:** puede combinarse con fragmentación para mejorar disponibilidad y rendimiento.
- **Complejidad:** se debe evaluar cuidadosamente el diseño antes de implementar.
