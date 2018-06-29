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
    public partial class Revisión : Form
    {
        string path = "Calificaciones.FINAL";
        string[] aa;
        public Revisión()
        {
            InitializeComponent();

            string[] documento;
            File.AppendAllText(path, "");

            documento = File.ReadAllLines(path);

            for (int i = 0; i < documento.Length; i++)
            {
                aa = documento[i].Split(new char[] { '*' });
                for (int j = 0; j < aa.Length; j++)
                {
                    listBox1.Items.Add(aa[j] + "\n");
                }
            }
            string[] documenton = File.ReadAllLines("N.n");
            string bb = "";
            for (int j = 0; j < documenton.Length; j++)
            {
                bb = bb + documenton[j];
            }
            double documentox = Convert.ToDouble(bb);
            

            string[] documenton1 = File.ReadAllLines("Promedio.gr2");
            string bb1 = "";
            for (int j = 0; j < documenton1.Length; j++)
            {
                bb1 = bb1 + documenton1[j];
            }
            double documentox1 = Convert.ToDouble(bb1);

            double documentos = documentox1/documentox;

            label2.Text ="Promedio grupal:\n" +documentos.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Revisión_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
