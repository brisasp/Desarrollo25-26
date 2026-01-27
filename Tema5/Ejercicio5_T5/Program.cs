using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numero;
            int respuesta;
            Console.WriteLine("Generando número");

            // Genera un número aleatorio
            numero = random.Next(100);
            Console.WriteLine("¿Serás capaz de averiguarlo?");
            Console.WriteLine("ESCRIBE UN NUMERO");
            respuesta = Int32.Parse(Console.ReadLine());
            while (respuesta != numero)
            {
                Console.WriteLine("Lo siento no has acertado");
                if (respuesta < numero) {
                    Console.WriteLine("El numero que buscas es mayor");
                }
                if (respuesta > numero)
                {
                    Console.WriteLine("El numero que buscas es menor");
                }
                Console.WriteLine("Escribe otro numero");
                respuesta = Int32.Parse(Console.ReadLine());
            }
            // LÓGICA DEL JUEGO
            // RELLENAR
            Console.WriteLine("¡¡Correcto!! Acertaste");
            Console.ReadKey();
        }
    }
}
