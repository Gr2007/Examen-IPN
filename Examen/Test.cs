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
    public partial class Test : Form
    {
        string name;
        string[] test3=new string[3];
        public Test(string name)
        {
            InitializeComponent();
            this.name = name;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbPAN.Checked)
            {
                test3[0] = "a) Cubo";
            }
            if (rdbMorena.Checked)
            {
                test3[0] = "b) Esfera";
            }
            if (rdbPRI.Checked)
            {
                test3[0] = "c) Esferoide";
                //this.correctas++;
            }

            if (radioButton3.Checked)
            {
                test3[1] = "a) Movimiento";
                //this.correctas++;
            }
            if (radioButton1.Checked)
            {
                test3[1] = "b) Fase";
            }
            if (radioButton2.Checked)
            {
                test3[1] = "c) Ninguna de las anteriores";
            }

            if (radioButton6.Checked)
            {
                test3[2] = "a) 1";
            }
            if (radioButton4.Checked)
            {
                test3[2] = "b) 5";
            }
            if (radioButton5.Checked)
            {
                test3[2] = "c) 4";
                //this.correctas++;
            }
            
            Test2 Nueva = new Test2(name,test3);
            Nueva.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}
