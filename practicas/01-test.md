

### Cuestionario de Diseño Orientado a Objetos y UML (1DAW)

- [Cuestionario de Diseño Orientado a Objetos y UML (1DAW)](#cuestionario-de-diseño-orientado-a-objetos-y-uml-1daw)
  - [Bloque 1: Introducción y Conceptos Fundamentales](#bloque-1-introducción-y-conceptos-fundamentales)
  - [Bloque 2: Anatomía de la Clase y Visibilidad](#bloque-2-anatomía-de-la-clase-y-visibilidad)
  - [Bloque 3: Relaciones y Estructura](#bloque-3-relaciones-y-estructura)
  - [Bloque 4: Herencia, Interfaces y Dilemas](#bloque-4-herencia-interfaces-y-dilemas)
  - [Bloque 5: Análisis Lingüístico y SOLID](#bloque-5-análisis-lingüístico-y-solid)
  - [Bloque 6: Herramientas y Casos Prácticos](#bloque-6-herramientas-y-casos-prácticos)


#### Bloque 1: Introducción y Conceptos Fundamentales
**1. ¿Cuál es el principal objetivo del modelado con UML antes de programar?**
A) Sustituir el código fuente por dibujos.
B) Comprender, documentar y comunicar la arquitectura del sistema.
C) Aumentar la velocidad de escritura de sintaxis en C#.
D) Eliminar la necesidad de un analista de software.

**2. ¿Qué se entiende por el "Dominio del Problema"?**
A) El lenguaje de programación elegido para el proyecto.
B) El entorno real donde ocurre el proceso que se quiere automatizar.
C) El conjunto de errores que el programador debe corregir.
D) La base de datos donde se guardan los objetos.

**3. ¿Cuál es la tarea principal del Analista según las fuentes?**
A) Corregir errores de sintaxis en Rider.
B) Identificar conceptos relevantes (Clases) y sus interacciones (Relaciones).
C) Escribir el manual de usuario del sistema.
D) Diseñar la interfaz gráfica en HTML/CSS.

**4. ¿Qué representa el Diagrama de Clases en UML?**
A) El comportamiento del sistema paso a paso en el tiempo.
B) La estructura estática del sistema y cómo se organizan internamente los objetos.
C) El flujo de datos entre servidores.
D) La lógica de los bucles "if" y "while" del código.

**5. ¿Cuál es la diferencia entre un "Modelo de Dominio" y un "Modelo de Diseño"?**
A) No hay diferencia; son sinónimos.
B) El de dominio es visual y el de diseño es solo texto.
C) El de dominio es conceptual y cercano al usuario; el de diseño incluye detalles técnicos como tipos de datos y visibilidad.
D) El de diseño se hace antes que el de dominio.

**6. ¿En qué consiste la "Abstracción" en el diseño OO?**
A) En ocultar todos los métodos de una clase.
B) En aislar los elementos esenciales de un objeto para definir su "molde" o Clase.
C) En copiar la realidad de forma exacta sin omitir ningún detalle.
D) En heredar todas las características de una clase padre.

**7. ¿Qué es un objeto o instancia con respecto a una clase?**
A) El código fuente de la clase.
B) Un elemento concreto creado a partir del molde de la clase.
C) Un método estático dentro de la clase.
D) El nombre que se le da a la clase en PascalCase.

**8. ¿Cuál es un beneficio directo del encapsulamiento?**
A) Permite que cualquier objeto externo cambie los datos internos.
B) Facilita que el sistema sea más lento pero más seguro.
C) Protege el estado interno del objeto de manipulaciones indebidas.
D) Obliga a usar siempre herencia para compartir datos.

**9. En el "Caso de la Biblioteca", ¿por qué modelar "PrestarLibro" como una clase es un error común?**
A) Porque es una acción (método), no un objeto con identidad propia.
B) Porque los libros no se pueden prestar en un sistema digital.
C) Porque UML no permite nombres de clases con verbos.
D) Porque el bibliotecario no lo permitiría.

