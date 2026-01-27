using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2_T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacion;
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Elige el tipo de operacion que quieres hacer;");
                Console.WriteLine("1-Numerica / 2-Logicas / 3-Cadenas / 0=salir");
                //Permite capturar lo que se escribe por teclado y deja en la variable operacion
                //En este caso tambien utilizamos una conversion personalizada de tipo String a Int
                operacion = Convert.ToInt32(Console.ReadLine());
                switch (operacion)
                {
                    case 1:
                        Console.WriteLine("1-Numerica");
                        //EJERCICIO 1
                        Console.Write("Introduce el primer operando : ");
                        double a= Convert.ToSingle(Console.ReadLine());
                        Console.Write("Introduce el segundo operando : ");
                        double b = Convert.ToSingle(Console.ReadLine());
                        double resultado;
                        //MALdouble resultado = Convert.ToSingle(Console.ReadLine());

                        resultado = a + b;
                        Console.WriteLine("Suma; " + resultado);

                        resultado = a - b;
                        Console.WriteLine("Resta; " + resultado);

                        resultado = a / b;
                        Console.WriteLine("Division; " + resultado);

                        resultado = a * b;
                        Console.WriteLine("Multiplicacion ; " + resultado);

                        resultado = a % b;
                        Console.WriteLine("Resto; " + resultado);

                        resultado = a++;
                        //Asigna la variable a a resultado y luego incrementa a en un
                        Console.WriteLine("Incremento a primer operando ;" +a);
                        Console.WriteLine("Resultado:"+ resultado);

                        resultado = a--;
                        //Asigna la variable a a resultado y luego decrementa a en un
                        Console.WriteLine("Decremento a primer operando ;" + a);
                        Console.WriteLine("Decremento:" + resultado);
                        // lo mismo para b 
                        resultado = b++;
                        //Asigna la variable a a resultado y luego incrementa a en un
                        Console.WriteLine("Incremento a segundo operando ;" + b);
                        Console.WriteLine("Resultado:" + resultado);

                        resultado = b--;
                        //Asigna la variable b a resultado y luego decrementa a en un
                        Console.WriteLine("Decremento b ;" + b);
                        Console.WriteLine("Resultado:" + resultado);
                        // lo mismo para b 
                        break;

                    case 2:
                        Console.WriteLine("2-Logicas");
                        //EJERCICIO 2
                        int c = 2;
                        int d = 5;

                        Console.WriteLine("c es mayor que d: " + (c > d));
                        Console.WriteLine("c es menor o igual que d: " + (c <= d));
                        Console.WriteLine("c es mayor o igual que d: " + (c >= d));
                        Console.WriteLine("c es igual a d: " + (c == d));
                        Console.WriteLine("c es distinto de d: " + (c != d));
                        Console.WriteLine("c es mayor que d o c es menor que d: " + (c > d || c < d));
                        Console.WriteLine("2*c es mayor que d y c es menor que d: " + (2 * c > d && c < d));

                        /*Su manera es;
                         * Console.Write("Introduce el primer operando entero (c); ");
                        int c = Convert.ToInt32(((Console.ReadLine)));
                        Console.Write("Introduce el segundo operando entero (d); ");
                        int d = Convert.ToInt32(((Console.ReadLine)));
                        float d =Convert.ToInt32(Console.ReadLine());
                        bool resultado2 = false;
                        //c>d
                        resultado2 = c>d;
                       Console.WriteLine("c es mayor que d;" + resultado2);
                        //c<d
                        resultado2 = c<d;
                       Console.WriteLine("c es menor que d;" + resultado2);
                        //c>=d
                        resultado2 = c>=d;
                       Console.WriteLine("c es mayor o igual que d;" + resultado2);
                        //c==d
                        resultado2 = c==d;
                       Console.WriteLine("c es igual que d;" + resultado2);
                        //c!=d
                        resultado2 = c!=d;
                       Console.WriteLine("c es distinto que d;" + resultado2);

                        //c es mayor que d o c es menor que d
                        resultado2 = c>d || c<d;
                        Console.WriteLine("c es mayor que d;" + resultado2);
                        //2*c es mayor que d y c es menor que d
                        resultado2 = 2*c>d & c<d;
                        Console.WriteLine("c es mayor que d;" + resultado2);

                        */

                        break;

                    case 3:
                        Console.WriteLine("3-Cadenas");
                        //EJERCICIO 3




                        //RELLENAR
                        break;
                    case 0:
                        Console.WriteLine("Bye bye");
                        salir = true;
                       break;
                        default:
                        Console.WriteLine("No se selecciono ninguna operacion");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
