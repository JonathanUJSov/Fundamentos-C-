using System;

namespace CoreEscuela
{
    class escuela{
        public string nombre;
        public string direccion;
        public escuela(String nombre, String direccion){
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public void Timbrar(){
            Console.Beep(2000, 3000); //Timbrar a 10000Hz durante 3000 ms
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var miEscuela = new escuela("Prueba", "Dirección de la escuela");
            Console.WriteLine(miEscuela.nombre);
            Console.WriteLine(miEscuela.direccion);
            miEscuela.Timbrar();
        }
    }
}
