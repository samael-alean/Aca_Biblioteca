SISTEMA DE GESTIÓN DE BIBLIOTECA
Autores:

Amaury Antonio Echavarria Alean
Institución: Corporación Unificada Nacional de Educación Superior (CUN)
Asignatura: Programación Avanzada
Docente: Verónica Castro Munar
Fecha: Noviembre 2026

TABLA DE CONTENIDO
Introducción
Objetivos
2.1. Objetivo General
2.2. Objetivos Específicos
Planteamiento del Problema
Análisis de Requerimientos
4.1. Requerimientos Funcionales (RF)
4.2. Requerimientos No Funcionales (RNF)
Casos de Uso
5.1. Matriz de Casos de Uso
5.2. Diagrama de Casos de Uso
5.3. Especificación Detallada de Casos de Uso
Diagrama de Clases
Modelo Entidad-Relación (MER / DER)
Diccionario de Datos
Arquitectura del Sistema
Explicación de los Módulos Desarrollados
Descripción de la Conexión con SQL Server
Diseños e Interfaz del Sistema (Capturas y Maquetación)
Pruebas de Funcionamiento
Conclusiones
Recomendaciones
Referencias Bibliográficas

1. INTRODUCCIÓN
En la era digital en la que estamos inmersos, es relevante que las instituciones educativas sean capaces de gestionar adecuadamente la información. Por ello, en las bibliotecas escolares y universitarias se pueden implementar sistemas de información para la gestión de recursos bibliográficos, usuarios (estudiantes y profesores) y transacciones. Se pueden instalar sistemas integrados de información que reemplacen los manuales o los semiautomatizados. De esta forma se consiguen optimizar los tiempos de respuesta, el control de inventarios y reducir los errores humanos.

2. OBJETIVOS
2.1 OBJETIVO GENERAL
Crear una aplicación de escritorio que permita el manejo de información de forma intuitiva y segura. Se implementará en C# utilizando Windows Forms y SQL Server. Se busca automatizar y optimizar los procesos de registro y consulta de información; además de permitir el préstamo y retorno de libros; y generar reportes relacionados con la bibliografía de la institución educativa.

2.2 OBJETIVOS ESPECÍFICOS
Diseñar la base de datos relacional en SQL Server siguiendo los principios de normalización (Tercera Forma Normal - 3FN) para eliminar redundancias e inconsistencias.
Implementar los módulos de mantenimiento (CRUD) para Autores, Editoriales, Libros y Usuarios.
Desarrollar la lógica de negocio para la gestión transaccional de préstamos y devoluciones, calculando la disponibilidad de ejemplares y controlando los estados.
Implementar una arquitectura de tipo N-Capas (Presentación, Lógica de Negocio, Acceso a Datos y Datos/Entidades) que favorezca la mantenibilidad y el desacople de componentes.
Incluir mecanismos de consulta de datos y reportes operativos que ayuden en la toma de decisiones administrativas.
Ejecutar un plan de pruebas funcionales para validar que los módulos se ejecutan correctamente y probar la robustez de las conexiones a la base de datos.
3. PLANTEAMIENTO DEL PROBLEMA
Los problemas de las instituciones educativas que manejan su biblioteca de manera manual (o en hojas de cálculo aisladas) son complejos. Los más comunes son:

Pérdida de control de inventario: Imposibilidad de conocer el stock disponible (o entregado) de un determinado título en tiempo real.
Inconsistencia en devolución: Proceso manual propenso a errores en las fechas de entrega, dificultando el control de usuarios morosos.
Duplicidad de información: Ausencia de restricciones relacionales que genera duplicación de datos (autores, editoriales, usuarios).
Tiempos de búsqueda elevados: Tiempos de respuesta altos al consultar catálogos o historiales de préstamos.
Falta de reportes: Dificultad para generar reportes estadísticos operativos (libros más solicitados, estado general del catálogo).
Solución Propuesta:
Estos inconvenientes se solucionan centralizando la información en SQL Server mediante transacciones ACID (Atomicidad, Consistencia, Aislamiento y Durabilidad). El sistema cuenta con una interfaz intuitiva desarrollada en C# (Windows Forms).

