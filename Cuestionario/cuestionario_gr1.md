# Evaluación: Sistemas de Bases de Datos Distribuidos  
**Cuestionario – Preguntas con Reactivos**

## Tema 1: Fundamentos Base de Datos Distribuidas

**1. ¿Cuál es una característica clave de una base de datos distribuida?**  
- A. Todos los datos están en un solo servidor  
- B. La base de datos es inaccesible sin conexión a internet  
- C. Los datos están repartidos entre varios nodos ✅  
- D. Solo soporta SQL  

**2. ¿Qué componente es esencial en una arquitectura de base de datos distribuida?**  
- A. Caché compartida  
- B. Procesador gráfico  
- C. Gestor de transacciones distribuidas ✅  
- D. Firewall  

---

## Tema 2: Fragmentación en Bases de Datos

**3. ¿Qué tipo de fragmentación divide una tabla horizontalmente según valores de un atributo?**  
- A. Fragmentación vertical  
- B. Fragmentación horizontal ✅  
- C. Fragmentación mixta  
- D. Fragmentación replicada  

**4. ¿Cuál es la principal ventaja de la fragmentación horizontal?**  
- A. Mejora la seguridad de los datos  
- B. Aumenta la velocidad de lectura local ✅  
- C. Duplica los datos para tolerancia a fallos  
- D. Reduce el uso de disco  

**5. ¿Qué ocurre en una fragmentación vertical?**  
- A. Los registros se reparten por rangos  
- B. Se eliminan atributos innecesarios  
- C. Se dividen las columnas de una tabla ✅  
- D. Se duplican las tablas enteras  

---

## Tema 3: Replicación de Base de Datos

**6. ¿Cuál es el objetivo de la replicación de bases de datos?**  
- A. Aumentar la complejidad del sistema  
- B. Crear múltiples copias para alta disponibilidad ✅  
- C. Fragmentar los datos  
- D. Limitar el acceso a los datos  

**7. ¿Qué tipo de replicación permite cambios en todos los nodos y sincroniza periódicamente?**  
- A. Replicación maestro-esclavo  
- B. Replicación circular  
- C. Replicación sincrónica  
- D. Replicación multimaestro ✅  

---

## Tema 4: Escenarios de Replicación de BD

**8. ¿Cuál es un caso común para aplicar replicación sincrónica?**  
- A. Aplicaciones web con mucho tráfico  
- B. Sistemas de respaldo offline  
- C. Sistemas financieros en tiempo real ✅  
- D. Plataformas educativas  

**9. ¿Qué ventaja tiene un escenario de replicación maestro-esclavo?**  
- A. Baja redundancia  
- B. Control de escritura centralizado ✅  
- C. Alta latencia  
- D. Menor disponibilidad  

**10. ¿Qué riesgo puede presentarse en replicación asincrónica?**  
- A. Consistencia inmediata  
- B. Reducción del rendimiento  
- C. Pérdida temporal de datos actualizados ✅  
- D. Duplicación de datos  