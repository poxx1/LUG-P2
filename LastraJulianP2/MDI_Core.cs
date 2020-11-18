using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace LastraJulianP2
{
    public partial class MDI_Core : Form
    {
        public MDI_Core()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool is_Open = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "UI_Empresas")
                {
                    is_Open = true;
                    f.Focus();
                    break;
                }
            }

            if (is_Open == false)
            {
                UI_Empresas emp = new UI_Empresas();
                emp.MdiParent = this;
                emp.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool is_Open = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "xml")
                {
                    is_Open = true;
                    f.Focus();
                    break;
                }
            }

            if (is_Open == false)
            {
                var emp = new UITransmisionXML();
                emp.MdiParent = this;
                emp.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool is_Open = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "sv")
                {
                    is_Open = true;
                    f.Focus();
                    break;
                }
            }

            if (is_Open == false)
            {
                var emp = new UI_Servicios();
                emp.MdiParent = this;
                emp.Show();
            }
        }
    }
}
