using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen
{
    public partial class Resultados : Form
    {
        string name;
        int correctas=0;
        string path = "Calificaciones.FINAL";
        string[] Respuestas3;
        string[] Respuestas2;
        string[] Respuestas1;
        string[] Preguntas1= { "1.- ¿Que forma tiene la tierra?\n", "2.- ¿Que es la rotación?\n", "3.- ¿Cuantas estaciones del año hay?\n" };
        string[] correctas1 = { "c) Esferoide", "a) Movimiento", "c) 4" };
        string[] Preguntas2  = { "1.- ¿Cuanto es 25+25?\n", "2.- Resuelve la ecuación x+10=5\n", "3.- 2/4 es igual a:\n" };
        string[] correctas2 = { "c) 50", "a) x=-5", "c) 1/2" };
        string[] Preguntas3 = { "1.- ¿Quien es el creador del lenguaje C?\n", "2.- ¿En que año se creo el lenguaje C?\n", "¿Cúal es el caracter utilizado para hacer comentario de multiples lineas?\n" };
        string[] correctas3 = { "c) Dennis M. Ritchie", "a) 1972", "c) ;" };
        List<string> agregado1 = new List<string>();
        List<string> agregado2 = new List<string>();
        List<string> agregado3 = new List<string>();

        public Resultados(string name, string[] Respuestas3, string[] Respuestas2, string[] Respuestas1)
        {
            InitializeComponent();
            this.name = name;
            this.Respuestas3 = Respuestas3;
            this.Respuestas2 = Respuestas2;
            this.Respuestas1 = Respuestas1;

            for (int i = 0; i < 3; i++)
            {
                if (correctas1[i] == Respuestas1[i])
                {
                    string agregado = "Resuelto correctamente \n " + Preguntas1[i] + correctas1[i] + "\n";
                    agregado1.Add(agregado);
                    correctas++;
                }
                else
                {
                    string agregado = "Resuelto incorrectamente \n" + Preguntas1[i] + correctas1[i] + " |  Tu Respuesta: " + Respuestas1[i] + "\n";
                    agregado1.Add(agregado);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (correctas2[i] == Respuestas2[i])
                {
                    string agregado = "Resuelto correctamente \n " + Preguntas2[i] + correctas2[i] + "\n";
                    agregado2.Add(agregado);
                    correctas++;
                }
                else
                {
                    string agregado = "Resuelto incorrectamente \n" + Preguntas2[i] + correctas2[i] + " |  Tu Respuesta: " + Respuestas2[i] + "\n";
                    agregado2.Add(agregado);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (correctas3[i] == Respuestas3[i])
                {
                    string agregado = "Resuelto correctamente \n " + Preguntas3[i] + correctas3[i] + "\n";
                    agregado3.Add(agregado);
                    correctas++;
                }
                else
                {
                    string agregado = "Resuelto incorrectamente \n" + Preguntas3[i] + correctas3[i] + " |  Tu Respuesta: " + Respuestas3[i] + "\n";
                    agregado3.Add(agregado);
                }
            }


            label1.Text = name + "\nAciertos: " + correctas + "\t Calificación: " + (correctas*10)/9 + "\n"+
                agregado1[0]+agregado1[1]+agregado1[2]+
                agregado2[0] + agregado2[1] + agregado2[2] +
                agregado3[0] + agregado3[1] + agregado3[2] ;
            File.AppendAllText(path, correctas +"  |  "+ ((correctas * 10) / 9) +"*");
            string[] documenton=null;
            
            if (File.Exists("Promedio.gr2"))
            {
                documenton = File.ReadAllLines("Promedio.gr2");
                string aa = "";
                for (int j = 0; j < documenton.Length; j++)
                {
                    aa = aa + documenton[j];
                }
                double documento = Convert.ToDouble(aa);
                File.Delete("Promedio.gr2");
                File.AppendAllText("Promedio.gr2", (documento + ((correctas * 10) / 9)).ToString());
            }
            else
            {
                File.AppendAllText("Promedio.gr2", ((correctas * 10) / 9).ToString());
            }
        }

        private void Resultados_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
