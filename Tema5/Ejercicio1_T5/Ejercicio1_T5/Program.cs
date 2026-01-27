using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio1_T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool llueve = false;
            bool paraguas = false;
            Console.WriteLine("EJERCICIO 1");
            Console.WriteLine("¿Está lloviendo?");
            Console.WriteLine("Sí(s) / No(n)");
            String conllueve = Console.ReadLine();
            //Comprobar si llueve. En el caso de que llueva, añadir la siguiente línea
            if (conllueve == "s" || conllueve == "S") { 
                llueve = true;
            }
            Console.WriteLine("¿Tienes paraguas?");
            Console.WriteLine("Sí/No");
            String conparaguas = Console.ReadLine();

            //Comprobar si hay paraguas
        }
    }
}
