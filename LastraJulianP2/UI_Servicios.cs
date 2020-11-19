using BE_Propiedades;
using BLL_Negocio;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UI
{
    public partial class UI_Servicios : Form
    {
        public UI_Servicios()
        {
            InitializeComponent();
        }

        private BE_Servicios s;
        private StoredProcedures st;

        bool v1, v2, v3, v4, v5;
        bool isok = false;

        private void bt_Insert_Click(object sender, EventArgs e)
        {
            s = new BE_Servicios();
            st = new StoredProcedures();


            v1 = Regex.IsMatch(textBox1.Text, "^([0-9]+$");
            if (v1)
                isok = true;
            else
            {

            }
            if (isok)
            {
                s.Codigo = Int32.Parse(textBox1.Text);
            }


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

            st.Insert(s,"InsertT");
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {
            s = new BE_Servicios();
            st = new StoredProcedures();

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

            st.Insert(s, "UpdateT");
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            s = new BE_Servicios();
            st = new StoredProcedures();

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

            st.Insert(s, "DeleteT");
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UI_Servicios_Load(object sender, EventArgs e)
        {
            var c = new N_Servicios();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = c.Load();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public void Load2()
        {
            var c = new N_Servicios();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = c.Load();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
