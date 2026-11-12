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
- ✅ Eliminar un contacto   

🛠️ Tecnologías:

- Lenguaje: C#
- Plataforma: .NET 10.0 o superior 
- Compilador:`dotnet`, VS Code con extensión C#

📦 Requisitos previos

- [.NET SDK](https://dotnet.microsoft.com/download) (10.0 o superior)
- [Visual Studio Code](https://code.visualstudio.com/) con extensión C#


▶️ Cómo ejecutar:

Con Visual Studio Code / terminal:
``` bash
git clone https://github.com/JuTevan25/CeluAgenda.git
cd CeluAgenda
dotnet run
```

- GitHub: https://github.com/JuTevan25
- Autor: Juan Esteban Venegas Torres

## Estructura

- Program.cs: Menú e interacción con el usuario.
- Contacto.cs: Lógica para mostrar el contacto agregado.