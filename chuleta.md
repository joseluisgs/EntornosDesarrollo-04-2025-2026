# 🥓 Chuleta Definitiva: UML, Mermaid y C#

Esta guía rápida resume los conceptos clave de los temas 02, 03, 04 y 05. Úsala para traducir rápidamente tus ideas a diagramas (Mermaid) y tu diseño a código (C#).

- [🥓 Chuleta Definitiva: UML, Mermaid y C#](#-chuleta-definitiva-uml-mermaid-y-c)
  - [1. De Concepto a Diagrama (Sintaxis Mermaid)](#1-de-concepto-a-diagrama-sintaxis-mermaid)
    - [🧱 Anatomía de la Clase y Miembros](#-anatomía-de-la-clase-y-miembros)
    - [🔗 Relaciones y Flechas](#-relaciones-y-flechas)
    - [🔢 Multiplicidad (Cardinalidad)](#-multiplicidad-cardinalidad)
    - [🧭 Navegabilidad (Flechas)](#-navegabilidad-flechas)
  - [2. De Diagrama a Código (Implementación en C#)](#2-de-diagrama-a-código-implementación-en-c)
    - [🏗️ Definiciones Básicas](#️-definiciones-básicas)
    - [⚙️ Atributos y Métodos](#️-atributos-y-métodos)
    - [🔢 Cardinalidad (Código)](#-cardinalidad-código)
    - [🧭 Navegabilidad (Código)](#-navegabilidad-código)
    - [🤝 Implementación de Relaciones](#-implementación-de-relaciones)
    - [💔 Romper Relación Muchos a Muchos (N:M)](#-romper-relación-muchos-a-muchos-nm)

---

## 1. De Concepto a Diagrama (Sintaxis Mermaid)

Para generar diagramas de clase, empieza siempre tu bloque de código con:
```mermaid
classDiagram
    direction TB
```

### 🧱 Anatomía de la Clase y Miembros

| Concepto UML | Sintaxis Mermaid | Ejemplo | Notas |
| :--- | :--- | :--- | :--- |
| **Clase** | `class Nombre { ... }` | `class Perro { }` | PascalCase. |
| **Interfaz** | `<<interface>>` | `class IVolador { <<interface>> }` | Se usa como etiqueta dentro de la clase. |
| **Enumeración** | `<<enumeration>>` | `class Color { <<enumeration>> ROJO, AZUL }` | Lista de constantes. |
| **Clase Abstracta** | `<<abstract>>` | `class Figura { <<abstract>> }` | No se instancia. |
| **Público (+)** | `+` | `+string Nombre` | Visible para todos. |
| **Privado (-)** | `-` | `-int edad` | Visible solo en la clase. |
| **Protegido (#)** | `#` | `#void Crecer()` | Visible en la clase e hijas. |
| **Internal (~)** | `~` | `~Connect()` | Visible en el proyecto. |
| **Estático** | `$` al final | `+int Contador$` | Subrayado en el dibujo. |
| **Método Abstracto** | `*` al final | `+Dibujar()*` | En cursiva en el dibujo. |
| **Genéricos** | `~T~` | `List~String~ etiquetas` | Se renderiza como `<T>`. |

### 🔗 Relaciones y Flechas

| Tipo de Relación | Símbolo | Significado | Ejemplo Mermaid |
| :--- | :--- | :--- | :--- |
| **Herencia** | `<|--` | "Es un" (Is-a). | `Animal <|-- Perro` |
| **Implementación** | `<|..` | "Cumple contrato". | `IVolador <|.. Pajaro` |
| **Composición** | `*--` | "Todo-Parte" fuerte. Muerte en cascada. | `Coche "1" *-- "4" Rueda` |
| **Agregación** | `o--` | "Todo-Parte" débil. Parte sobrevive. | `Equipo "1" o-- "*" Jugador` |
| **Asociación** | `-->` | "Tiene un / Conoce a". | `Cliente --> Pedido` |
| **Dependencia** | `..>` | "Usa puntualmente". (En método). | `Impresora ..> Documento` |

### 🔢 Multiplicidad (Cardinalidad)

Indica cuántos objetos participan en la relación. Se pone entre comillas dobles.

| Cardinalidad | Sintaxis Mermaid | Ejemplo | Significado |
| :--- | :--- | :--- | :--- |
| **1 (Uno)** | `"1"` | `Coche "1" *-- "1" Motor` | Obligatorio tener uno. |
| **0..1 (Opcional)** | `"0..1"` | `Persona "1" --> "0..1" Coche` | Puede tener uno o ninguno (null). |
| **0..* (Muchos)** | `"0..*"` o `"*"` | `Cliente "1" --> "*" Pedido` | Lista vacía o con elementos. |
| **1..* (Al menos uno)** | `"1..*"` | `Equipo "1" o-- "1..*" Jugador` | Lista con al menos un elemento obligatorio. |

### 🧭 Navegabilidad (Flechas)

La dirección de la flecha indica quién sabe de la existencia del otro.

| Tipo | Símbolo Mermaid | Significado Visual |
| :--- | :--- | :--- |
| **Unidireccional** | `ClaseA --> ClaseB` | La flecha sale de A y apunta a B. A conoce a B. B ignora a A. |
| **Bidireccional** | `ClaseA -- ClaseB` | Línea simple sin puntas (o doble punta). Ambos se conocen. |

---

## 2. De Diagrama a Código (Implementación en C#)

Guía para traducir el dibujo a código real, usando sintaxis moderna (C# 12+).

### 🏗️ Definiciones Básicas

| Concepto UML | Implementación C# | Ejemplo Práctico |
| :--- | :--- | :--- |
| **Clase Simple** | `public class Nombre` | `public class Usuario { ... }` |
| **Herencia** | `: Padre` | `public class Perro : Animal { ... }` |
| **Interfaz** | `public interface INombre` | `public interface IVolador { void Volar(); }` |
| **Implementar** | `: Interfaz` | `public class Paloma : IVolador { ... }` |
| **Abstracta** | `abstract class` | `public abstract class Figura { ... }` |
| **Enum** | `public enum Nombre` | `public enum Color { Rojo, Verde }` |

### ⚙️ Atributos y Métodos

| Concepto UML | Implementación C# | Ejemplo Práctico |
| :--- | :--- | :--- |
| **Propiedad (+)** | `public Tipo Nombre { get; set; }` | `public string Dni { get; set; }` |
| **Campo Privado (-)** | `private Tipo _nombre;` | `private int _edad;` |
| **Solo Lectura** | `{ get; }` o `readonly` | `public string Id { get; } = "X";` |
| **Constructor** | `Primary Constructor` (Recomendado) | `public class Persona(string nombre) { ... }` |
| **Estático ($)** | `static` | `public static int Contador { get; set; }` |
| **Método Abstracto (*)**| `abstract` (sin cuerpo) | `public abstract double Area();` |
| **Sobreescribir** | `override` | `public override double Area() => 5.5;` |

### 🔢 Cardinalidad (Código)

Define la obligatoriedad y el tipo de estructura de datos.

| Cardinalidad | Implementación C# | Estrategia de Código |
| :--- | :--- | :--- |
| **1 (Uno)** | `public Tipo Prop { get; set; }` | **No Nullable**. Se debe exigir en el Constructor para asegurar que no es null. |
| **0..1 (Opcional)** | `public Tipo? Prop { get; set; }` | **Nullable (?)**. Puede valer `null`. Hay que comprobar antes de usar. |
| **0..* (Muchos)** | `public List<Tipo> Lista { get; } = [];` | **Lista inicializada**. Nunca es null, pero puede estar vacía (`Count == 0`). |
| **1..* (1 o más)** | `public List<Tipo> Lista { get; }` | **Lista + Validación**. El Constructor debe exigir el primer elemento obligatoriamente. |

### 🧭 Navegabilidad (Código)

Define si guardamos una referencia al otro objeto o no.

| Tipo | Implementación C# | Explicación |
| :--- | :--- | :--- |
| **Unidireccional** <br> *(A conoce a B)* | `class A { public B RefB { get; set; } }` <br> `class B { /* Nada de A */ }` | Solo la clase origen tiene la propiedad. |
| **Bidireccional** <br> *(Ambos se conocen)* | `class A { public B RefB { get; set; } }` <br> `class B { public A RefA { get; set; } }` | Ambas clases tienen propiedades cruzadas. Hay que sincronizarlas. |

### 🤝 Implementación de Relaciones

| Relación UML | Cómo se programa en C# | Ejemplo de Código |
| :--- | :--- | :--- |
| **Asociación (1:1)** | Propiedad del tipo destino. | `public Direccion Domicilio { get; set; }` |
| **Asociación (1:N)** | Colección (`List<T>`). | `public List<Pedido> Pedidos { get; } = new();` |
| **Composición** | Instanciación interna o control de vida. | `public List<Hoja> Hojas { get; } = [ new(), new() ];` <br> *(Si muere el árbol, mueren las hojas)* |
| **Agregación** | Recibir objeto externo (Constructor/Add). | `public void AgregarJugador(Jugador j) => Lista.Add(j);` <br> *(El jugador venía de fuera)* |
| **Dependencia** | Parámetro en un método. | `public void Imprimir(Documento doc) { ... }` <br> *(No guardo el doc, solo lo uso)* |
| **Inyección (DI)** | Recibir interfaz en constructor. | `public Coche(IMotor m) { _motor = m; }` |

### 💔 Romper Relación Muchos a Muchos (N:M)

Cuando tengas `Alumno "*" -- "*" Curso`, **NO** crees listas cruzadas directas si hay datos en la relación (como la Nota). Crea una **Clase Intermedia**.

**Estructura en C#:**

1.  **Clase Intermedia:**
    ```csharp
    public class Matricula(Alumno a, Curso c) {
        public Alumno AlumnoRef { get; } = a;
        public Curso CursoRef { get; } = c;
        public double Nota { get; set; } // El dato extra
    }
    ```

2.  **Clases Principales (1:N hacia la intermedia):**
    ```csharp
    public class Alumno {
        // NO tiene List<Curso>, tiene List<Matricula>
        public List<Matricula> Expediente { get; } = new();
    }
    
    public class Curso {
        // NO tiene List<Alumno>, tiene List<Matricula>
        public List<Matricula> Actas { get; } = new();
    }
    ```
