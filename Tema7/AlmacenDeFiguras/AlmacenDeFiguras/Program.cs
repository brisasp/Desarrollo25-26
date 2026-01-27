using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmacenDeFiguras
{
    internal class Program
    {
        //clase triangulo
        class Triangulo
        {

            //Campos
            private float t_base;
            private float t_altura;
            private string t_color;
            private float t_area;

            //Propiedades
            public float T_base
            {
                get => t_base;
                set => t_base = value;
            }
            public float T_altura
            {
                get => t_altura;
                set => t_altura = value;
            }
            public string T_color
            {
                get => t_color;
                set => t_color = value;
            }
            public float T_area
            {
                get => t_area;
                set => t_area = value;
            }

            //Constructores
            //Constructor vacio
            public Triangulo()
            {
                T_base = 2;
                T_altura = 4;
                T_color = "verde";
                T_area = CalcularArea(T_base,T_altura);

            }
            public Triangulo(float p_base, float p_altura)
            {
                T_base = p_base;
                T_altura = p_altura;
                T_color = "verde";
                T_area = CalcularArea(T_base,T_altura);

            }

            //Metodos
            public float CalcularArea(float p_base, float p_altura)
            {
                return (p_base * p_altura) / 2;

            }

        }

        public class Circulo {
            private float c_radio;
            private float c_area;
            private string c_color;

            public float C_radio { get => c_radio; set => c_radio = value; }
            public float C_area { get => c_area; set => c_area = value; }
            public string C_color { get => color; set => color = value; }

            //Constructor
            public Circulo() {
                C_radio = 2;
                C_color = "verde";
                C_area = CalcularArea(C_radio);
            }

            public float CalcularArea(float p_radio) {
                return Convert.ToInt32(Math.PI* p_radio * p_radio) / 2;
            
            
            }


        }


            static void Main(string[] args)
            {
            }
        }
   }

