# Prueba técnica de Alejandro González Ruiz

Muy buenas tardes, le saluda Alejandro González, matemático y programador jr. egresado de facultad de ciencias de la UNAM. Me complace presentarles mi proyecto para la posición de desarrollador jr. .NET 

## Intrucciones de uso

    Este proyecto fué desarrollado en dos partes, la primera parte es un formulario de windows y la segunda es un servicio como tal. 

### Instrucciones generales

1. Dentro de la solución, existe un archivo llamado app.config, acceda al archivo. 

2. En el apartado "appSettings" hay tres llaves de nombre 
* errors | es la llave de la ruta en la que se guardan los archivos con errores 
* filesProcessed | es la llave de la ruta en la que se guardan los archivos procesados correctamente
* readyToProcess | es la llave de la ruta en la que se guardan los archivos aún no procesados. 

3. Cambie las rutas de dichas llaves a las rutas absolutas de sus carpetas con cada uno de los propósitos correspondientes en su sistema. 
4. En el apartado "connectionStrings" en la etiqueda de nombre "ConexionSQL" agregue el usuario y contraseña del servidor correspondiente, cambiando los asteriscos en dicho apartado.


### Activando el formulario 

Una vez realizadas las configuraciones deberá descomentar las lineas 28,29 y 30 dentro del archivo Program.cs y simplemente iniciar el programa desde VS 2022. 

Posteriormente se abrirá una ventana con dos botones, presione iniciar y automáticamante el progrma leerá cada uno de los archivos en su carpeta "readyToProcess" y almacenará los datos correspondientes en la base de datos "evaluacion_agonzalezr"

### Activando el servicio. 

Una vez realizadas las configuraciones deberá:

1. descomentar las lineas de la 20 a la 25 dentro del archivo Program.cs.
2. Limpiar y compilar el proyecto.
3. Debe ubicar la dirección del framework en su computadora, en esta carpeta deberá encontrar el archivo "installutil.exe" comunmente se encuentra en "C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe" copie esta dirección. 
4. Acceder a la raiz del proyecto usando el CMD o la terminal de su preferencia. Para esto puede usar el comando cd para acceder a los directorios correspondientes. 
5. Una vez en la raiz del proyecto acceda a la carpeta bin.
6. una vez en la carpeta bin acceda a la carpeta Release, donde se encuentra el archivo "entrevistaGA.exe"
7. pegue la ruta del framework en su computadora, seguido de espacio -i y por último espacio entrevistaGA.exe. La ruta completa se vería algo así. 

    C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe -i entrevistaGA.exe
 8. Por último ingrese al administrador de servicios, puede acceder presionando la tecla windows y escribiendo "servicios". Busque el servicio llamado "AlexService" y presione iniciar. 
 
puede usar este tutorial para mayor referencia https://learn.microsoft.com/en-us/dotnet/framework/windows-services/how-to-install-and-uninstall-services

### Comentarios sobre el servicio. 

    El servicio, siguiendo estos pasos no funciona, ya que por temas de seguridad de windows. 
    Revisando la documentación intenté solucionar estos problemas sin éxito. 
    Para mayor referencia consulte 
    https://learn.microsoft.com/es-es/troubleshoot/windows-server/system-management-components/service-startup-permissions

### Comentarios finales

    Este proyecto me gustó muchísimo, no sabía que era tan sencillo crear un servicio en windows, definitivamente creo que es la clase de proyecto que todo programador debe tener en su stack. Muchas gracias por esta experiencia. 

#### ¿Que pudiera mejorar si tuviera más tiempo? 

    Crearía más funciones en la base de datos para que el backend no se encargue por ejemplo de quitar los caracteres "-->" así en caso de que un programador despistado no los quite los datos se guarden correctamente. 

    Tabién investigaría más sobre estos temas de seguridad al momento de acceder a bases de datos desde un servico. 

#### ¿Con que enseñanzas me quedo?

    En lo personal, al leer la práctica penspe que sería algo muy complicado, sonaba muy dificil todo, programas que no conocía como "TortoiseSvn" que a final de cuentas fué sencillo de manejar. 
    Tampoco sabía como crear un servicio, pero investigando un poco encontré esta documentación y a partir de aquí todo fueron problemas que ya había resulto antesc como manejar strings y manejar archivos desde c#.
    La moraleja es "no te rindas antes de dar la pelea"

#### ¿Que me faltó hacer?

    Me faltó hacer la API no porque no sepa, no entendí el propósito de esta. ¿Debe crear un ticket y guardarlo en la carpeta de ReadyToProcess?

    También me dí cuenta que necesito repasar mi SQL, el procedimiento almacenado fué lo que más tiempo me tomó. No entendía su funcionamiento. 

#### Extras

    También hice un pequeño scrpt en python para poder hacer muchas prubas facilmente, este escript cambiaba el nombre de los archivos con error, los regresaba a ready to process y limpiaba la base de datos. 
    Esto me permitía ejecutar muchas pruebas en cuastión de segundos solo presionando un botón. 