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
            //A lot of this is going to deal with the physics and actual rendering of the dice. This is just
            //skeleton code for when we get that implemented.

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
            NumericUpDown o = (NumericUpDown)sender;
            int d4currentVal = (int)o.Value;
            int d4lastVal = (o.Tag == null) ? 0 : (int)o.Tag;
            o.Tag = d4currentVal;

            int d4total = 0;

            if (d4currentVal > d4lastVal)
            {
                //add die/dice to d4total
                d4total += d4currentVal;
            }
            else if (d4currentVal < d4lastVal)
            {
                //remove die/dice from d4total
                d4total -= d4currentVal;
            }

        }

        private void d6num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            NumericUpDown o = (NumericUpDown)sender;
            int d6currentVal = (int)o.Value;
            int d6lastVal = (o.Tag == null) ? 0 : (int)o.Tag;
            o.Tag = d6currentVal;

            int d6total = 0;

            if (d6currentVal > d6lastVal)
            {
                //add die/dice to total
                d6total += d6currentVal;
            }
            else if (d6currentVal < d6lastVal)
            {
                //remove die/dice from total
                d6total -= d6currentVal;
            }
        }

        private void d8num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            NumericUpDown o = (NumericUpDown)sender;
            int d8currentVal = (int)o.Value;
            int d8lastVal = (o.Tag == null) ? 0 : (int)o.Tag;
            o.Tag = d8currentVal;

            int d8total = 0;

            if (d8currentVal > d8lastVal)
            {
                //add die/dice to total
                d8total += d8currentVal;
            }
            else if (d8currentVal < d8lastVal)
            {
                //remove die/dice from total
                d8total -= d8currentVal;
            }
        }

        private void d10num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            NumericUpDown o = (NumericUpDown)sender;
            int d10currentVal = (int)o.Value;
            int d10lastVal = (o.Tag == null) ? 0 : (int)o.Tag;
            o.Tag = d10currentVal;

            int d10total = 0;

            if (d10currentVal > d10lastVal)
            {
                //add die/dice to total
                d10total += d10currentVal;
            }
            else if (d10currentVal < d10lastVal)
            {
                //remove die/dice from total
                d10total -= d10currentVal;
            }
        }

        private void d12num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            NumericUpDown o = (NumericUpDown)sender;
            int d12currentVal = (int)o.Value;
            int d12lastVal = (o.Tag == null) ? 0 : (int)o.Tag;
            o.Tag = d12currentVal;

            int d12total = 0;

            if (d12currentVal > d12lastVal)
            {
                //add die/dice to total
                d12total += d12currentVal;
            }
            else if (d12currentVal < d12lastVal)
            {
                //remove die/dice from total
                d12total -= d12currentVal;
            }
        }

        private void d20num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            NumericUpDown o = (NumericUpDown)sender;
            int d20currentVal = (int)o.Value;
            int d20lastVal = (o.Tag == null) ? 0 : (int)o.Tag;
            o.Tag = d20currentVal;

            int d20total = 0;

            if (d20currentVal > d20lastVal)
            {
                //add die/dice to total
                d20total += d20currentVal;
            }
            else if (d20currentVal < d20lastVal)
            {
                //remove die/dice from total
                d20total -= d20currentVal;
            }
        }

        private void d00num_ValueChanged(object sender, EventArgs e)
        {
            //check number
            NumericUpDown o = (NumericUpDown)sender;
            int d00currentVal = (int)o.Value;
            int d00lastVal = (o.Tag == null) ? 0 : (int)o.Tag;
            o.Tag = d00currentVal;

            int d00total = 0;

            if (d00currentVal > d00lastVal)
            {
                //add die/dice to total
                d00total += d00currentVal;
            }
            else if (d00currentVal < d00lastVal)
            {
                //remove die/dice from total
                d00total -= d00currentVal;
            }
        }

        private int totalNumberDice()//private?
        {
            int d4numTot = (int)d4num.Value;
            int d6numTot = (int)d6num.Value;
            int d10numTot = (int)d10num.Value;
            int d12numTot = (int)d12num.Value;
            int d20numTot = (int)d20num.Value;
            int d00numTot = (int)d00num.Value;

            int totalDice = d4numTot + d6numTot + d10numTot + d12numTot + d20numTot + d00numTot;

            return totalDice;
        }

        //oops, don't know how to get rid of this without freaking the Form1.cs stuff out with errors
        private void textLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {
            //output from Dnum results
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

        private void rollButton_Click(object sender, EventArgs e)
        {
            //can't roll if dice # > 12!
            if(totalNumberDice() > 12)
            {
                MessageBox.Show("You cannot roll more than 12 dice at a time!", "Error");
            }
            
            //rest of roll button stuff, will probably start off the physics engine, but we're not there yet
        }
    }
}