4. ANÁLISIS DE REQUERIMIENTOS
4.1 Requerimientos Funcionales (RF)
Código	Nombre del Requerimiento	Descripción
RF-01	Gestión de Autores	Permite registrar, consultar, modificar y desactivar/eliminar información de los autores de libros.
RF-02	Gestión de Editoriales	Permite administrar la información de las casas editoriales (nombre, contacto, correo).
RF-03	Gestión de Libros	Permite registrar títulos bibliográficos vinculando autor, editorial, ISBN, año y stock (total y disponible).
RF-04	Gestión de Usuarios	Registra datos personales de estudiantes y docentes (documento, nombres, apellidos, teléfono, correo, tipo).
RF-05	Registro de Préstamos	Permite procesar el préstamo de uno o varios libros a un usuario activo, validando la disponibilidad de stock.
RF-06	Registro de Devoluciones	Procesa el retorno de los libros prestados, actualizando de forma automática el stock disponible y el estado del préstamo.
RF-07	Consultas de Catálogo	Ofrece filtros de búsqueda multicriterio por título, ISBN, autor o categoría.
RF-08	Generación de Reportes	Genera reportes de libros prestados, usuarios morosos y catálogo general en pantalla y exportables.
RF-09	Autenticación y Accesos	Controla el acceso mediante un módulo de inicio de sesión con credenciales de usuario y roles.
4.2 Requerimientos No Funcionales (RNF)
Código	Criterio	Descripción
RNF-01	Usabilidad	La interfaz gráfica en Windows Forms debe ser clara, intuitiva y navegable con atajos de teclado.
RNF-02	Rendimiento	Las consultas a la base de datos deben responder en un tiempo inferior a 2 segundos para cargas estándar.
RNF-03	Integridad de Datos	Se deben aplicar restricciones de clave primaria, clave foránea y validación de tipos en SQL Server.
RNF-04	Arquitectura	El código debe estructurarse en 3 o más capas independientes (Presentación, Negocio, Datos).
RNF-05	Seguridad	Las contraseñas de los usuarios deben guardarse mediante algoritmos de hashing en la base de datos.
RNF-06	Mantenibilidad	El código en C# debe incluir documentación en línea y nombres bajo la convención PascalCase y camelCase.
5. CASOS DE USO
5.1 Matriz de Casos de Uso
ID	Caso de Uso	Actor	Descripción
CU-01	Iniciar Sesión	Bibliotecario / Administrador	Valida las credenciales para acceder al sistema.
CU-02	Administrar Libros	Administrador	Gestiona el inventario de textos bibliográficos.
CU-03	Registrar Préstamo	Bibliotecario	Registra la salida de libros asignándolos a un usuario.
CU-04	Registrar Devolución	Bibliotecario	Procesa el reingreso del material bibliográfico al stock.
CU-05	Consultar Reportes	Administrador / Bibliotecario	Visualiza listados e informes de la operación.
5.2 Diagrama de Casos de Uso
Diagrama de casos de uso

5.3 Especificación Detallada de Casos de Uso
CU01 -- Gestionar libros
Actor principal: Bibliotecario / Administrador

Descripción: Permite registrar, consultar, actualizar, eliminar y buscar libros.

Precondiciones: - El usuario debe tener acceso al sistema. - [Otra precondición.]

Flujo principal: 1. El actor ingresa al módulo de libros. 2. El sistema muestra los libros registrados. 3. El actor selecciona la operación que desea realizar. 4. El sistema procesa la solicitud. 5. El sistema muestra el resultado.

Flujos alternativos: - [Describir errores o situaciones alternativas.]

Postcondiciones: - [Indicar el resultado de la operación.]

Caso de Uso: CU-04 Registrar Préstamo de Libros
Actores: Bibliotecario.

Precondiciones:

El usuario debe estar registrado y activo en el sistema.
El libro debe estar registrado en el sistema.
El stock disponible del libro debe ser mayor a 0 (
S
t
o
c
k
D
i
s
p
o
n
i
b
l
e
>
0
).
Flujo Principal:

El bibliotecario introduce el documento del usuario.
El sistema comprueba que el usuario está activo (sin sanciones pendientes).
El bibliotecario introduce el ISBN/Código del libro.
El sistema comprueba la disponibilidad de ejemplares en inventario.
El bibliotecario confirma la fecha límite de devolución.
El sistema registra la transacción en la base de datos (tabla Prestamo / DetallePrestamo).
Se decrementa en 1 unidad el stock disponible del libro.
Se muestra el comprobante por pantalla.
Flujos Alternos:

A1 (Usuario Inactivo/Sancionado): El sistema muestra un mensaje de alerta y no continúa con la transacción.
A2 (Stock Agotado): El sistema muestra un mensaje indicando que no hay ejemplares disponibles para el título seleccionado.
CU03 -- Registrar devolución
Actor principal: Bibliotecario / Administrador

Descripción: Permite registrar la devolución de un libro prestado.

Precondiciones: - Debe existir un préstamo activo.

