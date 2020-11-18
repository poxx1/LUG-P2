using BE_Propiedades;
using BLL_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class UI_Empresas : Form
    {
        N_Empresas n_Empresas;
        BE_Empresas bE_Empresas;
        public UI_Empresas()
        {
            InitializeComponent();
        }

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            SetEmpresa();

            n_Empresas = new N_Empresas();
            n_Empresas.Insert(bE_Empresas);


        }

        private void SetEmpresa()
        {
            bE_Empresas = new BE_Empresas();
            bE_Empresas.Codigo = Int32.Parse(textBox1.Text);
            bE_Empresas.RazonSocial = textBox2.Text;
            bE_Empresas.Cuit = Int32.Parse(textBox3.Text);
            bE_Empresas.Correo = textBox4.Text;
            //bE_Empresas.Servicio = comboBox1.Text;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            SetEmpresa();

            n_Empresas = new N_Empresas();
            n_Empresas.Insert(bE_Empresas);

        }
    }
}
