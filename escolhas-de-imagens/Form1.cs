using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace escolhas_de_imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureNot2.Visible= false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureNot1.Visible = true;
            this.pictureNot2.Visible = true;
            this.pictureNot3.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureLivro1.Visible = true;
            this.pictureLivro2.Visible = true;
            this.pictureLivro3.Visible = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureNot1.Visible = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureNot3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureNot1.Visible = false;
            this.pictureNot2.Visible = false;
            this.pictureNot3.Visible = false;

            this.pictureLivro1.Visible = false;
            this.pictureLivro2.Visible = false;
            this.pictureLivro3.Visible = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureLivro1.Visible=true;
           
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureLivro2.Visible = true;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureLivro3.Visible=true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }
    }
}
