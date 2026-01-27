using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alumno;
            Double n1, n2, n3, n4, promedio;

            //INTRODUCCION DE DATOS
            Console.WriteLine("-------PROMEDIO DE NOTAS---------");
            Console.WriteLine("Introduzca el nombre del alumno");
            alumno = Console.ReadLine();
            Console.Write("Introduzca nota 1 :");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca nota 2 :");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca nota 3 :");
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduzca nota 4 :");
            n4 = Convert.ToDouble(Console.ReadLine());
            //CALCULO PROMEDIO
            promedio = (n1 + n2 + n3 + n4) / 4;
            //la forma en que lo hace ella si el peso de cada nota no es el mismo
            //promedio = n1 * 0.1 + n2 * 0.2 + n3 * 0.3 + n4 * 0.4;

            Console.WriteLine("------------------------");
            Console.WriteLine("ALUMNO : " + alumno);
            Console.WriteLine("NOTA 1 | NOTA 2 | NOTA 3 | NOTA 4");
            //la forma como lo hace ella
            //Console.WriteLine(n1.ToString("0.00") + "\t" + n2.ToString("0.00") + "\t" +
                               // n3.ToString("0.00") + "\t" + n4.ToString("0.00"));
            Console.WriteLine($"{n1,6:F2} | {n2,6:F2} | {n3,6:F2} | {n4,6:F2}");
            Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("PROMEDIO: " + promedio.ToString("0.00"));
            Console.WriteLine($"PROMEDIO: {promedio,5:F2}");
            Console.WriteLine("---------------------------------------------------");

            Console.ReadKey();
        }
    }
}