**10. ¿Cuál es el orden inalterable de los compartimentos de una clase en UML?**
A) Atributos, Métodos, Nombre.
B) Nombre, Métodos, Atributos.
C) Nombre, Atributos, Métodos.
D) Métodos, Nombre, Visibilidad.

#### Bloque 2: Anatomía de la Clase y Visibilidad
**11. ¿Qué símbolo UML se utiliza para la visibilidad "private" en C#?**
A) +
B) #
C) ~
D) -

**12. ¿Qué significa el símbolo "#" en un diagrama de clases?**
A) Que el miembro es accesible solo por la misma clase.
B) Que el miembro es accesible por la clase y sus clases hijas (protected).
C) Que es un método estático.
D) Que es un comentario en el diagrama.

**13. ¿Cuál es el alcance de la visibilidad "internal" (símbolo ~) en C#?**
A) Solo la clase actual.
B) Cualquier clase dentro del mismo ensamblado o proyecto.
C) Universal, cualquier clase puede acceder.
D) Solo clases que hereden de la original.

**14. ¿Qué consecuencia tiene declarar todos los atributos como públicos (+)?**
A) Mejora el rendimiento del código.
B) Rompe la lógica de negocio al permitir valores inválidos desde el exterior.
C) Es una buena práctica recomendada para el analista.
D) Evita tener que usar constructores.

**15. ¿Cómo se representan los atributos o métodos estáticos (static) en UML?**
A) Escribiéndolos en cursiva.
B) Subrayando el elemento.
C) Poniendo el símbolo $ al principio.
D) Encerrándolos entre paréntesis.

**16. ¿Qué caracteriza a una "Clase Abstracta"?**
A) Que no tiene atributos, solo métodos.
B) Que es una clase que no puede instanciar objetos directamente.
C) Que todos sus métodos deben ser privados.
D) Que se representa con un rombo lleno en UML.

**17. ¿Qué es una Interfaz en el diseño orientado a objetos?**
A) Una clase que hereda de varias madres.
B) Un contrato puro que define qué debe hacer un objeto, pero no cómo.
C) El diseño de la pantalla del usuario.
D) Una clase que solo contiene atributos estáticos.

**18. Según el "Truco del Analista", ¿qué indica la frase "Los datos son estrictamente confidenciales" en un enunciado?**
A) Atributos Públicos (+).
B) Atributos Protegidos (#).
C) Atributos Privados (-).
D) Atributos Estáticos.

**19. ¿Para qué sirve el subrayado en un atributo de clase como "contadorFacturas"?**
A) Para indicar que es la clave primaria.
B) Para indicar que es un miembro estático que pertenece a la clase en sí.
C) Para señalar un error de diseño.
D) Para indicar que es un atributo obligatorio.

**20. ¿Qué herramienta en Rider permite ver candados, llaves y puntos como símbolos de visibilidad?**
A) Mermaid Preview.
B) Diagrams > Show Diagram.
C) Solution Explorer.
D) C# Interactive.

#### Bloque 3: Relaciones y Estructura
**21. ¿Qué indica la "Multiplicidad" en una relación de asociación?**
A) La cantidad de métodos que tiene la clase.
B) Cuántos objetos de una clase pueden estar vinculados a un objeto de la otra.
C) El número de clases hijas que tiene un padre.
D) La velocidad de transferencia de datos.

**22. ¿Qué significa la multiplicidad "0..*" o "*"?**
A) Exactamente cero.
B) Uno o muchos.
C) Muchos (cero o más).
D) Exactamente uno.

**23. ¿Qué impacto tiene la navegabilidad unidireccional (flecha -->) en el código C#?**
A) Ambas clases deben tener referencias mutuas.
B) La clase origen debe tener un campo o propiedad de la clase destino.
C) Ninguna clase conoce a la otra.
D) Se debe usar herencia obligatoriamente.

