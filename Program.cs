using System;

namespace consolaactividad
{
    class Program
    {
        static void Main(string[] args)
        {
            string miNombre;
            Console.WriteLine("Por favor, escriba su nombre");
            miNombre = Console.ReadLine( );
            Console.WriteLine("Hola {0}", miNombre); 
        }
    }
}
