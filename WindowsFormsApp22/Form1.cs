using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //CreateLabel();
        }


        void CreateLabel()
        {
            Label label = new Label();
            Image image = Properties.Resources.ferrari;

            label.Size = new Size(image.Width, image.Height);
            label.Image = image;

            this.Controls.Add(label);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show($"Welcome  {nameTxtb.Text}");
            MessageBox.Show(richTextBox1.SelectedText);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "admin")
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
            }
            //Random random = new Random();
            //richTextBox1.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
           // richTextBox1.Text = "DOWN";
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
          //  richTextBox1.Text = "UP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Text = "Visa Selected";
            }
            else
            {
                radioButton1.Text = "Visa ";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.Text = "Master Selected";
            }
            else
            {
                radioButton2.Text = "Master ";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton3.ForeColor = Color.Green;
            }
            else
            {
                radioButton3.ForeColor = Color.Black;

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                radioButton4.ForeColor = Color.Green;
            }
            else
            {
                radioButton4.ForeColor = Color.Black;

            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                radioButton5.ForeColor = Color.Green;
            }
            else
            {
                radioButton5.ForeColor = Color.Black;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.Yellow;
            }
            else
            {
                checkBox1.BackColor = Color.White;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker1.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
