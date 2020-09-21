using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atelier_1_WFP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       #region Contrôles Formulaire

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCopieSel1_Click(object sender, EventArgs e)
        {
            textBox2.Multiline = false;
            textBox2.Height = 20;
            textBox2.Clear();

            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.TextLength;
            textBox2.Text = textBox1.SelectedText;
            
        }      

        private void btnEffacerSel1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnQuitterApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion



    


    }
}
