using System.Text.Json.Serialization;
class Contacto
    {
        [JsonInclude]
        public string Nombre { get; private set; }
        [JsonInclude]
        public long Telefono { get; private set; }
        [JsonInclude]
        public string Email { get; private set; }

        public Contacto(string nombre, long telefono, string email)
        {
            this.Nombre = nombre;
            this.Telefono = telefono >= 0 ? telefono : 0;
            this.Email = email;
        }

        public void MostrarContacto()
        {
         
            Console.WriteLine("Información del contacto:");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Teléfono: " + Telefono);
            Console.WriteLine("Correo electrónico: " + Email);
        }

        [JsonConstructor]
        public Contacto ()=> Nombre = string.Empty;

    }