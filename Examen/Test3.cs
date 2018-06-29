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
    public partial class Test3 : Form
    {
        string name;
        string[] Respuestas1;
        string[] Respuestas2;
        string[] test3 = new string[3];
        public Test3( string name, string[] Respuestas2, string[] Respuestas1)
        {
            InitializeComponent();
            this.Respuestas1 = Respuestas1;
            this.Respuestas2 = Respuestas2;
            this.name = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbPAN.Checked)
            {
                test3[0] = "a) Bill Gates";
            }
            if (rdbMorena.Checked)
            {
                test3[0] = "b) James Gosling";
            }
            if (rdbPRI.Checked)
            {
                test3[0] = "c) Dennis M. Ritchie";

            }

            if (radioButton3.Checked)
            {
                test3[1] = "a) 1972";
            
            }
            if (radioButton1.Checked)
            {
                test3[1] = "b) 1956";
            }
            if (radioButton2.Checked)
            {
                test3[1] = "c) 1989";
            }

            if (radioButton6.Checked)
            {
                test3[2] = "a) +";
            }
            if (radioButton4.Checked)
            {
                test3[2] = "b) ,";
            }
            if (radioButton5.Checked)
            {
                test3[2] = "c) ;";
               
            }
            

            Resultados nueva = new Resultados(name,test3,Respuestas2,Respuestas1);
            nueva.Show();
            this.Close();
        }
    }
}
