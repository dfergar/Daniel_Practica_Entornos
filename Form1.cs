﻿using System;
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

       

        private void calcular()
        {
            if (checkBox9.Checked == true) v9 = 9; else v9 = nulo;
            if (checkBox8.Checked == true) v8 = 8; else v8 = nulo;
            if (checkBox6.Checked == true) v6 = 6; else v6 = nulo;
            if (checkBox7.Checked == true) v7 = 7; else v7 = nulo;
            if (checkBox5.Checked == true) v5 = 5; else v5 = nulo;
            if (checkBox4.Checked == true) v4 = 4; else v4 = nulo;
            if (checkBox3.Checked == true) v3 = 3; else v3 = nulo;
            if (checkBox2.Checked == true) v2 = 2; else v2 = nulo;
            if (checkBox1.Checked == true) v1 = 1; else v1 = nulo;
            if (checkBox0.Checked == true) v0 = 0; else v0 = nulo;
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
            calcular();          
          
        }

        private void multiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            nulo = 1;              
            calcular();
        }

       
      
       

      

        

       

       
    }
}
