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
    public partial class DatosAlu : Form
    {
        string path = "Calificaciones.FINAL";
        public DatosAlu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            File.AppendAllText(path, "|  " + textBox1.Text + "  |  ");
            Test nueva = new Test(textBox1.Text);
            nueva.Show();
            this.Close();
        }
    }
}