**24. ¿Qué define a una "Dependencia Débil"?**
A) Es una conexión permanente entre dos clases.
B) Ocurre cuando una clase usa a otra puntualmente (ej. como parámetro de un método).
C) Se representa con un rombo vacío.
D) Requiere inyección por constructor obligatoria.

**25. ¿Qué es la Inyección de Dependencias (DI)?**
A) Una técnica donde una clase crea sus propias dependencias con "new".
B) Una técnica donde una clase recibe sus dependencias desde fuera.
C) Un proceso para eliminar todas las interfaces del sistema.
D) Una forma de herencia múltiple en C#.

**26. ¿Cuál es la principal ventaja de la Inyección por Constructor?**
A) Permite cambiar la dependencia en cualquier momento del ciclo de vida.
B) Asegura que el objeto siempre esté en un estado válido al ser creado.
C) Evita el uso de interfaces.
D) Es la opción más flexible para el programador.

**27. ¿Qué peligro existe al usar Inyección por Setter/Propiedad?**
A) El objeto se vuelve demasiado rígido.
B) Riesgo de NullReferenceException si se olvida llamar al setter.
C) No permite usar C#.
D) Aumenta el acoplamiento fuerte.

**28. ¿En qué se diferencia la Agregación de la Composición respecto al ciclo de vida?**
A) En la agregación, la parte muere si el todo muere.
B) En la composición, la vida de la parte está ligada a la del todo.
C) En la composición, la parte puede existir sin el todo.
D) No hay diferencia en el ciclo de vida, solo en el símbolo.

**29. ¿Qué símbolo UML representa la Composición?**
A) Rombo hueco (o--).
B) Flecha de punta triangular vacía.
C) Rombo lleno (*--).
D) Línea discontinua con flecha.

**30. ¿Qué relación ejemplifica mejor la Agregación?**
A) Un Libro y sus Páginas.
B) Una Universidad y sus Profesores.
C) Un Pedido y sus Líneas de Detalle.
D) Una Clase y sus métodos.

#### Bloque 4: Herencia, Interfaces y Dilemas
**31. ¿Qué concepto define la relación de Herencia?**
A) "Tiene-un".
B) "Se comporta como".
C) "Es-un".
D) "Usa-un".

**32. ¿Cómo se representa la Implementación de una interfaz en UML?**
A) Línea continua con flecha de punta triangular vacía.
B) Línea discontinua con flecha de punta triangular vacía.
C) Línea continua con rombo lleno.
D) Línea discontinua con flecha simple.

**33. ¿Cuándo se recomienda usar una Interfaz en lugar de Herencia?**
A) Cuando las clases comparten datos y lógica interna compleja.
B) Cuando solo comparten el nombre de un método pero lo ejecutan de forma distinta.
C) Cuando una clase es una especialización estricta de otra.
D) Nunca; la herencia siempre es preferible.

**34. ¿Qué problema presenta la herencia pura en el "Caso del Motor Híbrido"?**
A) C# no permite heredar de ninguna clase.
B) Un motor híbrido no puede tener métodos.
C) C# no permite herencia múltiple de clases para combinar capacidades de motores distintos.
D) Los motores eléctricos no pueden representarse en UML.

**35. ¿Qué es la "Especialización" en el contexto de herencia?**
A) El proceso de inyectar una dependencia.
B) Cuando una clase hija es una versión específica de una superclase.
C) El uso de una interfaz para definir comportamientos.
D) La creación de una clase Dios que hace todo.

#### Bloque 5: Análisis Lingüístico y SOLID
**36. Según el Análisis Lingüístico, ¿en qué se traduce un "Sustantivo Común" del enunciado?**
A) Un Método.
B) Una Clase.
) Un Atributo.
D) Una Relación de herencia.

**37. ¿Qué representa un "Verbo de acción" en la estructura técnica?**
A) Una Clase.
B) Un Atributo de tipo booleano.
C) Un Método o Operación.
D) Una Enumeración (Enum).

