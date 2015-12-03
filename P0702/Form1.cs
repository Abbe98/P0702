using System;
using System.Windows.Forms;
using System.Drawing;

namespace P0702
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // validation of input
        private bool validateInput(string input1, string input2)
        {
            if ((input1 == "0" || input1 == "1") && (input2 == "0" || input2 == "1"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // error wrapper :: passing textbox as anonymous object
        private void error(ref Label textbox)
        {
            textbox.ForeColor = Color.Black;
            textbox.Text = "X";
            MessageBox.Show("Ange värderna 0 eller 1", "Hoppsan!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // output :: passing textbox as anonymous object
        private void output(ref Label textbox, bool success)
        {
            
            switch (success)
            {
                case true:
                    textbox.Text = "1";
                    textbox.ForeColor = Color.Green;
                    break;
                default:
                    textbox.Text = "0";
                    textbox.ForeColor = Color.Red;
                    break;
            }
        }

        // and 
        private void image1_Click(object sender, EventArgs e)
        {
            string value1 = textBoxT1.Text;
            string value2 = textBoxT2.Text;

            if(validateInput(value1, value2))
            {
               switch (value1 == value2 && value1 != "0")
                {
                    case true:
                        output(ref output1, true);
                        break;
                    default:
                        output(ref output1, false);
                        break;
                }
            } else
            {
                error(ref output1);
            }
        }

        // nand
        private void image2_Click(object sender, EventArgs e)
        {
            string value1 = textBoxT3.Text;
            string value2 = textBoxT4.Text;

            if (validateInput(value1, value2))
            {
                switch (value1 != value2 || (value1 == "0" && value2 == "0"))
                {
                    case true:
                        output(ref output2, true);
                        break;
                    default:
                        output(ref output2, false);
                        break;
                }
            }
            else
            {
                error(ref output2);
            }
        }

        // or
        private void image3_Click(object sender, EventArgs e)
        {
            string value1 = textBoxT5.Text;
            string value2 = textBoxT6.Text;

            if (validateInput(value1, value2))
            {
                switch (value1 == "1" || value2 == "1")
                {
                    case true:
                        output(ref output3, true);
                        break;
                    default:
                        output(ref output3, false);
                        break;
                }
            }
            else
            {
                error(ref output3);
            }
        }

        // nor
        private void image4_Click(object sender, EventArgs e)
        {
            string value1 = textBoxT7.Text;
            string value2 = textBoxT8.Text;

            if (validateInput(value1, value2))
            {
                switch (value1 != "1" && value2 != "1")
                {
                    case true:
                        output(ref output4, true);
                        break;
                    default:
                        output(ref output4, false);
                        break;
                }
            }
            else
            {
                error(ref output4);
            }
        }

        // tot 1
        private void image5_Click(object sender, EventArgs e)
        {
            string value1 = textBoxT9.Text;
            string value2 = textBoxT10.Text;

            if (validateInput(value1, value2))
            {
                switch ((value1 == "0" && value2 == "1") || (value1 == "1" && value2 == "0"))
                {
                    case true:
                        output(ref output5, true);
                        break;
                    default:
                        output(ref output5, false);
                        break;
                }
            }
            else
            {
                error(ref output5);
            }
        }

        // ! tot 1
        private void image6_Click(object sender, EventArgs e)
        {
            string value1 = textBoxT11.Text;
            string value2 = textBoxT12.Text;

            if (validateInput(value1, value2))
            {
                switch ((value1 == "1" && value2 == "1") || (value1 == "0" && value2 == "0"))
                {
                    case true:
                        output(ref output6, true);
                        break;
                    default:
                        output(ref output6, false);
                        break;
                }
            }
            else
            {
                error(ref output6);
            }
        }

        private void image7_Click(object sender, EventArgs e)
        {
            string value1 = textBoxT13.Text;

            if (value1 == "0" || value1 == "1")
            {
                switch (value1 == "1")
                {
                    case true:
                        output(ref output7, true);
                        break;
                    default:
                        output(ref output7, false);
                        break;
                }
            }
            else
            {
                error(ref output7);
            }
        }

        // listeners for text change 
        private void textBoxT1_TextChanged(object sender, EventArgs e) { output1.ForeColor = Color.Black; output1.Text = "?"; }
        private void textBoxT2_TextChanged(object sender, EventArgs e) { output1.ForeColor = Color.Black; output1.Text = "?"; }
        private void textBoxT3_TextChanged(object sender, EventArgs e) { output2.ForeColor = Color.Black; output2.Text = "?"; }
        private void textBoxT4_TextChanged(object sender, EventArgs e) { output2.ForeColor = Color.Black; output2.Text = "?"; }
        private void textBoxT5_TextChanged(object sender, EventArgs e) { output3.ForeColor = Color.Black; output3.Text = "?"; }
        private void textBoxT6_TextChanged(object sender, EventArgs e) { output3.ForeColor = Color.Black; output3.Text = "?"; }
        private void textBoxT7_TextChanged(object sender, EventArgs e) { output4.ForeColor = Color.Black; output4.Text = "?"; }
        private void textBoxT8_TextChanged(object sender, EventArgs e) { output4.ForeColor = Color.Black; output4.Text = "?"; }
        private void textBoxT9_TextChanged(object sender, EventArgs e) { output5.ForeColor = Color.Black; output5.Text = "?"; }
        private void textBoxT10_TextChanged(object sender, EventArgs e) { output5.ForeColor = Color.Black; output5.Text = "?"; }
        private void textBoxT11_TextChanged(object sender, EventArgs e) { output6.ForeColor = Color.Black; output6.Text = "?"; }
        private void textBoxT12_TextChanged(object sender, EventArgs e) { output6.ForeColor = Color.Black; output6.Text = "?"; }
        private void textBoxT13_TextChanged(object sender, EventArgs e) { output7.ForeColor = Color.Black; output7.Text = "?"; }
    }
}