Flujo principal: 1. Seleccionar el préstamo. 2. Registrar la devolución. 3. Calcular días de retraso. 4. Calcular multa cuando corresponda. 5. Actualizar disponibilidad. 6. Actualizar el estado del préstamo. 7. Mostrar confirmación.

Flujos alternativos: - [Describir situaciones de error.]

Postcondiciones: - La devolución queda registrada. - El libro vuelve a estar disponible según corresponda.

6. DIAGRAMA DE CLASES
6.1 Descripción
Describir las principales clases utilizadas en el sistema y su responsabilidad.

6.2 Diagrama de clases
Insertar aquí el diagrama de clases.

Diagrama de clase

6.3 Principales clases
Clase Responsabilidad

Libro Representar y gestionar la información de los libros. Autor Representar y gestionar los autores. Categoria Representar las categorías de los libros. Usuario Representar los usuarios de la biblioteca. Prestamo Gestionar la información de los préstamos. DetallePrestamo Relacionar los libros incluidos en un préstamo. Devolucion Gestionar las devoluciones y calcular retrasos/multas. [Otra clase] [Responsabilidad.]

6.4 Aplicación de POO
Explicar cómo se aplicaron:

Clases.
Objetos.
Constructores.
Métodos.
Propiedades.
Encapsulamiento.
Colecciones.
Herencia, si aplica.
Polimorfismo, si aplica.
Sobrecarga, si aplica.
7. MODELO ENTIDAD-RELACIÓN
7.1 Descripción
Representa la estructura de la base de datos y permite organizar la informacion necesaria para el funcionamiento de la aplicacion..

7.2 Diagrama entidad-relación
Insertar aquí el modelo entidad-relación.

Modelo entidad-relación

7.3 Relaciones principales
Describir las relaciones entre las entidades.

Ejemplo:

Un autor puede tener muchos libros.
Una categoría puede estar asociada a muchos libros.
Un usuario puede realizar muchos préstamos.
Un préstamo puede contener uno o varios detalles.
Un detalle de préstamo corresponde a un libro.
Un detalle puede generar una devolución.
8. DICCIONARIO DE DATOS
8.1 Convenciones
Abreviatura Significado

PK Clave primaria FK Clave foránea UQ Campo con valor único NULL Campo que puede estar vacío NOT NULL Campo obligatorio

8.2 Tabla: Autor
Campo Tipo de dato Clave Nulo Descripción

idAutor INT PK No Identificador único del autor. nombre VARCHAR(100) - No Nombre del autor. apellidos VARCHAR(100) - No Apellidos del autor. nacionalidad VARCHAR(50) - Sí Nacionalidad del autor. fechaNacimiento DATE - Sí Fecha de nacimiento.

8.3 Tabla: Categoria
Campo Tipo de dato Clave Nulo Descripción

idCategoria INT PK No Identificador único de la categoría. nombre VARCHAR(50) UQ No Nombre de la categoría. descripcion VARCHAR(200) - Sí Descripción de la categoría.

8.4 Tabla: Libro
Campo Tipo de dato Clave Nulo Descripción

idLibro INT PK No Identificador único del libro. codigo VARCHAR(20) UQ No Código único del libro. titulo VARCHAR(200) - No Título del libro. anioPublicacion INT - Sí Año de publicación. idAutor INT FK No Autor asociado al libro. idCategoria INT FK No Categoría del libro. cantidad INT - No Cantidad de ejemplares. estado VARCHAR(20) - No Estado del libro. sinopsis VARCHAR(500) - Sí Descripción o sinopsis del libro.

8.5 Tabla: Usuario
Campo Tipo de dato Clave Nulo Descripción

idUsuario INT PK No Identificador único del usuario. documento VARCHAR(20) UQ No Número de documento. tipoDocumento VARCHAR(20) - No Tipo de documento. nombre VARCHAR(100) - No Nombre del usuario. apellidos VARCHAR(100) - No Apellidos del usuario. direccion VARCHAR(150) - Sí Dirección del usuario. telefono VARCHAR(20) - Sí Teléfono de contacto. correo VARCHAR(100) - Sí Correo electrónico. fechaNacimiento DATE - Sí Fecha de nacimiento. estado VARCHAR(20) - No Estado del usuario.

8.6 Tabla: Prestamo
Campo Tipo de dato Clave Nulo Descripción

idPrestamo INT PK No Identificador único del préstamo. idUsuario INT FK No Usuario que realiza el préstamo. fechaPrestamo DATETIME - No Fecha del préstamo. estado VARCHAR(20) - No Estado del préstamo.

9. ARQUITECTURA DEL SISTEMA
9.1 Descripción general
El Sistema de Gestión de Biblioteca se desarrolla utilizando una arquitectura por capas, con el propósito de separar las responsabilidades del sistema y facilitar su mantenimiento, organización y evolución.

