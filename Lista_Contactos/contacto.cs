class Contacto
    {
        public string nombre { get; set; }
        public long telefono { get; set; }

        public string email { get; set; }

        public Contacto(string nombre, long telefono, string email)
        {
            this.nombre = nombre;
            this.telefono = telefono >= 0 ? telefono : 0;
            this.email = email;
        }

        public void MostrarContacto()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Teléfono: " + telefono);
            Console.WriteLine("Correo electrónico: " + email);

        }


    }