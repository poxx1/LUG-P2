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
    public partial class UITransmisionXML : Form
    {
        public UITransmisionXML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new XML();
            x.Create("1","1","1","1","1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = new XML();
            listBox1.DataSource = x.Read();
            listBox1.DisplayMember = "Streaming";
        }
    }
}
