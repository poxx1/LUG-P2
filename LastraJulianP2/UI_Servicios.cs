using BE_Propiedades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class UI_Servicios : Form
    {
        public UI_Servicios()
        {
            InitializeComponent();
        }

        BE_Servicios s;

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            s = new BE_Servicios();

            s.Codigo = Int32.Parse(textBox1.Text);
            s.Nombre = textBox2.Text;
            if (radioButton1.Checked == true)
                s.Tipo = "true";
            else
                s.Tipo = "false";
            s.Fecha = Convert.ToDateTime(textBox4.Text);
            s.Costo = Int32.Parse(textBox5.Text);
            s.Minutos = Int32.Parse(textBox3.Text);
            if (checkBox1.Checked == true)
                s.Calidad = "true";
            else
                s.Calidad = "false";
        }
    }
}
