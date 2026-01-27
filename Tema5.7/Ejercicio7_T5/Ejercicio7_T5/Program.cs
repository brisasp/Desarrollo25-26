using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            string cadena;

            // 1. Mostrar los números pares del 0 al 100 separados por guiones
            for (i = 0; i <= 100; i += 2)
            {
                if (i < 100)
                    Console.Write(i + "-");
                else
                    Console.Write(i);
            }

            Console.WriteLine(); // Salto de línea después de los números

            // 2. Pedir la cadena y el número de repeticiones
            Console.Write("Dime la cadena que debo repetir: ");
            cadena = Console.ReadLine();

            Console.Write("Cuántas veces debo repetir la cadena: ");
            num = Convert.ToInt32(Console.ReadLine());

            // 3. Repetir la cadena n veces en la misma línea sin guion final
            for (i = 0; i < num; i++)
            {
                if (i < num - 1)
                    Console.Write(cadena + "-");
                else
                    Console.Write(cadena);
            }

            Console.WriteLine(); // salto de línea final
            Console.WriteLine("\nPulsa una tecla para salir...");
            Console.ReadKey();
        }
    }
}