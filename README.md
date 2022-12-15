
# Arquitectura ReelCar Caso de Negocio:

ReelCar es una empresa dedicada a la venta de carros y diferentes productos en Colombia y en el resto de LatinoAmérica, actualmente el gerente de la compañía quiere empezar a comercializar sus productos en línea. Actualmente las cotizaciones generadas vía telefónica, Whatsapp y correo electrónico son de 200000 de personas por hora, lo cual el gerente manifiesta que la página podría tener más a razón de segundos.

Este software debe poder comercializarse porque el gerente quiere retribuir la inversión, y muchas empresas utilizan su mismo modelo de negocio, aunque asegura que las mismas deben poder parametrizar su marketing digital El sistema debe poder conectarse con herramientas de llamadas en línea, herramientas que permitan la
automatización de marketing y SEO.

Unos de los requerimientos provenientes de los comerciales es que quieren que se garantice la disponibilidad de la plataforma 24/7, puesto que muchos productos, mantenimiento y asignación de citas se venden en cualquier momento.


# Arquitecturas Limpias:

¿Que son las arquitecturas limpias?

Es una arquitectura basada en dominios que ayuda a organizar las dependencias en la aplicación, Cualquier aplicación que esta construida de forma tradicional puede romper los esquemas y paradigmas. Sin embargo las arquitecturas limpias ayudan a organizar esas dependencias para poder realizar mejor el mantenimiento e implementación en el tiempo. Los principios en los cuales se basa la arquitectura limpia son los SOLID.

El principal objetivo de utilizar las arquitecturas limpias es centranos en escribir las reglas de negocio y no estar pendientes de temas de infraestructura.

