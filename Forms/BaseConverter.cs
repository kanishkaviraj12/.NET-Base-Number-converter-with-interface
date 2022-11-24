using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Number_converter_interface.Forms
{
    public partial class BaseConverter : KryptonForm
    {
        public BaseConverter()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                /*int decimalNumber = int.Parse(textBox1.Text);
                //int remainder;
                string result = string.Empty;
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 2;
                    decimalNumber /= 2;
                    result = remainder.ToString() + result;
                }
                textBox2.Text = (result);
                */
                int decimalValue = int.Parse(textBox1.Text);
                int convertnumber = Convert.ToInt32(decimalValue.ToString(), 10);
                textBox2.Text = (Convert.ToString(convertnumber, 2));

                string outputBase = "Binary Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton3.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;

            }

            else if (radioButton2.Checked)
            {

                int octalValue = int.Parse(textBox1.Text);
                int convertnumber = Convert.ToInt32(octalValue.ToString(), 8);
                textBox2.Text = (Convert.ToString(convertnumber, 2));

                string outputBase = "Binary Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton2.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;

            }

            else if (radioButton4.Checked)
            {
                string hexValue = Convert.ToString(textBox1.Text);
                int convertnumber = Convert.ToInt32(hexValue.ToString(), 16);
                textBox2.Text = (Convert.ToString(convertnumber, 2));

                string outputBase = "Binary Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton4.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;


            }
            else if (Convert.ToBoolean(textBox1.Text == string.Empty))
            {   
                
                MessageBox.Show("Please input a number !");
            }

          /* else if (Convert.ToBoolean(Convert.ToInt32(textBox1.Text == string.Empty)))
            {
                MessageBox.Show("Please input a number !");
            } */

            else
            {
                MessageBox.Show("Choose Correct Base Value !");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int binaryValue = int.Parse(textBox1.Text);
                int convertnumber = Convert.ToInt32(binaryValue.ToString(), 2);
                textBox2.Text = (Convert.ToString(convertnumber, 8));

                string outputBase = "Octal Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton1.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;


            }

            else if (radioButton3.Checked)
            {
                /*int decimalNumber = int.Parse(textBox1.Text);
                int remainder;
                string result = string.Empty;
                while (decimalNumber > 0)
                {
                    remainder = decimalNumber % 8;
                    decimalNumber /= 8;
                    result = remainder.ToString() + result;
                }
                textBox2.Text = (result);
                */

                int decimalValue = int.Parse(textBox1.Text);
                int convertnumber = Convert.ToInt32(decimalValue.ToString(), 10);
                textBox2.Text = (Convert.ToString(convertnumber, 8));

                string outputBase = "Octal Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton3.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;

            }


            else if (radioButton4.Checked)
            {
                string hexValue = Convert.ToString(textBox1.Text);
                int convertnumber = Convert.ToInt32(hexValue.ToString(), 16);
                textBox2.Text = (Convert.ToString(convertnumber, 8));

                string outputBase = "Octal Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton4.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;

            }

            else if (Convert.ToBoolean(textBox1.Text == string.Empty))
            {

                MessageBox.Show("Please input a number !");
            }

            else
            {
                MessageBox.Show("Choose Correct Base Value !");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int binaryValue = int.Parse(textBox1.Text);
                int decimalValue = Convert.ToInt32(binaryValue.ToString(), 2);
                textBox2.Text = decimalValue.ToString();

                string outputBase = "Decimal Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton1.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;

            }

            else if (radioButton2.Checked)
            {
                int octalValue = int.Parse(textBox1.Text);
                int convertnumber = Convert.ToInt32(octalValue.ToString(), 8);
                textBox2.Text = (Convert.ToString(convertnumber, 10));

                string outputBase = "Decimal Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton2.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;


            }

            else if (radioButton4.Checked)
            {
                string hexValue = Convert.ToString(textBox1.Text);
                int convertnumber = Convert.ToInt32(hexValue.ToString(), 16);
                textBox2.Text = (Convert.ToString(convertnumber, 10));

                string outputBase = "Decimal Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton4.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;

            }

            else if (Convert.ToBoolean(textBox1.Text == string.Empty))
            {

                MessageBox.Show("Please input a number !");
            }

            else
            {
                MessageBox.Show("Choose Correct Base Value !");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {



            /*int decimalNumber = int.Parse(textBox1.Text);
            string[] myarr = new string[] { "A", "B","C","D","E","F"};
            int remainder;
            string result = string.Empty;

            string[] temp_str = new string[] { "1000", "2000", "3000" };
            

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 16;
                if (remainder > 9 && remainder == 10)
                {
                    //int.Parse(ReadOnlySpan<char>.Empty);
                    myarr[remainder] = 0;
                }

                else if (remainder > 10 && remainder == 11)
                {
                    myarr[remainder + 1] = "B";
                }

                else if (remainder > 10 && remainder == 12)
                {
                    myarr[remainder +1] = "C";  
                }

                else if (remainder > 10 && remainder == 13)
                {
                    myarr[remainder + 1] = "D";
                }

                else if (remainder > 10 && remainder == 14)
                {
                    myarr[remainder + 1] = "E";
                }

                else if (remainder > 10 && remainder == 15)
                {
                    myarr[remainder +1 ] = "F";
                }

                decimalNumber /= 16;
                result = remainder.ToString() + result;
            }
            textBox2.Text = (result);
           */



            if (radioButton1.Checked)
            {
                int binaryValue = int.Parse(textBox1.Text);
                int convertnumber = Convert.ToInt32(binaryValue.ToString(), 2);
                textBox2.Text = (Convert.ToString(convertnumber, 16));

                string outputBase = "Hex Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton1.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;

            }

            else if (radioButton3.Checked)
            {
                int decimalValue = int.Parse(textBox1.Text);
                string converrtnumber = Convert.ToString(decimalValue, 16);
                textBox2.Text = converrtnumber;

                string outputBase = "Hex Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton3.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;

            }

            else if (radioButton2.Checked)
            {
                int octalValue = int.Parse(textBox1.Text);
                int convertnumber = Convert.ToInt32(octalValue.ToString(), 8);
                textBox2.Text = (Convert.ToString(convertnumber, 16));

                string outputBase = "Hex Number";
                string printedArrow = "     --------->>";

                dt.Rows.Add(textBox1.Text, radioButton2.Text, printedArrow, textBox2.Text, outputBase);
                dataGridView1.DataSource = dt;

            }

            else if (Convert.ToBoolean(textBox1.Text == string.Empty))
            {

                MessageBox.Show("Please input a number !");
            }

            else
            {
                MessageBox.Show("Choose Correct Base Value !");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = string.Empty;
        }

        private void BaseConverter_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(new DataColumn("Entered_Number", typeof(string)));
            dt.Columns.Add(new DataColumn("Input_Base_Type", typeof(string)));
            dt.Columns.Add(new DataColumn(" ", typeof(string)));
            dt.Columns.Add(new DataColumn("Answer", typeof(string)));
            dt.Columns.Add(new DataColumn("Output_Base_Type", typeof(string)));

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
