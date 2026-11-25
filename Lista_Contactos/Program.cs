namespace Lista_Contactos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contacto> contactos = new List<Contacto>();
            int opcion = 0;

            Console.WriteLine("Bienvenido al directorio de contactos");
            Console.WriteLine("A continuación observe el menú de opciones: ");
            Console.WriteLine("");
            do
            {
                Console.WriteLine("==== MENÚ DE OPCIONES ====");
                Console.WriteLine("1. Añadir contacto");
                Console.WriteLine("2. Ver contactos");
                Console.WriteLine("3. Buscar por nombre");
                Console.WriteLine("4. Eliminar contacto");
                Console.WriteLine("5. Salir");
                Console.WriteLine("===========================");

                Console.WriteLine("");
                Console.Write("Opción: ");

        while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
       {
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("Error: Por favor ingresa una opción dentro del rango 1 a 5.");
           Console.WriteLine("");
           Console.Write(">>: ");
           Console.ResetColor();
       }
     Console.Clear();

                switch (opcion)
                {
                    case 1:
                        long telefono = 0;
                        string nombre = "", email = "";

                        Console.WriteLine("===== AÑADIR CONTACTO =====");
                        Console.WriteLine("Por favor, ingresa el nombre del contacto: ");
                        Console.Write(">>: ");
                        nombre = Console.ReadLine() ?? "";

                        while (string.IsNullOrWhiteSpace(nombre) || !nombre.All(c => char.IsLetter(c) || c == ' '))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error: Ingrese un nombre válido (solo letras y espacios, no vacío).");
                            Console.Write(">>: ");
                            Console.ResetColor();
                            nombre = Console.ReadLine() ?? "";
                            Console.ResetColor();
                        }

                        Console.WriteLine("");
                        Console.WriteLine("===== NÚMERO DE TELÉFONO =====");
                        Console.WriteLine("Por favor, ingresa el número de teléfono del contacto: ");

                        while (true)
                        {
                            Console.Write(">>: ");
                            if (!long.TryParse(Console.ReadLine(), out telefono) || telefono <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Valor inválido. Ingrese un número positivo: ");
                                Console.ResetColor();
                                continue;

                            }


                            if (contactos.Exists(c => c.Telefono == telefono))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("El número de teléfono ya existe. Ingrese un número diferente: ");
                                Console.ResetColor();
                                continue;


                            }

                            break;
                        }
                        Console.WriteLine("");


                        Console.WriteLine("===== CORREO ELECTRÓNICO =====");
                        Console.WriteLine("Por favor, ingresa el correo electrónico del contacto: ");
                        Console.Write(">>: ");
                        email = Console.ReadLine() ?? "";


                        while (string.IsNullOrEmpty(email) || !email.Contains("@"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("El correo electrónico no es válido.");
                            Console.Write(">>: ");
                            email = Console.ReadLine() ?? "";
                            Console.ResetColor();
                            Console.WriteLine("");
                        }

                        contactos.Add(new Contacto(nombre, telefono, email));

                        

                        Console.WriteLine("");
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Contacto añadido correctamente.");
                        Console.WriteLine("");
                        Console.ResetColor();

                        break;

                    case 2:    
                        Console.WriteLine("LISTA DE CONTACTOS");
                        Console.WriteLine("======================");
                        if (contactos.Count > 0)
                        {
                            foreach (Contacto c in contactos)
                            {
                                c.MostrarContacto();
                                Console.WriteLine("");
                            }
                           Console.WriteLine("====================="); 
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("No hay contactos en la lista.");
                            Console.ResetColor();
                            Console.WriteLine("");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Búsqueda por nombre: ");
                        string nombreBusqueda = Console.ReadLine() ?? "";

                        var contactoEncontrado = contactos.Find(c => c.Nombre.Equals(nombreBusqueda, StringComparison.OrdinalIgnoreCase));

                        if (contactoEncontrado != null)
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                            contactoEncontrado.MostrarContacto();
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Contacto no encontrado.");
                            Console.ResetColor();
                            Console.Clear();
                            Console.WriteLine("");
                        }
                        break;

                    case 4:
                        {
                            Console.WriteLine("===== ELIMINAR CONTACTO =====");
                            Console.WriteLine("Escribe el nombre del contacto a eliminar.");
                            nombre = Console.ReadLine() ?? "";

                            while (string.IsNullOrWhiteSpace(nombre) || !nombre.All(c => char.IsLetter(c) || c == ' '))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Error: Ingrese un nombre válido (solo letras y espacios, no vacío).");
                                Console.ResetColor();
                                nombre = Console.ReadLine() ?? "";
                                Console.ResetColor();
                            }

                            if (contactos.Exists(n => n.Nombre == nombre))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                contactos.RemoveAll(c => string.Equals(c.Nombre?.Trim(), nombre.Trim(), StringComparison.OrdinalIgnoreCase));
                                Console.WriteLine("Contacto eliminado correctamente.");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Contacto no encontrado.");
                                Console.ResetColor();
                                Console.Clear();
                            }
                        }
                        break;

                    default:

                        Console.WriteLine("Opción no válida. Por favor, ingresa un número del 1 al 5.");
                        break;

                }

            } while (opcion != 5);

            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Muchas gracias por usar el directorio telefónico.");
            Console.WriteLine("Hasta la próxima.");
        }
    }
}
