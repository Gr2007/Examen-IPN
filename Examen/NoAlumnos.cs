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
    public partial class NoAlumnos : Form
    {
         
        int NVotos = 0;
        string path = "Calificaciones.FINAL";
        public NoAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NVotos = Convert.ToInt32(txtNoUser.Text);
            this.Hide();
            File.Delete(path);
            File.Delete("Promedio.gr2");
            File.Delete("N.n");

            File.AppendAllText("N.n", NVotos.ToString());
            for (int i = 0; i < NVotos; i++)
            {
                DatosAlu nueva = new DatosAlu();
                nueva.Show();
            }
        }

        private void NoAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
