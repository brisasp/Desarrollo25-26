
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Persona
    {
        // Atributos públicos
        public string Nombre;
        public string Apellido;
        public int Edad;

        // Campo Random compartido para evitar repetición de números
        private static Random numAleatorio = new Random();

        // Constructor con parámetros
        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        // Constructor sin parámetros (persona aleatoria)
        public Persona()
        {
            Nombre = NombreRandom();
            Apellido = ApellidoRandom();
            Edad = numAleatorio.Next(1, 100);
        }

        // Métodos para obtener nombre y apellido aleatorios
        private string NombreRandom()
        {
            string[] listadoNombres = { "Pepe", "Paco", "Jose", "Juan", "Andrés", "Raúl", "Pablo", "Carlos" };
            int i = numAleatorio.Next(listadoNombres.Length);
            return listadoNombres[i];
        }

        private string ApellidoRandom()
        {
            string[] listadoApellidos = { "Ruiz", "López", "Sáez", "Martínez", "Navarro", "Fernández", "Núñez", "Pérez" };
            int i = numAleatorio.Next(listadoApellidos.Length);
            return listadoApellidos[i];
        }

        // Sobrescritura de ToString()
        public override string ToString()
        {
            return $"{Nombre} {Apellido}, {Edad} años";
        }
    }

    class Program
    {
        private static Random numAleatorio = new Random();

        static void Main(string[] args)
        {
            // Creamos 5 personas manualmente
            Persona p1 = new Persona("José", "Sanz", 34);
            Persona p2 = new Persona("Andrés", "Ruiz", 40);
            Persona p3 = new Persona("Sara", "Martínez", 60);
            Persona p4 = new Persona("Sonia", "López", 37);
            Persona p5 = new Persona("Pepe", "Vázquez", 50);

            // Creamos el array de personas
            Persona[] personas = { p1, p2, p3, p4, p5 };

            // Mostramos la persona con mayor edad
            Persona mayor = PersonaMayor(personas);
            Console.WriteLine("La persona con mayor edad es:");
            Console.WriteLine(mayor);

            // Creamos 5 personas aleatorias y las añadimos al array
            Persona[] personasAleatorias = new Persona[5];
            for (int i = 0; i < personasAleatorias.Length; i++)
            {
                personasAleatorias[i] = new Persona();
            }

            // Unimos ambas listas
            List<Persona> listaTotal = new List<Persona>();
            listaTotal.AddRange(personas);
            listaTotal.AddRange(personasAleatorias);

            // Creamos un diccionario <Persona, int> (nº hijos)
            Dictionary<Persona, int> dicConHijos = CrearDiccionario(listaTotal.ToArray());

            Console.WriteLine("\n--- Diccionario de personas con hijos ---");
            foreach (var kvp in dicConHijos)
            {
                Console.WriteLine($"{kvp.Key} - Nº hijos: {kvp.Value}");
            }

            // Eliminamos las personas con 0 hijos
            var dicFiltrado = EliminaHijos0(dicConHijos);

            Console.WriteLine("\n--- Diccionario tras eliminar los que no tienen hijos ---");
            foreach (var kvp in dicFiltrado)
            {
                Console.WriteLine($"{kvp.Key} - Nº hijos: {kvp.Value}");
            }

            // Creamos el array bidimensional con los padres e hijos
            Persona[,] arrayConHijos = CrearArrayConHijos(dicFiltrado);

            Console.WriteLine("\n--- Array con padres e hijos ---");
            for (int i = 0; i < arrayConHijos.GetLength(0); i++)
            {
                Console.Write($"{arrayConHijos[i, 0]} -> Hijos: ");
                for (int j = 1; j < arrayConHijos.GetLength(1); j++)
                {
                    if (arrayConHijos[i, j] != null)
                        Console.Write($"{arrayConHijos[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPulsa cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método que devuelve la persona con mayor edad
        static Persona PersonaMayor(Persona[] personas)
        {
            Persona mayor = personas[0];
            foreach (Persona p in personas)
            {
                if (p.Edad > mayor.Edad)
                    mayor = p;
            }
            return mayor;
        }

        // Crea un diccionario de personas mayores de 18 con número aleatorio de hijos
        static Dictionary<Persona, int> CrearDiccionario(Persona[] personas)
        {
            Dictionary<Persona, int> dic = new Dictionary<Persona, int>();

            foreach (Persona p in personas)
            {
                if (p.Edad > 18)
                {
                    int hijos = numAleatorio.Next(0, 5); // 0 a 4 hijos
                    dic.Add(p, hijos);
                }
            }

            return dic;
        }

        // Elimina las personas con 0 hijos
        static Dictionary<Persona, int> EliminaHijos0(Dictionary<Persona, int> dic)
        {
            Dictionary<Persona, int> nuevoDic = new Dictionary<Persona, int>();

            foreach (var kvp in dic)
            {
                if (kvp.Value > 0)
                    nuevoDic.Add(kvp.Key, kvp.Value);
            }

            return nuevoDic;
        }

        // Crea un array bidimensional de personas con sus hijos
        static Persona[,] CrearArrayConHijos(Dictionary<Persona, int> dicConHijos)
        {
            Persona[,] arrayConHijos = new Persona[dicConHijos.Count, 5];
            int contador = 0;

            foreach (var kvp in dicConHijos)
            {
                Persona padre = kvp.Key;
                int numHijos = kvp.Value;

                arrayConHijos[contador, 0] = padre;

                for (int i = 1; i <= numHijos && i < 5; i++)
                {
                    arrayConHijos[contador, i] = new Persona(); // hijo aleatorio
                }

                contador++;
            }

            return arrayConHijos;
        }
    }
}