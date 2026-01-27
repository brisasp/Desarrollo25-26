using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8_T7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Elige opcion");
                Console.WriteLine("1. Números pares");
                Console.WriteLine("2. Eliminar vocales");
                Console.WriteLine("3. Comida");
                Console.WriteLine("0. Salir");

                int opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:

                        ContarPares();
                        break;
                    case 2:
                        EliminarVocales();
                        break;
                    case 3:
                        ComidaAsync().Wait(); // Esperamos a que termine la tarea async
                        break;
                    case 0:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.\n");
                        break;
                }
            }

            Console.WriteLine("Programa finalizado.");
        }

        // ----------------------------------------
        // Apartado 1: NÚMEROS PARES
        // ----------------------------------------

        static int[] NumerosPares(int n)
        {
            int[] resultado = new int[(n / 2) + 1];
            int i = 0;
            for (int j = 0; j <= n; j++)
            {
                if (j % 2 == 0)
                {
                    resultado[i] = j;
                    i++;
                }
            }
            return resultado;
        }

        static int[] NumerosPares()
        {
            return NumerosPares(100);
        }

        static void ContarPares()
        {
            Console.Write("Indica hasta qué número quieres obtener números pares: ");
            int resp = Convert.ToInt32(Console.ReadLine());

            int[] pares = NumerosPares(resp);
            Console.WriteLine($"Los números pares hasta {resp} son:");

            string salida = "(" + pares[0];
            for (int i = 1; i < pares.Length; i++)
            {
                salida += ", " + pares[i];
            }
            salida += ")";
            Console.WriteLine(salida + "\n");
        }

        // ----------------------------------------
        // Apartado 2: ELIMINAR VOCALES
        // ----------------------------------------

        static void EliminarVocales()
        {
            Console.Write("Introduce una palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine("Palabra original: " + palabra);

            EliminarVocales(ref palabra);

            Console.WriteLine("Palabra sin vocales: " + palabra + "\n");
        }

        static void EliminarVocales(ref string palabra)
        {
            string cadena = palabra.ToUpper();
            string sinvocales = "";

            for (int i = 0; i < palabra.Length; i++)
            {
                switch (cadena.Substring(i, 1))
                {
                    case "A":
                    case "E":
                    case "I":
                    case "O":
                    case "U":
                        break;
                    default:
                        sinvocales += palabra.Substring(i, 1);
                        break;
                }
            }

            palabra = sinvocales;
        }

        // ----------------------------------------
        // Apartado 3: COMIDA (Métodos asíncronos)
        // ----------------------------------------

        static async Task ComidaAsync()
        {
            //Console.WriteLine("Ofreciendo comida...");
            string result = await BuscarComidaAsync();
            Console.WriteLine(result);
            Console.WriteLine("¿Te apetece comer algo?");
            Console.WriteLine();
        }

        static async Task<string> BuscarComidaAsync()
        {
            await Task.Delay(3000); // Espera simulada de 3 segundos
            return "He traído esto de la nevera.";
        }
    }
}