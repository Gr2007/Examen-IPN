using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Test2 : Form
    {
        //int correctas = 0;
        string name;
        string[] Respuestas;
        string[] test3 = new string[3];
        public Test2( string name, string[] Respuestas)
        {
            InitializeComponent();
            this.name = name;
            this.Respuestas = Respuestas;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbPAN.Checked)
            {
                test3[0] = "a) 48";
            }
            if (rdbMorena.Checked)
            {
                test3[0] = "b) 49";
            }
            if (rdbPRI.Checked)
            {
                test3[0] = "c) 50";
                //correctas++;
            }

            if (radioButton3.Checked)
            {
                test3[1] = "a) x=-5";
                //correctas++;
            }
            if (radioButton1.Checked)
            {
                test3[1] = "b) x=5";
            }
            if (radioButton2.Checked)
            {
                test3[1] = "c) Ninguna de las anteriores";
            }

            if (radioButton6.Checked)
            {
                test3[2] = "a) 1/7";
            }
            if (radioButton4.Checked)
            {
                test3[2] = "b) 5/5";
            }
            if (radioButton5.Checked)
            {
                test3[2] = "c) 1/2";
                //correctas++;
            }
            
            Test3 Nueva = new Test3(name,test3,Respuestas);
            Nueva.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