La arquitectura está compuesta por:

Capa de Presentación.
Capa de Lógica de Negocio.
Capa de Acceso a Datos.
Capa de Base de Datos.
9.2 Diagrama de arquitectura
Insertar aquí el diagrama de arquitectura.

Arquitectura del sistema

9.3 Capa de Presentación
Responsabilidad:

Es la capa mediante la cual el usuario interactúa con el sistema.

Componentes:

[FrmPrincipal]
[FrmLibros]
[FrmAutores]
[FrmEditoriales]
[FrmUsuarios]
[FrmPrestamos]
[FrmReportes]
Tecnología utilizada:

C#
Windows Forms
[.NET versión utilizada]
9.4 Capa de Lógica de Negocio
Responsabilidad:

Procesa las solicitudes provenientes de la interfaz, aplica las reglas de negocio y coordina las operaciones.

Componentes:

[LibroController]
[AutorController]
[EditorialController]
[UsuarioController]
[PrestamoController]
[ReportesController]
Ejemplos de reglas:

Validar disponibilidad.
Validar existencia del usuario.
Validar existencia del libro.
Calcular días de retraso.
Calcular multa.
Actualizar estados.
9.5 Capa de Acceso a Datos
Responsabilidad:

Gestiona la comunicación entre la aplicación y SQL Server.

Componentes:

[Conexion]
[LibroDAO]
[AutorDAO]
[EditorialesDAO]
[UsuarioDAO]
[PrestamoDAO]
[ReportesDAO]
Tecnologías utilizadas:

SQL Server.
ADO.NET / [tecnología realmente utilizada].
Consultas parametrizadas.
9.6 Capa de Base de Datos
La información del sistema se almacena en:

Base de datos: [NombreBaseDatos]

Tablas principales:

Autor
Editoriales
Libro
Usuario
Prestamo
Reportes
9.7 Flujo de información
Usuario
   ↓
Presentación
   ↓
Lógica de Negocio
   ↓
Acceso a Datos
   ↓
SQL Server
Las respuestas de la base de datos realizan el recorrido inverso hasta llegar nuevamente a la interfaz.

10. EXPLICACIÓN DE CADA MÓDULO DESARROLLADO
10.1 Módulo de libros
Objetivo: [Permite realizar operaciones de gestion de datos de una manera organizada y eficiente.]

Funcionalidades: - Registrar. - Consultar. - Actualizar. - Eliminar. - Buscar.

Validaciones: - [Se verifica que los campos obligatorios contengan información antes de registrar el libro.] [Se evita registrar libros con un ISBN que ya exista en la base de datos.] [Se muestran mensajes informativos cuando una busqueda no encuentra resultados o cuando una operacion se realiza correctamente.]

10.2 Módulo de autores
Objetivo: [Administra la informacion de los autores de los libros registrados de manera organizada.]

Funcionalidades: - Registrar. - Consultar. - Actualizar. - Eliminar.

10.3 Módulo de editoriales
Objetivo: [Administrar información como el nombre de la editorial asociados a los libros registrados en la biblioteca.]

Funcionalidades: - Registrar. - Consultar. - Actualizar. - Eliminar.

10.4 Módulo de usuarios
Objetivo: [Permite almacenar y gestionar datos personales de personas registradas en el sistema, facilita el control de usuarios que hacen uso de los servicios de la biblioteca.]

Funcionalidades: - Registrar. - Consultar. - Actualizar. - Eliminar.

10.5 Módulo de préstamos
Objetivo: [Gestiona el proceso de préstamo de libros a los ususarios registrados en el sistema permitiendo llevar un control de los libros prestados.]

Funcionalidades: - Registrar préstamo. - Consultar préstamos activos. - Consultar historial. - Actualizar disponibilidad.

10.6 Módulo de reportes
Objetivo: [Facilita el seguimiento de la información y apoyo al control administrativo visualisando información sibre los movimientos realizados en el sistema.]

Funcionalidades: - Generar reportes - Limpiar reportes.

11. CAPTURAS DE PANTALLA DEL SISTEMA
11.1 Menú principal
Menú principal

Descripción: [Imagen del Menu principal.]

11.2 Gestión de libros
Gestión de libros

Descripción: [Imagen de busqueda de lisbros disponibles.]

11.3 Gestión de autores
Gestión de autores

Descripción: [Imagen de busqueda de todos los autores disponibles.]

11.4 Gestión de editoriales
Gestión de editoriales

Descripción: [Imagen de busqueda de editoriales por nombre.]

11.5 Gestión de usuarios
Gestión de usuarios

