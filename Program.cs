using System;

namespace consolaactividad
{
    class Program
    {
        static void Main(string[] args)
        {
            string miNombre, miApellido;

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("----- REGISTRO DE CLIENTE -----");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Por favor, escriba su nombre");
            miNombre = Console.ReadLine( );
            Console.WriteLine("Tu nombre es {0}", miNombre);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkGreen; 
            Console.WriteLine("Por favor, escriba su apellido");
            miApellido = Console.ReadLine( );
            Console.WriteLine("Tu Apellido es {0}", miApellido); 
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkBlue; 
            Console.WriteLine("Tu nombre completo es {0}", miNombre + " " + miApellido); 
        }
    }
}
