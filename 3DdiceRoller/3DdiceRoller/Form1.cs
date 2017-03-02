using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DdiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void thereIsNoHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void versionInformationToolStripMenuItem_Click(object sender, EventArgs e) // ver info
        {
            String info = " Version Number: Prototype 1.0 \n" + "Prototype Team: Noah Miller, Erin Primrose, Baughn Welch ";
            MessageBox.Show("info", "Version Information");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)//Help Message Box
        {
            string help = "Help info here";
            MessageBox.Show("", "Help");
        }
    }
}