![CleanArchitecture](https://user-images.githubusercontent.com/120538000/207686627-f49e262e-8dec-4a4a-a45f-9531c50e9f18.jpg)

Las arquitecturas limpias dependen del dominio o negocio, La infraestructura implementa las interfaces o abstracciones que se definen en el dominio. la infraestructura tambien usa tipos que son definidos en el dominio. La capa de infraestructura es responsable de la persistencia de la base de datos. Con las arquitecturas limpias no tienes acoplammiento a nivel de base de datos, asi uses otro motor de base de datos incluso uno no relacional, sin hacer cambios a la interfaz o a la capa de negocio.


La imagen representa la implementación y los componentes de la arquitectura, a continuación se describen los componentes:

# El proyecto Core 

Este proyecto es el centro del diseño de la arquitectura limpia, y todos los otros proyectos deberian tener dependecias a el. El proyecto consta de los siguientes componentes:

- Entidades
- Agregados
- Eventos
- Objetos DTO
- Interfaces
- Especificaciones


## EL proyecto SharedKernel

Muchas soluciones referencian este proyecto debido a que son componentes reutilizables queridos en diferentes tipos de proyectos y soluciones como entidades base y utilitarios.


## El proyecto de Infraestructura

La mayoria de dependencias externas deberan implementarse en las clases definidas. Estas deberan implementar las interfaces definidas en el Core. Si tienes proyectos grandes con dependencias podrias tener mas proyectos de infraestructura. En el proyecto tenemos implementación de acceso a datos, pero se podrian tener implementaciones de acceso a archivos, apis etc. para Evitar dependencia del Core.



## El proyecto web

El punto de entrada de la aplicación es el proyecto web de  ASP.NET Core.  Este usa el modelo vista controlador (MVC) con vistas y controladores y tiene un programa de arranque que inicializa la aplicación e inyecta las dependencias.  Este incluye un archivo de configuración "appsettings.json" para las variables de la aplicación. 


Para la implementación del proyecto se utiliza una plantilla de arquitectura Limpia: https://marketplace.visualstudio.com/items?itemName=GregTrevellick.CleanArchitecture en Visual Studio .NET, el entorno de desarrollo que se utilizó fue Visual Studio 2022 con la versión .NET 7 y como framework de acceso a datos EntityFramework Core.

Se toma como referencia el proyecto de Microsoft para la implementación de la solución:
https://github.com/dotnet-architecture/eShopOnWeb




# Uso de Patrones

Modelo Vista Controlador:

Las tres partes del patrón de diseño de software MVC se pueden describir de la siguiente manera: Modelo: Maneja datos y lógica de negocios. Vista: Se encarga del diseño y presentación. Controlador: Enruta comandos a los modelos y vistas

Patrón Agregado:
Es un patron de diseño de dominio en donde puedes encapsular las entidades que hacen mas facil la persistencia. Por ejemplo: puedes tener un constructor de orden y un detalle de ordenes como un agregado.

Patrón Especificación:

Las especificaciones son forma de encapsular las consultas en una clase. Entonces se tendran diferentes especificaciones para los tipos de consultas que se hagan sobre el modelo.



# Metodologias Ágiles:

En el marco de las metodologias ágiles, es utiliza para la planeación del proyecto la herramienta Azure DevOps: https://jeffmunoz82.visualstudio.com/ReelCar/_dashboards/dashboard/444d38fa-fce7-4275-aac4-d7fcf3455f3c

Se realizan dos historias de usuario :


![image](https://user-images.githubusercontent.com/120538000/207698722-78f91f0f-da21-43d4-aadf-802a2fd59a4f.png)

Listar Catálogo de productos:

![image](https://user-images.githubusercontent.com/120538000/207699005-88b5f7d9-3e4d-40af-872b-51037350fa42.png)


Agregar Item al Carrito de Compras:


![image](https://user-images.githubusercontent.com/120538000/207699368-d90cb558-837b-4c6c-ab23-50e2b20f99d9.png)

La herramienta nos servira para realizar la planeación del proyecto, llevar el control de desarrollo durante el ciclo de vida del proyecto y realizar reporte de pruebas.



# Vista de Datos

![DiagramaBaseDatos](https://user-images.githubusercontent.com/120538000/207735963-7258ae9f-a5ed-4a1e-991d-61f8a6b7f3b8.png)

# Vista de Clases

![DiagramaClases](https://user-images.githubusercontent.com/120538000/207717665-696ddd32-dfed-4792-8baf-41a632e4d870.png)

# Vista Dinámica

![DiagramaSecuencia-GetCatalogItems drawio](https://user-images.githubusercontent.com/120538000/207728527-cee43ee6-fc51-4e12-967c-35899609e10b.png)

# CI/CD

Se crea PipeLine dentro de la cuenta de Azure DevOps para el despliegue automática  realizando la configuración del servicio de AWS Elastic Beanstalk Deploy Application, con la cuenta personal de AWS.

![image](https://user-images.githubusercontent.com/120538000/207736534-99e7abff-6f74-4cb9-817b-6ebb296e0c97.png)

Esta implementación sugirió un error de compilación, por lo que se intenta realizar el despliegue mediante el AWS Toolkit instalado en Visual Studio:

![image](https://user-images.githubusercontent.com/120538000/207736929-5fc98369-cca9-4fec-a6f7-3613a0362396.png)

La implementación fue exitosa, aca se muestra el paso a paso:

1.
![image](https://user-images.githubusercontent.com/120538000/207748584-2676bd9d-8af5-4261-b2c6-b14347cd15bd.png)
2.
![image](https://user-images.githubusercontent.com/120538000/207748492-500a2dc4-3f93-4d35-84ea-20c68ae75d2e.png)
3.
![image](https://user-images.githubusercontent.com/120538000/207748730-85ea326a-28c0-4050-9e57-21dd1b790dec.png)
4.
![image](https://user-images.githubusercontent.com/120538000/207748801-7601491e-c748-4537-892b-b05210e13e66.png)
5.
![image](https://user-images.githubusercontent.com/120538000/207748866-cdecff75-5da2-4946-87cb-845c380f9a0c.png)
6.
![image](https://user-images.githubusercontent.com/120538000/207748934-e6fbe2a7-7bc3-4583-845b-d91d7e389a53.png)
7.
![image](https://user-images.githubusercontent.com/120538000/207750436-97ac61bc-1aca-4ee6-b90c-3aabfbd9ff8d.png)




