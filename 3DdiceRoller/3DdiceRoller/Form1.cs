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

        private void colorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(colorSelect.Text == "Red")
            {
                //set dice color red
            }
            else if (colorSelect.Text == "Yellow")
            {
                //set dice color yellow
            }
            else if (colorSelect.Text == "Blue")
            {
                //set dice color blue
            }
            else if (colorSelect.Text == "Green")
            {
                //set dice color green
            }
            else if (colorSelect.Text == "Orange")
            {
                //set dice color orange
            }
            else if (colorSelect.Text == "Purple")
            {
                //set dice color purple
            }
            else if (colorSelect.Text == "White")
            {
                //set dice color white
            }
            else if (colorSelect.Text == "Black")
            {
                //set dice color black
            }
            else
            {
                //do nothing...?
            }
        }

        //NumericUpDown edits
        private void d4num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            //if num > starting num: add 1 dice of this type per 1 increment
            //else if num < starting num: remove 1 dice of this type per 1 increment

        }

        private void d6num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            //if num > starting num: add 1 dice of this type per 1 increment
            //else if num < starting num: remove 1 dice of this type per 1 increment
        }

        private void d8num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            //if num > starting num: add 1 dice of this type per 1 increment
            //else if num < starting num: remove 1 dice of this type per 1 increment
        }

        private void d10num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            //if num > starting num: add 1 dice of this type per 1 increment
            //else if num < starting num: remove 1 dice of this type per 1 increment
        }

        private void d12num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            //if num > starting num: add 1 dice of this type per 1 increment
            //else if num < starting num: remove 1 dice of this type per 1 increment
        }

        private void d20num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            //if num > starting num: add 1 dice of this type per 1 increment
            //else if num < starting num: remove 1 dice of this type per 1 increment
        }

        private void d00num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            //if num > starting num: add 1 dice of this type per 1 increment
            //else if num < starting num: remove 1 dice of this type per 1 increment
        }

        //oops, don't know how to get rid of this without freaking the Form1.cs stuff out with errors
        private void textLabel_Click(object sender, EventArgs e)
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
            String info = "Version Number: Prototype 1.0 \n" + "Prototype Team: Noah Miller, Erin Primrose, Baughn Welch ";
            MessageBox.Show(info, "Version Information");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)//Help Message Box
        {
            string help = "Help info here";
            MessageBox.Show(help, "Help");
        }
    }
}
