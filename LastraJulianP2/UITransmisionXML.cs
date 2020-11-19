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
            x.Create("LIVE","SD","Conferencia","45","16/11/2020");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var x = new XML();
            listBox1.DataSource = x.Read();
            listBox1.DisplayMember = "Streaming";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UITransmisionXML_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new XML();
            x.Write("VOD", "HD", "Casamiento", "65", "15/11/2020");
        }
    }
}
