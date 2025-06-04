# MedievalEmpires
Proyecto de videojuego web creado como práctica del curso de Desarrollo de Aplicaciones Web (DAW).

## Propósito
Este repositorio contiene el código de un juego de estrategia centrado en la gestión de imperios medievales. El proyecto está escrito en Visual Basic sobre ASP.NET y sirve como ejemplo de aprendizaje para trabajar con modelos de usuario, autenticación y lógica de combate entre ejércitos.

## Funcionalidades principales
- Gestión de tres imperios (Romanos, Teutones y Galos), cada uno con su propio listado de unidades.
- Compra de soldados (Caballeros, Caballería y Arqueros) utilizando el oro del imperio.
- Métodos para calcular el daño y la defensa total de cada ejército.
- Sistema de usuarios que permite comprobar credenciales y asociar cada cuenta a un imperio concreto.
- Conjunto de pruebas unitarias con MSTest para verificar la lógica de compra de soldados.

## Instalación y ejecución
El proyecto está orientado al framework .NET 4.5.2 y puede compilarse en los sistemas operativos más comunes.

### Windows
1. Instalar [Visual Studio](https://visualstudio.microsoft.com/) (2015 o superior).
2. Clonar este repositorio y abrir el archivo `MedievalEmpires.sln`.
3. Restaurar los paquetes NuGet y compilar la solución.
4. Ejecutar el proyecto desde Visual Studio.

### Linux y macOS
1. Instalar [Mono](https://www.mono-project.com/) y las herramientas `msbuild` y `nuget`.
   - En distribuciones Debian/Ubuntu: `sudo apt-get install mono-complete nuget`.
2. Restaurar las dependencias:
   ```bash
   nuget restore MedievalEmpires.sln
   ```
3. Compilar la solución con `msbuild`:
   ```bash
   msbuild MedievalEmpires.sln
   ```
4. Ejecutar la aplicación web con un servidor compatible con ASP.NET para Mono, como `xsp4`:
   ```bash
   xsp4 --port 8080 -root MedievalEmpires
   ```
5. Acceder a `http://localhost:8080` desde el navegador.

## Licencia
Este juego se distribuye bajo los términos de la licencia GNU General Public License v3. Consulta el fichero de licencia para más detalles.
