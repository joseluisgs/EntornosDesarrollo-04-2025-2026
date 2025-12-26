

# 📚 Relación de Ejercicios: Análisis y Modelado UML

- [📚 Relación de Ejercicios: Análisis y Modelado UML](#-relación-de-ejercicios-análisis-y-modelado-uml)
  - [1. El Ecosistema de la Red Social "ConnectX"](#1-el-ecosistema-de-la-red-social-connectx)
  - [2. Sistema de Gestión Gastronómica "GourmetOS"](#2-sistema-de-gestión-gastronómica-gourmetos)
  - [3. Consultoría de Software "AgileFactory"](#3-consultoría-de-software-agilefactory)
  - [4. Central de Reservas Aéreas "SkyHigh"](#4-central-de-reservas-aéreas-skyhigh)
  - [5. Atlas de Accidentes Geográficos](#5-atlas-de-accidentes-geográficos)
  - [6. Planificador Académico "FP-Manager"](#6-planificador-académico-fp-manager)
  - [7. Holding Inmobiliario "Universal-RealEstate"](#7-holding-inmobiliario-universal-realestate)
  - [8. Coordinación de Sedes Olímpicas](#8-coordinación-de-sedes-olímpicas)
  - [9. Sistema de Control Ferroviario "InterCity-Safety"](#9-sistema-de-control-ferroviario-intercity-safety)
  - [10. Gestión de Clínica Veterinaria "VetCare 24h"](#10-gestión-de-clínica-veterinaria-vetcare-24h)
  - [11. Marketplace de Microservicios Cloud "CloudStack"](#11-marketplace-de-microservicios-cloud-cloudstack)
  - [12. Logística de Refinería "OilFlow Control"](#12-logística-de-refinería-oilflow-control)
  - [13. Liga Profesional de E-Sports "ProGaming-League"](#13-liga-profesional-de-e-sports-progaming-league)
  - [14. Sistema de Domótica "SmartBuilding-Control"](#14-sistema-de-domótica-smartbuilding-control)
  - [15. Gestión de Flota de Exploración Espacial](#15-gestión-de-flota-de-exploración-espacial)
  - [16. Plataforma de E-Commerce Global "OmniShop"](#16-plataforma-de-e-commerce-global-omnishop)
  - [17. Sistema de Gestión de Tráfico Aéreo y Control de Pistas "SkyControl 2.0"](#17-sistema-de-gestión-de-tráfico-aéreo-y-control-de-pistas-skycontrol-20)
  - [18. Simulador de Ecosistema Planetario "GaiaSim"](#18-simulador-de-ecosistema-planetario-gaiasim)
  - [19. Gestión de Factoría de Automóviles Eléctricos "TeslaFlow"](#19-gestión-de-factoría-de-automóviles-eléctricos-teslaflow)
  - [20. Sistema de Gestión de Hospital de Campaña Inteligente "MedShield"](#20-sistema-de-gestión-de-hospital-de-campaña-inteligente-medshield)


## 1. El Ecosistema de la Red Social "ConnectX"

**Contexto:** La junta directiva de la multinacional *ConnectX* requiere un rediseño total de su núcleo de datos para soportar nuevos perfiles de usuario y políticas de privacidad europeas. 
**Enunciado:**
El sistema debe gestionar una base de usuarios donde la seguridad es primordial.  Todo usuario debe autenticarse mediante un identificador único y un sistema de encriptación de contraseñas. Se almacena información básica: nombre completo, dirección física, foto de perfil y correo electrónico, el cual debe ser único por política de sistema.  Debido a la ley de protección de datos, surge una distinción crítica: los **Usuarios Celebridad**. Cuando un usuario tiene este rango, el sistema debe encapsular y ocultar automáticamente su email, dirección y teléfono de cualquier consulta pública o visualización de perfil estándar. 
La red se basa en "vínculos de confianza". Un usuario gestiona una lista de contactos (que son, en esencia, otros usuarios). Para cada vínculo, el usuario puede redactar un comentario descriptivo personal que solo él puede ver. Estos contactos pueden organizarse en estructuras de **Grupos de Contacto** (con nombre propio). Un mismo usuario puede pertenecer a varios grupos del mismo dueño. Además, para mitigar el acoso, existe una lista de **Bloqueos** que impide interacciones. El sistema de publicaciones permite insertar texto e imágenes. Al publicar, el usuario debe decidir la **Visibilidad** (Interfaz `IVisible`): el post puede ser global, restringido a grupos específicos o a una lista blanca de individuos seleccionados. 

## 2. Sistema de Gestión Gastronómica "GourmetOS"

**Contexto:** Una prestigiosa cadena de restaurantes de alta cocina necesita modelar su flujo de trabajo, desde el control de personal hasta la trazabilidad de ingredientes en almacén. 
**Enunciado:**
El personal de *GourmetOS* es diverso. Todos los empleados registran su DNI, SS, teléfonos (fijo y móvil) y nombre completo. Los **Cocineros** son la élite y de ellos se computan sus años de servicio. Por otro lado, los **Pinches** (de quienes se anota la fecha de nacimiento) siempre deben estar bajo la tutela y cargo directo de un Cocinero mentor; un pinche no puede operar sin un superior asignado. La lógica de producción reside en los **Platos**. Cada plato tiene un nombre único y un precio. Deben clasificarse mediante un `Enum` de categorías: Entrante, Primero, Segundo o Postre. Un plato se compone de diversos ingredientes. Es vital la precisión: de cada ingrediente necesitamos saber la cantidad exacta para ese plato específico. Los ingredientes se encuentran en **Almacenes** (con nombre, número y descripción). Un Almacén se **compone** de **Estantes**, identificados por dos letras y un tamaño. El sistema debe realizar un control de stock en tiempo real: si un pinche retira dos ajos de un estante, el sistema debe descontarlos inmediatamente de ese estante específico. Finalmente, no todo cocinero tiene la habilidad para cada plato; el sistema debe mapear qué cocineros son capaces de preparar cada receta. 

## 3. Consultoría de Software "AgileFactory"

**Contexto:** Una factoría de software desea automatizar el control de proyectos para empresas externas, optimizando el uso de sus recursos humanos. 
**Enunciado:**
La empresa gestiona clientes corporativos de los que almacena CIF, dirección, teléfono y un código interno. Los **Proyectos** son el eje central: tienen una fecha de inicio, una fecha prevista de finalización y una fecha de finalización real (que a menudo difiere de la prevista). 
El modelo de trabajo es dinámico. Un **Trabajador** (con código, DNI y nombre) puede participar en múltiples proyectos. Lo complejo es que su **Rol** (Analista, Jefe de Proyecto, Programador) no es fijo: en un proyecto puede ser el líder y en otro un simple programador. Se debe registrar exactamente cuántas horas ha dedicado cada trabajador a cada proyecto según su rol. A todas las empresas clientes se les ha realizado al menos un proyecto. El sistema debe permitir definir profesiones nuevas (como "Administrador de Diseño") aunque no tengan trabajadores asignados todavía. 

## 4. Central de Reservas Aéreas "SkyHigh"

**Contexto:** Una aerolínea internacional busca un modelo robusto para gestionar el flujo desde la reserva inicial hasta el asiento físico en el avión. 
**Enunciado:**
Los clientes inician el proceso realizando una **Reserva**. En esta fase, se indican los datos personales (DNI, nombre, dirección) y una **Tarjeta de Crédito** que quedará vinculada permanentemente al perfil del cliente. Una reserva puede contemplar varias plazas, pero el asiento no se garantiza hasta el **Check-in**. Al emitir la **Tarjeta de Embarque**, el sistema asigna un **Asiento** específico, definido por fila, columna y planta del avión. Existe una regla flexible: se pueden emitir tarjetas de embarque incluso si el cliente no tenía reserva previa (ventas de mostrador). Cada tarjeta es estrictamente individual. El **Vuelo** vincula un código único, horarios de salida/llegada y dos **Aeropuertos** (Origen y Destino), los cuales tienen su propio código, ciudad y país. Cada vuelo es operado por un **Avión** concreto (con código y plazas totales), aunque un avión realizará muchos vuelos a lo largo de su vida útil. 

## 5. Atlas de Accidentes Geográficos

**Contexto:** Una organización científica internacional requiere un sistema para catalogar la orografía mundial y su relación con las fronteras políticas. 
**Enunciado:**
El sistema debe clasificar tres tipos de accidentes: **Ríos, Lagos y Montañas**. Todos heredan una base común: nombre y posición geográfica (coordenadas horizontales y verticales según el eje terrestre). Sin embargo, cada uno posee métricas especializadas que deben implementarse mediante una interfaz de medición o herencia específica: los ríos registran su longitud, las montañas su altura máxima y los lagos su extensión superficial. A nivel geopolítico, se almacenan los **Países** con su nombre, extensión y población.  Un accidente geográfico no entiende de fronteras: un río puede atravesar tres países distintos, y un país puede albergar múltiples montañas. El sistema debe permitir esta relación "muchos a muchos" para saber exactamente qué accidentes hay en cada nación y viceversa. 

## 6. Planificador Académico "FP-Manager"

**Contexto:** Un centro de formación profesional necesita una herramienta para gestionar horarios, aulas y el histórico de sustituciones del profesorado. 
**Enunciado:**
La unidad básica es el **Ciclo** (Superior, Medio o Inicial), que se compone de diversas **Asignaturas**. Una asignatura puede compartirse entre ciclos (mismo nombre y código europeo), pero tendrá un código interno diferente según el curso y ciclo donde se imparta. El sistema de **Prerrequisitos** es vital: para matricularse en asignaturas de segundo año, el alumno debe haber aprobado otras de primero (relación recursiva de dependencia). Las clases ocurren en **Aulas** (con código, nombre único, número y metros cuadrados). El horario se organiza en tramos de 6 horas diarias y días de la semana; un aula solo puede estar ocupada por una asignatura en un tramo dado. Los **Profesores** (con DNI, SS y datos de contacto) imparten asignaturas. Algunos actúan como tutores de un curso. Debido a la realidad de las bajas laborales, el sistema debe registrar el histórico: quién empezó a dar la asignatura y cuándo terminó, permitiendo saber qué profesor estaba en qué aula un día y hora concretos del pasado. 

## 7. Holding Inmobiliario "Universal-RealEstate"

**Contexto:** Una inmobiliaria de gran escala gestiona la compraventa y alquiler de activos, permitiendo flujos de trabajo donde los empleados también son clientes. 
**Enunciado:**
El sistema unifica a **Personas** (DNI, nombre, teléfonos), diferenciando entre **Clientes** y **Trabajadores**, ambos con un código personal único. Es común que un trabajador actúe como cliente al adquirir una propiedad, por lo que el modelo debe permitir esta dualidad. Los **Inmuebles** tienen metros, dirección, descripción y un código único. Se especializan en: **Pisos** (con código especial), **Locales** (con uso definido y servicios) y **Garajes** (con número y planta). Un Garaje puede estar vinculado a un Piso para alquileres conjuntos. Las operaciones son de dos tipos: **Compras** (con código, fecha, valor y posibilidad de múltiples titulares) y **Alquileres**. En el alquiler, se genera un número secuencial por inmueble y se registra qué agente de la empresa cerró el trato. Además, se debe llevar un control estricto de cada **Pago** mensual (año, mes, valor). 

## 8. Coordinación de Sedes Olímpicas

**Contexto:** El Comité Organizador requiere un sistema para supervisar los complejos deportivos, los eventos y el equipamiento necesario para la alta competición. 
**Enunciado:**
Las **Sedes Olímpicas** se organizan en **Complejos Deportivos**, que pueden ser de **Deporte Único** o **Polideportivos**. Los polideportivos se **componen** de múltiples áreas designadas con indicadores de localización (ej: "Esquina Norte"). Cada complejo tiene un Jefe de Organización, una localización y un presupuesto asignado. Cada complejo alberga varios **Eventos** (ej: la pista de atletismo puede celebrar 100m lisos y 110m vallas). Los eventos registran fecha, duración, participantes y el número de **Comisarios** necesarios. Los comisarios son personal especializado que puede actuar como "Juez" u "Observador" según el evento asignado. Por último, tanto para la competición como para el mantenimiento, se gestiona el **Equipamiento** (arcos, pértigas, etc.) mediante una interfaz de recursos. 

## 9. Sistema de Control Ferroviario "InterCity-Safety"

**Contexto:** Una red de trenes de alta velocidad necesita un sistema que gestione la seguridad en las vías, la composición de los convoyes y la asignación de maquinistas experimentados.
**Enunciado:**
La red ferroviaria se compone de **Vías**. Una vía está formada por una secuencia **compuesta** de **Tramos**. En los puntos de unión existen **Desvíos** que permiten a un tren cambiar de trayectoria. Es vital el uso de una Interfaz `IDispositivoSeguridad` que implementen tanto las **Balizas** fijas en la vía como los **Sistemas de Cabina** de los trenes para comunicación constante.
Un **Tren** es una **composición** técnica de una o dos Locomotoras y una lista ordenada de Vagones. Los vagones deben clasificarse mediante un `Enum`: Pasajeros, Cafetería o Carga. El orden es crítico para la aerodinámica. Los **Maquinistas** tienen un rango de experiencia (Novato, Senior, Instructor). El sistema debe validar que solo los Instructores puedan ser asignados a trenes que transporten materiales peligrosos en sus vagones de carga.

## 10. Gestión de Clínica Veterinaria "VetCare 24h"
**Contexto:** Una clínica veterinaria de urgencias requiere modelar la atención médica, el ingreso en jaulas de hospitalización y la facturación de procedimientos complejos.
**Enunciado:**
El sistema registra **Mascotas** (nombre, especie, chip). Cada mascota pertenece a un **Dueño**, pero puede tener asociados múltiples "Contactos de Emergencia". Los **Veterinarios** realizan **Consultas**, donde se genera un diagnóstico.
Durante la consulta, se puede emitir una **Receta** (que agrega múltiples medicamentos con su posología) o decidir una **Hospitalización**. La clínica se **compone** de **Jaulas** de diferentes tamaños. Una hospitalización vincula a un paciente con una jaula vacía. Todos los procedimientos deben implementar la Interfaz `ICobrable`. Esto incluye desde una cirugía mayor (que requiere un cirujano y dos auxiliares) hasta una simple vacuna. Se debe usar un `Enum` para el estado de salud del paciente (Estable, Crítico, Observación).

## 11. Marketplace de Microservicios Cloud "CloudStack"

**Contexto:** Una empresa de servicios en la nube permite a desarrolladores publicar APIs y a empresas suscribirse a ellas mediante diferentes planes de consumo.
**Enunciado:**
Los desarrolladores publican **Microservicios**. Cada servicio tiene una documentación técnica asociada y una URL de endpoint. Los clientes no compran servicios, sino que se adhieren a **Planes de Suscripción** definidos por un `Enum`: *Free, Pro, Enterprise*.
Cada plan tiene un **límite de peticiones** (miembro estático de configuración del sistema). El acceso se gestiona mediante una Interfaz `IAutenticador` que puede ser por clave API simple o por el protocolo OAuth2. El sistema debe registrar cada **Petición** realizada para generar estadísticas de uso. Un microservicio puede tener una relación de dependencia (agregación) con otros microservicios que necesita llamar para completar su tarea.

## 12. Logística de Refinería "OilFlow Control"

**Contexto:** Modelado técnico de una planta de procesamiento de crudo, donde la seguridad de las válvulas y el transporte son críticos.
**Enunciado:**
La refinería se **compone** de varias **Torres de Destilación**. Cada torre tiene integrados múltiples **Sensores de Presión y Temperatura** (composición). El crudo llega mediante **Buques Cisterna** y el producto final sale a través de **Camiones**. Ambos medios de transporte deben implementar la Interfaz `IVehiculoCisterna`, la cual obliga a tener un método de inspección de seguridad antes de la carga.
El producto se almacena en **Tanques de Reserva**. Cada tanque tiene una capacidad máxima y un `Enum` de tipo de combustible (Gasolina 95, Diesel, Queroseno). Existe una clase estática `ProtocoloEmergencia` que, en caso de fallo detectado por un sensor, envía una señal de cierre a todas las válvulas conectadas de forma masiva.

## 13. Liga Profesional de E-Sports "ProGaming-League"

**Contexto:** Plataforma para organizar torneos de videojuegos multijugador, gestionando equipos, contratos de patrocinio y retransmisiones.
**Enunciado:**
Un **Equipo** se **compone** de una plantilla de **Jugadores**. Cada jugador tiene un **Rol** de juego (ej: *Tanque, Apoyo, Atacante*). Los equipos participan en **Torneos**, que tienen una estructura jerárquica de **Fases** (Eliminatorias, Grupos). Las fases se componen de **Partidas**.
Tanto los equipos como el propio torneo pueden tener **Patrocinadores**. Se debe usar una Interfaz `IPatrocinable` para gestionar la inserción de logos en las retransmisiones. Una partida enfrenta a dos equipos y registra el resultado, la duración y el mapa utilizado. El sistema debe contar con un miembro estático que registre el premio total acumulado (Prize Pool) de toda la liga.

## 14. Sistema de Domótica "SmartBuilding-Control" 

**Contexto:** Control centralizado de sensores y actuadores en un edificio de oficinas inteligente para optimizar el consumo energético.
**Enunciado:**
El edificio se **compone** de **Plantas**, y cada planta se divide en **Zonas**. En cada zona se despliegan **Dispositivos IOT**. Estos dispositivos heredan de una clase abstracta común, pero se dividen en dos familias: **Sensores** (que leen datos como presencia o luminosidad) y **Actuadores** (que ejecutan acciones como encender luces o bajar persianas).
Todos los dispositivos deben implementar la Interfaz `IConectividad`, que gestiona el estado de la conexión con el **Hub Central**. Los actuadores, además, implementan la Interfaz `IProgramable` para establecer horarios automáticos. Si un sensor de presencia no detecta a nadie en 10 minutos, el sistema invoca al actuador de iluminación de esa zona para apagar las luces.

## 15. Gestión de Flota de Exploración Espacial

**Contexto:** Una agencia espacial necesita coordinar naves, tripulaciones y misiones de colonización en diferentes sistemas solares.
**Enunciado:**
La agencia gestiona una flota de **Naves Espaciales**. Cada nave se **compone** de una **Cabina de Mando**, un **Módulo de Propulsión** y un **Soporte Vital**. Las naves se clasifican según su propósito: *Exploración, Transporte o Minería* (usar `Enum`).
La **Tripulación** está formada por **Oficiales** que tienen un rango y una especialidad. El Capitán es el oficial al mando de la nave (agregación). Las naves realizan **Misiones** a diferentes **Planetas**. Un planeta tiene una atmósfera definida y una gravedad. Las naves deben implementar la Interfaz `IAterrizaje` para poder descender a la superficie. Si la misión es de minería, la nave debe agregar un módulo de **Extractor de Recursos**.

---


## 16. Plataforma de E-Commerce Global "OmniShop"

**Contexto:** Un gigante del comercio electrónico necesita un motor central para gestionar ventas internacionales, logística de almacenes y sistemas de fidelización dinámicos.
**Enunciado:**
El sistema gestiona un **Catálogo** masivo de **Productos**. Cada producto tiene un SKU único, nombre, descripción y un `Enum` para su `EstadoDisponibilidad` (EnStock, Agotado, Preventa). Los productos se especializan: existen **ProductosFísicos** (con peso y dimensiones para logística) y **ProductosDigitales** (con URL de descarga y tamaño en MB).
El **Carrito de Compras** es una **composición** de **LineasDeCarrito**; si el carrito se elimina, sus líneas también. Cada línea referencia a un Producto (agregación) y guarda la cantidad. Al tramitar el pedido, se genera una **Orden**. La Orden debe implementar la Interfaz `IProcesable` para validar pagos y stock.
Los **Clientes** pueden ser de tipo *Estándar* o *Premium*. Los Premium tienen una agregación a un **CupónDescuento**. El sistema de pagos debe ser desacoplado mediante la Interfaz `IPago`: se puede pagar con `TarjetaCredito`, `PayPal` o `Criptomoneda`. Además, cada producto físico debe estar ubicado en un **Almacén**, el cual se **compone** de **Pasillos** y estos de **Estantes**. Un producto puede estar en varios estantes de distintos almacenes (romper relación N:M con clase asociación `UbicaciónStock`).

## 17. Sistema de Gestión de Tráfico Aéreo y Control de Pistas "SkyControl 2.0"

**Contexto:** Un aeropuerto internacional requiere un modelo para coordinar aterrizajes, servicios de tierra y asignación de personal de seguridad en situaciones de emergencia.
**Enunciado:**
El **Aeropuerto** se **compone** de **Terminales** y **Pistas**. Las pistas tienen un `Enum` de `EstadoPista` (Libre, Ocupada, Mantenimiento, Emergencia). Un **Vuelo** es una entidad compleja que vincula una **Aeronave**, una **Ruta** y un **PlanDeVuelo**.
La **Tripulación** (clase abstracta) se divide en **Pilotos** (con horas de vuelo transoceánicas) y **Sobrecargos**. Ambos heredan de `PersonalAeroportuario`, pero solo los pilotos pueden implementar la Interfaz `IAutorizadoParaDespegue`.
Durante el aterrizaje, el vuelo solicita una **AsignaciónDePista**. Si la aeronave reporta una avería, el sistema debe activar la clase estática `ProtocoloEmergencia`, que bloquea la pista y notifica a los **EquiposDeRescate** (Bomberos y Médicos). Los equipos de rescate son agregaciones del aeropuerto, ya que pueden prestar servicio en otros lugares externos. Se debe modelar la relación entre el **Pasajero** y el **Equipaje**: un pasajero puede tener muchos bultos, y cada bulto tiene un código de seguimiento único y un peso que debe ser validado por la interfaz `IControlDePeso`.

## 18. Simulador de Ecosistema Planetario "GaiaSim"

**Contexto:** Una agencia espacial necesita un simulador para modelar la habitabilidad de exoplanetas, considerando factores climáticos, geológicos y formas de vida biotecnológicas.
**Enunciado:**
Un **SistemaSolar** se **compone** de una **Estrella** central y una colección de **Planetas**. Los planetas se clasifican mediante un `Enum` en *Rocosos, Gaseosos o Helados*. Cada planeta posee una **Atmósfera** (composición) definida por una mezcla de gases.
La **Vida** en el planeta se modela mediante una Clase Abstracta `Organismo`. De ella heredan `Flora` y `Fauna`. Sin embargo, han aparecido **EntidadesBiotecnológicas** que deben heredar de `Organismo` pero también implementar la Interfaz `IProcesamientoDigital`.
Existe una relación de **CadenaAlimentaria**: un organismo puede consumir a otros (relación reflexiva N:M). Para evitar ciclos infinitos, el sistema usa una Clase Asociación `InteracciónTrófica` que registra la transferencia de energía. El clima es gestionado por un **MotorClimático** (agregación) que afecta a todos los organismos de un planeta. Si el planeta tiene **Lunas**, estas se asocian al planeta mediante una relación de influencia gravitatoria que afecta a las mareas (interfaz `IEfectoFisico`).

## 19. Gestión de Factoría de Automóviles Eléctricos "TeslaFlow"

**Contexto:** Control total de una línea de montaje robotizada, desde la recepción de celdas de batería hasta el test de conducción autónoma.
**Enunciado:**
La **Factoría** se **compone** de múltiples **LíneasDeMontaje**. Cada línea tiene una serie de **EstacionesDeTrabajo**. En cada estación opera un **RobotIndustrial** o un **OperarioHumano**. Ambos deben implementar la Interfaz `IEnsamblador`, pero solo el humano puede realizar la `InspecciónVisual`.
El **Vehículo** en fabricación es una **composición** de un **Chasis**, un **PackDeBaterías** (formado por miles de celdas) y un **SistemaDeSoftware**. El software tiene una versión (miembro estático) que debe ser idéntica en todos los vehículos de la misma serie.
Las piezas llegan de **Proveedores**. Un proveedor puede suministrar muchos tipos de **Componentes**, y un componente puede ser suministrado por varios proveedores (romper N:M con clase `Suministro` que guarde fecha y lote). El Pack de Baterías es especialmente crítico: si el test de calidad falla, se activa una relación de descarte que desvincula los componentes para reciclaje (interfaz `IReciclable`).

## 20. Sistema de Gestión de Hospital de Campaña Inteligente "MedShield"

**Contexto:** Un sistema diseñado para desplegarse en zonas de catástrofe, gestionando recursos limitados, telemedicina y triaje masivo bajo condiciones críticas.
**Enunciado:**
El **Hospital** se **compone** de **UnidadesModulares** (UCI, Quirófano, Consultas, Albergue). Cada unidad tiene una capacidad máxima de energía proporcionada por un **Generador** (agregación, ya que un generador puede alimentar varias unidades).
Los **Pacientes** entran al sistema a través de un proceso de **Triaje**. El triaje asigna un `Enum` de `Prioridad` (Negro, Rojo, Amarillo, Verde). Cada paciente es atendido por un **EquipoMédico**, el cual se **compone** de un **MédicoResponsable**, dos **Enfermeros** y un **Técnico**.
Se debe modelar la Interfaz `IMonitorizable`: los pacientes críticos son conectados a **SensoresBiométricos**. Estos sensores envían datos a una **CentralDeControl** (clase estática para alertas globales). Si un paciente requiere medicación, se consulta el **InventarioFarmacéutico**. La relación entre Medicamento y Paciente se gestiona mediante la clase `DosisAdministrada`, que registra la hora, la cantidad y el profesional que la suministró. Para casos de telemedicina, el médico local debe implementar la Interfaz `IComunicaciónRemota` para consultar con especialistas externos.

---
