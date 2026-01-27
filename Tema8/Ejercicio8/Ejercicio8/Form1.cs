using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        //Constantes
        private readonly string[] categorias = { "Superacion personal", "Literatura" , "Ciencias" , "Informatica"};
        private readonly string[] editoriales = { "Anagrama", "Asteroide" , "Garceta" , "Malpaso", "Marcombo", "Planeta" , "RA-MA" , "Seix Barral" };

        //CAMPOS
        Dictionary<string, int> dcCategorias;
        Dictionary<string, double> dcCosteAcumulado;
        List<Libro> libros;

        //COMPLETAR

        //es una estructura
        public struct Libro
        {
            public string Titulo { get; set; }
            public string Editorial { get; set; }
            public string Categoria { get; set; }
            public int Paginas { get; set; }
            public int Edicion { get; set; }
            public double Coste { get; set; }

            //constructor
            public Libro(string titulo, string editorial, string categoria, int edicion, int paginas, double coste)
            {
                Titulo = titulo;
                Editorial = editorial;
                Categoria = categoria;
                Edicion = edicion;
                Paginas = paginas;
                Coste = coste;
            }
        }

        //metodos
        public Form1()
        {
            InitializeComponent();
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            libros = new List<Libro>();
            inicializarDiccionarios();
            inicializarComponentes();

        }

        //Inicializa los componentes del formulario
        private void inicializarComponentes() {
            //evitamos que el formuario se haga mas grande
            MaximizeBox = false;
            //ponemos el foco en el titulo
            txtTitulo.Focus();

            //INICIALIZAMOS LISTVIEW esto lo hemos hecho desde el propio diseño, son estas propiedades
            //lstvLibros.GridLines = true;
            //lstvLibros.View = View.Details;

            //Añadimos las columnas, -2 indica auto-size
            lstvLibros.Columns.Add("TITULO", -2, HorizontalAlignment.Center);
            lstvLibros.Columns.Add("EDITORIAL", -2, HorizontalAlignment.Center);
            lstvLibros.Columns.Add("CATEGORIA", -2, HorizontalAlignment.Center);
            lstvLibros.Columns.Add("EDICION", -2, HorizontalAlignment.Center);
            lstvLibros.Columns.Add("PAGINAS", -2, HorizontalAlignment.Center);
            lstvLibros.Columns.Add("COSTE", -2, HorizontalAlignment.Center);
            
            //Inicializamos los comboBox
            comboBox1.Items.AddRange(categorias);
            cmbEditorial.Items.AddRange(editoriales);

            comboBox1.SelectedItem = comboBox1.Items[0];
            cmbEditorial.SelectedItem = comboBox1.Items[0];
        }

        //Crea y rellena los diccionarios con los datos iniciales
        private void inicializarDiccionarios() {
            dcCategorias= new Dictionary<string, int>();
            dcCosteAcumulado = new Dictionary<string, double>();

            //Rellenamos los dicccionarios con datos
            for (int i = 0; i<categorias.Length; i++) {
                dcCategorias.Add(categorias[i], 0);
            
            }
            for (int i = 0; i < editoriales.Length; i++)
            {
                dcCosteAcumulado.Add(editoriales[i], 0);

            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            if (!titulo.Equals(""))
            {
                try
                {
                    Double coste = double.Parse(txtCoste.Text.Trim());
                    int paginas = int.Parse(txtPaginas.Text.Trim());
                    int edicion = int.Parse(txtAñoEdicion.Text.Trim());
                    string editorial = (string)cmbEditorial.SelectedItem;
                    string categoria = (string)comboBox1.SelectedItem;

                    //Los campos son correctos y creamos el struct
                    Libro libro = new Libro(titulo, editorial, categoria, edicion, paginas, coste);
                   //añadimos al ListView
                    insertarLibro(libro);
                    //Actulizamos la info de los diccionarios
                    actualizarDatos(libro);
                    //Se ha añadido al ListView, limpiamos los campos
                    limpiar();
                    //Actualizamos la ListBox
                    rellenarListBox();

                }
                catch (Exception ex) { }



            }
        }

        private void rellenarListBox() {
        //LIMPIAMOS EL LISTBOX
        lstEstadistica.Items.Clear();
        //eSCRIBIMOS LA NUEVA INFO
        lstEstadistica.Items.Add("--ESTADISTICA DE REGISTRO DE LIBROS--");
        lstEstadistica.Items.Add("NUMERO DE LIBROS POR CATEGORIA:");
        //RECORREMOS EL DICCIONARIO QUE GUARDA LAS CATEGORIAS
            foreach (string entrada in dcCategorias.Keys) {
                dcCategorias.TryGetValue(entrada, out int valor);
                lstEstadistica.Items.Add(entrada.ToUpper() + ": " + valor);
            }
            //recorremos la lista para sacar los minimos y los maximos
            double mayorCoste = 0;
            int menosNumPag = libros[0].Paginas;
            string tituloMasCaro = "";
            string tituloMenosPag = "";
            foreach (Libro libro in libros) {
                if (libro.Coste >= mayorCoste) {
                    mayorCoste = libro.Coste;
                    tituloMasCaro = libro.Titulo;
               
                }
                if (libro.Paginas <= menosNumPag) {
                    menosNumPag = libro.Paginas;
                    tituloMenosPag = libro.Titulo;

                }
            }
            lstEstadistica.Items.Add("----------------------");
            lstEstadistica.Items.Add("LIBRO DE MAYOR COSTE: " + tituloMasCaro);
            lstEstadistica.Items.Add("----------------------");
            lstEstadistica.Items.Add("----------------------");
            lstEstadistica.Items.Add("LIBRO CON MENOR numero de PAGINAS : " + tituloMenosPag);
            lstEstadistica.Items.Add("----------------------");

            //Recorremos el diccionario que guarda el coste acumulado de cada editorial
            foreach (string entrada in dcCosteAcumulado.Keys) {
                dcCosteAcumulado.TryGetValue(entrada, out double valor);
                lstEstadistica.Items.Add("COSTE ACUMULADO " + entrada.ToUpper() + ": " + valor.ToString("#.00") + "€");
            }
        }

        //limpia los componentes del formulario para prepararlos
        private void limpiar() {
            txtTitulo.Text = "";
            txtPaginas.Text = "";
            txtCoste.Text = " ";
            txtAñoEdicion.Text = " ";

            //ponemos el foco en el campo titulo
            txtTitulo.Focus();
        
        }

        //Actualiza la info de los diccionarios y lo añade a la lista de libros
        private void actualizarDatos(Libro libro) {
            //insertamos el nuevo libro en la lista
            libros.Add(libro);
            //Actualiza el diccionario con el numero de libros de cada categoria
            dcCategorias[libro.Categoria] += 1; //Sumamos uno al valor de esto
            //Actualiza el diccionario con el coste acumulado de cada editorial
            dcCosteAcumulado[libro.Editorial] += libro.Coste;
        
        }

        private void insertarLibro(Libro libro) {
            ListViewItem item = new ListViewItem(libro.Titulo);
            item.SubItems.Add(libro.Editorial);
            item.SubItems.Add(libro.Categoria);
            item.SubItems.Add(libro.Edicion.ToString());
            item.SubItems.Add(libro.Paginas.ToString());
            item.SubItems.Add(libro.Coste.ToString("#.00"));

            lstvLibros.Items.Add(item);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