**38. Para romper una relación de muchos a muchos (N:M), ¿qué técnica se utiliza?**
A) Usar herencia múltiple.
B) Crear una Clase Intermedia o Clase Relación.
C) Eliminar una de las dos clases.
D) Convertir la relación en una dependencia débil.

**39. ¿Qué establece el principio de Responsabilidad Única (S)?**
A) Que una clase solo puede tener un método público.
B) Que una clase debe tener una sola razón para cambiar.
C) Que todos los objetos deben ser creados por una única fábrica.
D) Que solo se puede usar una interfaz por proyecto.

**40. ¿Qué significa el principio Abierto/Cerrado (O)?**
A) El código debe estar abierto a modificaciones y cerrado a extensiones.
B) Las clases deben ser abiertas para extensión pero cerradas para modificación.
C) Las interfaces deben ser cerradas para que nadie las vea.
D) Solo se pueden abrir archivos .cs que estén cerrados en Rider.

**41. ¿Qué error de diseño ejemplifica el "Pingüino que no vuela" en el principio de Liskov (L)?**
A) Usar una interfaz cuando se debía usar herencia.
B) Una clase hija que rompe el comportamiento esperado de la clase padre.
C) No poner atributos privados en la clase Ave.
D) El pingüino debería ser una interfaz y no una clase.

**42. ¿Qué promueve la Segregación de Interfaces (I)?**
A) Crear una gran interfaz con todos los métodos posibles.
B) Crear muchas interfaces pequeñas y atómicas en lugar de una "gorda".
C) Separar las interfaces por colores en el diagrama.
D) Obligar a los robots a implementar el método "Comer()".

**43. ¿Qué busca el principio de Inversión de Dependencias (D)?**
A) Que las clases dependan de abstracciones (interfaces) y no de clases concretas.
B) Que el padre dependa totalmente de lo que haga el hijo.
C) Que las clases concretas sean las que manden en la arquitectura.
D) Eliminar el uso de la inyección por constructor.

#### Bloque 6: Herramientas y Casos Prácticos
**44. ¿Qué ventaja ofrece Mermaid.js al ser "Diagram as Code"?**
A) Permite dibujar con el ratón más rápido que con código.
B) Se puede versionar en Git y hacer "merges" de cambios en el diagrama.
C) No requiere aprender ninguna sintaxis.
D) Solo funciona en Visual Studio Code.

**45. En la sintaxis de Mermaid, ¿cómo se representa una relación de Composición?**
A) <|--
B) o--
C) *--
D) ..>

**46. ¿Cómo se representan los tipos genéricos (como List\<T>) en Mermaid?**
A) Usando paréntesis: List(Alumno).
B) Usando tildes: List~Alumno~.
C) Usando corchetes: List[Alumno].
D) No se pueden representar.

**47. ¿Qué es la "Ingeniería Inversa" en JetBrains Rider?**
A) Escribir el diagrama para que se genere el código automáticamente.
B) Generar automáticamente un diagrama UML a partir de código C# existente.
C) Borrar el código para volver a la fase de análisis.
D) Cambiar el orden de los métodos de una clase.

**48. En el "StarFleet Manager", ¿por qué "Nave" debe ser una clase abstracta?**
A) Porque no existen naves en el espacio real.
B) Porque no existe una nave "genérica" que se pueda instanciar sin ser Caza o Carguero.
C) Porque tiene demasiados métodos.
D) Para que no pueda tener un contador estático.

**49. ¿Cuál es el principal beneficio del patrón Factory (Fábrica)?**
A) Hacer que el programa sea más difícil de entender para otros.
B) Centralizar y abstraer la creación de objetos complejos.
C) Eliminar la necesidad de usar interfaces.
D) Sustituir a todos los constructores de las clases.

**50. Según el "Golden Path" de trabajo, ¿cuál es el paso final recomendado?**
A) Dibujar el diagrama en un papel.
B) Validar que el código escrito coincide con el diseño original comparando diagramas.
C) Borrar el archivo README.md.
D) Enviar el código directamente al cliente sin probarlo.

***

