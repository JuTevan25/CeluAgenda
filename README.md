📒 CeluAgenda - Directorio para tus contactos

Aplicación de consola en C# que permite gestionar una lista de contactos. 

Incluye funcionalidades para agregar, listar, buscar por nombre y persistir los datos en un archivo JSON. Con el objetivo de brindar la capacidad de tener tus contactos por orden y buscar sin mayor dificultad.

🚀 Características

- ✅ Agregar contactos con nombre, teléfono y correo electrónico.
- ✅ Validaciones robustas:
  - Nombre: solo letras y espacios, no vacío.
  - Teléfono: número positivo, no duplicado.
  - Correo: no vacío y debe contener "@".
- ✅ Listar todos los contactos almacenados.
- ✅ Buscar contacto por nombre (insensible a mayúsculas/minúsculas).
- ✅ Persistencia automática en archivo JSON (`directorio.json`).
- ✅ Menú interactivo con manejo de errores.
- ✅ Colores en consola para mejorar la experiencia visual.

🛠️ Tecnologías:

- Lenguaje: C#
- Plataforma: .NET 6.0 o superior (compatible con .NET 8, 9, 10)
- Compilador:`dotnet`, Visual Studio, VS Code con extensión C#

## 📦 Requisitos previos

- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 o superior)
- [Visual Studio Community](https://visualstudio.microsoft.com/) o [Visual Studio Code](https://code.visualstudio.com/) con extensión C#

⁉️ ¿Cómo encontrar la carpeta donde se aloja el código?
- En carpeta llamada "Lista_Contactos" deslizas hacia abajo.
- El archivo llamado "Program.cs" das doble click y aparece el código.

▶️ Cómo ejecutar:

Opción 1: Con Visual Studio

1. Clona el repositorio
- git clone https://github.com/JuTevan25/DirectorioContactos.git
- cd DirectorioContactos
- dotnet run

2. Crea un nuevo proyecto de Aplicación de consola (.NET).
3. Insertar el código en `Program.cs`.
4. Presiona `F5` o haz clic en Iniciar.

Opción 2: Con terminal y ejecutar 'dotnet'

```bash
Clona el repositorio (o descarga el archivo .cs):
git clone https://github.com/JuTevan25/CeluAgenda.git
cd CeluAgenda
dotnet run

Github: https://github.com/JuTevan25
Autor: Juan Esteban Venegas Torres