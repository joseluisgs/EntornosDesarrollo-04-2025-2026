- [7. JetBrains Rider: Integración Total y Flujo de Trabajo Real](#7-jetbrains-rider-integración-total-y-flujo-de-trabajo-real)
  - [7.1. Visualización de Mermaid en Rider](#71-visualización-de-mermaid-en-rider)
  - [7.2. Ingeniería Inversa: De Código a Diagrama](#72-ingeniería-inversa-de-código-a-diagrama)
  - [7.3. Ingeniería Directa: ¿De Diagrama a Código?](#73-ingeniería-directa-de-diagrama-a-código)
  - [7.4. El Flujo de Trabajo Definitivo (The Golden Path)](#74-el-flujo-de-trabajo-definitivo-the-golden-path)
  - [7.5. Trucos Pro en Rider para Diagramas](#75-trucos-pro-en-rider-para-diagramas)
    - [Resumen final:](#resumen-final)


# 7. JetBrains Rider: Integración Total y Flujo de Trabajo Real

Rider no solo es un editor de código; es una plataforma de ingeniería que permite visualizar la arquitectura de tu software en tiempo real. Aquí veremos cómo conectar tus diagramas Mermaid con el código y cómo usar la potencia de la ingeniería inversa.

## 7.1. Visualización de Mermaid en Rider

Rider no renderiza Mermaid de forma nativa en el editor de código C#, pero tiene un soporte excepcional mediante el ecosistema de plugins:

1. **Plugin de Mermaid:** Debes instalar el plugin "Mermaid" desde `Settings > Plugins`.
2. **Archivos .md:** Una vez instalado, cualquier bloque de código Mermaid dentro de un archivo Markdown (`.md`) mostrará una **previsualización en tiempo real** en un panel lateral.
3. **Utilidad:** Esto permite que tengas el diagrama abierto a la derecha mientras pica el código a la izquierda, asegurando que cumple con el diseño.

---

## 7.2. Ingeniería Inversa: De Código a Diagrama

Esta es la función más potente. Permite verificar si lo que han programado coincide con lo que pensaron.

* **Cómo generarlo:** Haz clic derecho sobre un proyecto, una carpeta o una clase específica en el explorador de soluciones y selecciona **Diagrams > Show Diagram**.
* **Qué obtenemos:** Rider genera automáticamente un diagrama UML profesional con:
* Relaciones de herencia (flechas blancas).
* Relaciones de uso/asociación (flechas finas).
* Miembros, métodos y sus visibilidades.


* **Interactividad:** Puedes arrastrar clases al diagrama, ocultar métodos privados para limpiar la vista o exportar el resultado como imagen para tus entregas.

---

## 7.3. Ingeniería Directa: ¿De Diagrama a Código?

Es importante aclarar la diferencia entre herramientas:

1. **En Rider:** Rider está enfocado a la **Ingeniería Inversa** y visualización. No permite "dibujar" un cuadrado y que aparezca el archivo `.cs` automáticamente (aunque puedes crear clases desde el diagrama con atajos de teclado).
2. **En Herramientas CASE (como StarUML):** Si el flujo de trabajo requiere que el diagrama genere el código (Ingeniería Directa), se recomienda **StarUML**. En StarUML diseñas el modelo completo y usas el comando `Generate Code` para crear el esqueleto de las clases en C#.

---

## 7.4. El Flujo de Trabajo Definitivo (The Golden Path)

Para que el alumnado trabaje como profesionales, este es el proceso recomendado:

1. **Análisis:** Leer el enunciado y extraer las entidades (Punto 5).
2. **Diseño (Mermaid):** Escribir el diagrama en un archivo `README.md` dentro de la solución de Rider.
3. **Codificación:** Crear las clases en C# siguiendo el diagrama Mermaid.
4. **Validación (Rider Diagrams):** Usar la función **Show Diagram** de Rider sobre el código escrito.
5. **Contraste:** Comparar el diagrama generado por Rider con el diagrama original en Mermaid.
* *¿Faltan flechas?* Quizás olvidaste una relación en el código.
* *¿Hay flechas de más?* Tal vez has acoplado clases que no deberían conocerse.



---

## 7.5. Trucos Pro en Rider para Diagramas

* **Filtros de Visibilidad:** En el panel de diagramas de Rider, puedes activar/desactivar la visualización de campos, propiedades o métodos. Esto es vital en clases complejas para no saturar la vista.
* **Dependencia de Estructura:** Rider permite ver un "Dependency Matrix", que es un diagrama avanzado para ver qué carpetas o namespaces dependen de otros, ideal para detectar **dependencias circulares** (el gran enemigo del punto 5.3).
* **Exportación:** Puedes exportar el diagrama a formato `.uml` (propio de IntelliJ/Rider) o como imagen `PNG/SVG` para incluirlo en la documentación oficial del proyecto.

---

### Resumen final:

> "Usa **Mermaid** para planificar y documentar. Usa **Rider** para programar y verificar que tu código es tan limpio y ordenado como tu diagrama."


---