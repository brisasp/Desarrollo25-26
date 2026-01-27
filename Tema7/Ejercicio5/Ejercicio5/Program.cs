using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        public static int[] Multiplos(int p_numero)
        {
            int[] p_multiplos = new int[15];
            for (int i = 1; i <= 15; i++)
            {
                p_multiplos[i - 1] = p_numero * i;
            }
            return p_multiplos;
        }

        public static bool Multiplos(int p_numero1, int p_numero2)
        {
            if (p_numero2 % p_numero1 == 0)
                return true;
            else
                return false;
        }

        static void Main()
        {
            // --- Parte 1 ---
            Console.Write("Indica un número: ");
            int resp = Convert.ToInt32(Console.ReadLine());
            int[] v_multiplos = Multiplos(resp);

            Console.Write("Los 15 primeros múltiplos del número " + resp + " son: ");
            for (int i = 0; i < v_multiplos.Length; i++)
            {
                Console.Write(v_multiplos[i]);
                if (i < v_multiplos.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("\n");

            // --- Parte 2 ---
            Console.WriteLine("Ahora vamos a comprobar si dos números son múltiplos:");
            Console.Write("Indica un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indica otro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            bool son_multiplos = Multiplos(num1, num2);
            if (son_multiplos)
                Console.WriteLine($"El número {num2} es múltiplo del número {num1}.\n");
            else
                Console.WriteLine($"Los números {num1} y {num2} no son múltiplos.\n");

            // --- Ampliación ---
            Console.Write("Indica un número (como texto): ");
            string v_variable = Console.ReadLine();
            int v_num = Int32.Parse(v_variable);
            double v_double = v_num;

            Console.WriteLine("Conversión explícita. Número: " + v_num);
            Console.WriteLine("Conversión implícita. Número: " + v_double);
        }
    }
}