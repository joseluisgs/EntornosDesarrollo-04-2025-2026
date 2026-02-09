# 🤖 Práctica 04: Ingeniería de Prompts y Auditoría de IA

> **Objetivo:** La Inteligencia Artificial es una herramienta potente, pero **no es infalible**. Un buen ingeniero de software no "copia y pega" lo que dice la IA; lo **audita, corrige y mejora**. En esta práctica, actuarás como **Lead Architect** revisando el trabajo de un "Asistente Junior" (la IA).

---

## 🛠️ Guía Rápida de Prompting para UML

Para obtener buenos resultados, usa esta estructura de prompt:

1.  **Rol:** "Actúa como un Arquitecto de Software experto en C# y UML."
2.  **Tarea:** "Genera un Diagrama de Clases en sintaxis Mermaid y el código C# correspondiente."
3.  **Restricciones:** "Usa C# 12, Respeta principios SOLID, Usa 'classDiagram' para Mermaid."
4.  **Contexto:** (El enunciado del ejercicio).

---

**📝 Ejercicio 1:** El Caso de la "Biblioteca Zombie" (Ingeniería Directa)

**Contexto:** Vamos a ver si la IA entiende la diferencia crítica entre **Composición** (muerte en cascada) y **Agregación** (supervivencia).

### 1. Tu Tarea
Copia y pega el siguiente prompt en tu chat con la IA (ChatGPT, Gemini, Claude):

> "Actúa como experto UML. Diseña un sistema para una Biblioteca.
> El sistema tiene **Libros** y **Socios**.
> Los Socios realizan **Préstamos**.
> Un Préstamo vincula un Libro y un Socio.
> **Regla Crítica 1:** Si damos de baja a un Socio, sus Préstamos activos deben guardarse en un histórico por temas legales, no pueden desaparecer.
> **Regla Crítica 2:** Un Libro se compone de **Páginas**. Si el libro se destruye, las páginas también.
> Genera el diagrama Mermaid y el código C#."

### 2. La Auditoría (Lo que debes responder)
Analiza la solución de la IA y responde a estas preguntas en tu informe:

1.  **Prueba del Algodón (Composición):** Mira el código de `Libro`. ¿Ha creado una lista `List<Pagina>`? ¿Las páginas se crean *dentro* del constructor del Libro (Correcto) o se pasan desde fuera (Incorrecto)?
2.  **Prueba del Algodón (Ciclo de Vida):** Mira la clase `Socio` y `Prestamo`. Si borras el objeto `Socio`, ¿qué pasa con el `Prestamo`?
    *   *Error común de la IA:* Poner una Composición (`*--`) entre Socio y Préstamo. Esto significaría que al borrar al socio, se borran sus préstamos (violando la Regla Crítica 1).
    *   *Correcto:* Debería ser una Agregación o una Asociación simple.
3.  **Corrección:** Si la IA falló, escribe tú el código Mermaid corregido.

---

**📝 Ejercicio 2:** La Pasarela de Pagos "Open/Closed" (Ingeniería Directa)

**Contexto:** Vamos a probar si la IA aplica patrones de diseño (Strategy) o si hace "código espagueti" con `if/else`.

### 1. Tu Tarea
Usa este prompt:

> "Diseña un módulo de ventas para un E-Commerce.
> La clase **Pedido** debe tener un método `ProcesarCobro`.
> Actualmente soportamos **PayPal** y **Tarjeta**, pero la empresa planea añadir **Bitcoin** y **ApplePay** la semana que viene.
> Diseña el sistema cumpliendo estrictamente el **Principio Open/Closed (La O de SOLID)**: Debo poder añadir nuevos métodos de pago **sin tocar ni una línea de código** de la clase Pedido.
> Dame el Mermaid y el C#."

### 2. La Auditoría
Revisa el código C# generado:

1.  **Detector de "Ifs":** ¿La clase `Pedido` tiene un `switch` o `if (tipo == "PayPal")`?
    *   *Veredicto:* Si tiene `switch`, la IA ha suspendido. Violated OCP.
2.  **Uso de Interfaces:** ¿Ha creado una interfaz `IPago` o `IPaymentStrategy`? ¿La clase `Pedido` recibe esta interfaz en su constructor o método?
    *   *Correcto:* `public void ProcesarCobro(IPago metodo) { metodo.Pagar(this.Total); }`
3.  **Refactorización:** Si la IA no usó el patrón Strategy, pídele explícitamente: *"Refactoriza usando el Patrón Strategy"*. Compara ambas soluciones.

---

**📝 Ejercicio 3:** El Detector de Mentiras (Ingeniería Inversa)

**Contexto:** A veces el código hace una cosa y la documentación (o la IA) dice otra. Vamos a darle a la IA un código con un **Patrón Singleton** y ver si lo detecta o alucina relaciones que no existen.

### 1. El Código Fuente (Copia esto)
```csharp
public class DatabaseConnection {
    // La instancia estática es la clave del Singleton
    private static DatabaseConnection _instance;
    private DatabaseConnection() { } // Constructor privado

    public static DatabaseConnection GetInstance() {
        if (_instance == null) _instance = new DatabaseConnection();
        return _instance;
    }

    public void Query(string sql) { Console.WriteLine("Ejecutando: " + sql); }
}

public class UsuarioRepositorio {
    public void GuardarUsuario(string nombre) {
        // Uso directo de la instancia estática
        var db = DatabaseConnection.GetInstance();
        db.Query($"INSERT INTO Users VALUES ('{nombre}')");
    }
}
```

### 2. Tu Tarea
Pide a la IA:
> "Actúa como experto en Ingeniería Inversa. Analiza este código C# y genera su diagrama de clases en Mermaid. Explica qué patrón de diseño se está utilizando."

### 3. La Auditoría
Analiza su respuesta:

1.  **Detección del Patrón:** ¿Ha identificado que es un **Singleton**?
2.  **Representación Visual:** Mira el diagrama Mermaid.
    *   ¿Ha marcado el atributo `_instance` y el método `GetInstance` como estáticos (subrayados o con `$`)?
    *   ¿Ha puesto el constructor como privado (`-`)?
    *   **La gran pregunta:** ¿Cómo dibujó la relación entre `UsuarioRepositorio` y `DatabaseConnection`?
        *   *Correcto:* Una flecha de dependencia (`..>`) o uso.
        *   *Incorrecto:* Una flecha de asociación (`-->`) o composición (`*--`). (No hay un campo `DatabaseConnection` dentro de `UsuarioRepositorio`, es una variable local temporal).

---

## 📢 Entrega
Crea un documento `Informe_Auditoria_IA.md` donde incluyas:
1.  El prompt exacto que usaste.
2.  El diagrama/código que te dio la IA.
3.  Tu análisis crítico (qué hizo bien y qué hizo mal).
4.  La versión corregida por ti (si fue necesaria).
