using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int v0 = 0, v1 = 0, v2=0, v3=0, v4=0, v5=0, v6=0, v7=0, v8=0, v9=0, nulo=0;
        public Form1()
        {
            InitializeComponent();
           
           
        }

        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox0.Checked == true) v0 = 0; else v0 = nulo;
            calcular();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) v1 = 1; else v1 = nulo;
            calcular();
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) v2 = 2; else v2 = nulo ;
            calcular();
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) v3 = 3; else v3 = nulo;
            calcular();

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) v4 = 4; else v4 = nulo;
            calcular();
           
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true) v5 = 5; else v5 = nulo;
            calcular();
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true) v6 = 6; else v6 = nulo;
            calcular();
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true) v7 = 7; else v7 = nulo;
            calcular();
           
        }


        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true) v8 = 8; else v8 = nulo;
            calcular();
           
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true) v9 = 9; else v9 = nulo;
            calcular();
           
        }

        private void calcular()
        {
            if (nulo == 0)
            {
                resultado.Text = Convert.ToString(v0 + v1 + v2 + v3 + v4 + v5 + v6 + v7 + v8 + v9);

            }
            else
            {
                resultado.Text = Convert.ToString(v0*v1*v2*v3*v4*v5*v6*v7*v8*v9);
            }
        }

        private void suma_CheckedChanged(object sender, EventArgs e)
        {
            nulo = 0;
            if (checkBox4.Checked == true) v4 = 4; else v4 = nulo;
            calcular();
            if (checkBox7.Checked == true) v7 = 7; else v7 = nulo;
            calcular();
            if (checkBox9.Checked == true) v9 = 9; else v9 = nulo;
            calcular();
            if (checkBox8.Checked == true) v8 = 8; else v8 = nulo;
            calcular();
            if (checkBox6.Checked == true) v6 = 6; else v6 = nulo;
            calcular();
            if (checkBox5.Checked == true) v5 = 5; else v5 = nulo;
            calcular();
            if (checkBox3.Checked == true) v3 = 3; else v3 = nulo;
            calcular();
            if (checkBox2.Checked == true) v2 = 2; else v2 = nulo;
            calcular();
            if (checkBox1.Checked == true) v1 = 1; else v1 = nulo;
            calcular();
            if (checkBox0.Checked == true) v0 = 0; else v0 = nulo;
            calcular();
           
            calcular();
        }

        private void multiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            nulo = 1;
            if (checkBox4.Checked == true) v4 = 4; else v4 = nulo;
            calcular();
            if (checkBox7.Checked == true) v7 = 7; else v7 = nulo;
            calcular();
            if (checkBox9.Checked == true) v9 = 9; else v9 = nulo;
            calcular();
            if (checkBox8.Checked == true) v8 = 8; else v8 = nulo;
            calcular();
            if (checkBox6.Checked == true) v6 = 6; else v6 = nulo;
            calcular();
            if (checkBox5.Checked == true) v5 = 5; else v5 = nulo;
            calcular();
            if (checkBox3.Checked == true) v3 = 3; else v3 = nulo;
            calcular();
            if (checkBox2.Checked == true) v2 = 2; else v2 = nulo;
            calcular();
            if (checkBox1.Checked == true) v1 = 1; else v1 = nulo;
            calcular();
            if (checkBox0.Checked == true) v0 = 0; else v0 = nulo;
            calcular();
            
                     
            calcular();
        }

       
      
       

      

        

       

       
    }
}