Descripción: [Imagen de busqueda de todos los usuarios inscritos al sistema.]

11.6 Registro de préstamos
Registro de préstamos

Descripción: [Imagen de busqueda de ususarios que se les presto un libro con fecha de devolucion.]

11.7 Registro de reportes
Registro de reportes

Descripción: [Imagen de la busqueda de reportes como libros prestados o inventario de libros.]

12. PRUEBAS DE FUNCIONAMIENTO
12.1 Estrategia de pruebas
Describir cómo se verificó el funcionamiento del sistema.

12.2 Casos de prueba
ID Funcionalidad Entrada / Acción Resultado Resultado Estado esperado obtenido

CP01 Registrar libro Datos válidos Libro registrado [Resultado] Aprobado correctamente

CP02 Registrar libro Código repetido Mostrar mensaje [Resultado] Aprobado de validación

CP03 Registrar Datos válidos Usuario [Resultado] Aprobado usuario registrado

CP04 Registrar Libro disponible Préstamo [Resultado] Aprobado préstamo registrado y
disponibilidad
actualizada

CP05 Registrar Libro sin No permitir el [Resultado] Aprobado préstamo disponibilidad préstamo

CP06 Registrar Préstamo activo Registrar [Resultado] Aprobado devolución devolución y
actualizar
disponibilidad

CP07 Consulta Consultar libros Mostrar libros [Resultado] Aprobado disponibles disponibles

12.3 Evidencias de pruebas
Insertar capturas que demuestren los resultados de las pruebas.

Prueba CP01
Evidencia CP01

Resultado: [Se registra el libro.]

Prueba CP02
Evidencia CP02

Resultado: [Se repite el ISBN y no se guarda el libro.]

Prueba CP03
Evidencia CP02

Resultado: [Se guarda el ususario correctamente.]

Prueba CP04
Evidencia CP02

Resultado: [Se registra un prestamo.]

Prueba CP05
Evidencia CP02

Resultado: [No hay mas disponibilidad del libro.]

Prueba CP06
Evidencia CP02

Resultado: [Prestamos activos.]

Prueba CP07
Evidencia CP02

Resultado: [Libros disponibles]

13. CONCLUSIONES
El desarrollo del Sistema de Gestión de Biblioteca en C#, Windows Forms y SQL Server ha permitido dar solución a los cuellos de botella de información de la institución educativa, logrando un control automatizado del catálogo y del ciclo de vida de los préstamos.
El modelado de la base de datos bajo la Tercera Forma Normal (3FN) cumple con los requisitos de integridad referencial, eliminando redundancias en autores, editoriales, préstamos y usuarios.
La implementación de una arquitectura en N-Capas desacopla la lógica de acceso a datos de la interfaz gráfica, facilitando la mantenibilidad y escalabilidad del sistema.
Las pruebas de funcionamiento demuestran que las transacciones complejas (actualizaciones simultáneas de cabeceras de préstamo y stock de ejemplares) se realizan cumpliendo los principios ACID, garantizando la consistencia operativa.
14. RECOMENDACIONES
Implementación de lectores de código de barras/RFID: Adaptar la interfaz gráfica en Windows Forms para permitir la captura automatizada mediante código de barras o etiquetas RFID tanto en carnés de usuarios como en el material bibliográfico.
Migración a Servicios Web (Web API): Evolucionar la capa de datos hacia una API RESTful que permita la integración de futuras plataformas web y móviles para los estudiantes.
Planes de Respaldo Automatizados: Configurar tareas programadas mediante SQL Server Agent para ejecutar copias de seguridad (Backups) automáticas y periódicas de la base de datos BibliotecaBD.
Módulo de Notificaciones: Integrar un servicio de mensajería/correo electrónico (SMTP / API externa) para notificar recordatorios de devolución 24 horas antes del vencimiento.
15. REFERENCIAS BIBLIOGRÁFICAS
Ceballos, F. J. (2019). Enciclopedia de Microsoft Visual C# (5.ª ed.). Alfaomega / Ra-Ma.
Date, C. J. (2018). Introducción a los sistemas de bases de datos (8.ª ed.). Pearson Educación.
Elmasri, R., & Navathe, S. B. (2017). Fundamentos de sistemas de bases de datos (7.ª ed.). Pearson.
Microsoft Learn. (2024). Documentación oficial de ADO.NET y Windows Forms para C#. Microsoft Docs.
Pressman, R. S. (2020). Ingeniería del software: Un enfoque práctico (9.ª ed.). McGraw-Hill Education.
Sommerville, I. (2019). Ingeniería de Software (10.ª ed.). Pearson Educación.
