using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manual_on_the_definition_of_the_transfer_function_and_frequency_characteristics_of_ACS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Table()).Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            int correntAnswers = 0;


            if ((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked) && (radioButton4.Checked || radioButton5.Checked || radioButton6.Checked) && (radioButton7.Checked || radioButton8.Checked || radioButton9.Checked))
            {

                //Задание 1
                if (radioButton1.Checked)
                {
                    button7.Visible = true;
                    label3.ForeColor = Color.Red;
                    label3.Text = "X";
                    label3.Visible = true;

                }

                else if (radioButton2.Checked)
                {
                    //Corrent Answer
                    button7.Visible = false;
                    label4.ForeColor = Color.Green;
                    label4.Text = "✓";
                    label4.Visible = true;
                    correntAnswers += 1;
                }

                else if (radioButton3.Checked)
                {
                    button7.Visible = true;
                    label2.ForeColor = Color.Red;
                    label2.Visible = true;
                    label2.Text = "X";
                }

                //Задание 2 
                if (radioButton6.Checked)
                {
                    //correct Answer
                    button6.Visible = false;
                    label7.ForeColor = Color.Green;
                    label7.Text = "✓";
                    label7.Visible = true;
                    correntAnswers += 1;
                }

                else if (radioButton4.Checked)
                {
                    button6.Visible = true;
                    label6.Visible = true;
                    label6.ForeColor = Color.Red;
                    label6.Text = "X";
                }

                else if (radioButton5.Checked)
                {
                    button6.Visible = true;
                    label5.Visible = true;
                    label5.ForeColor = Color.Red;
                    label5.Text = "X";
                }

                //Задание 3 
                if (radioButton7.Checked)
                {
                    //correct answer
                    button8.Visible = false;
                    label9.Visible = true;
                    label9.ForeColor = Color.Green;
                    label9.Text = "✓";
                    correntAnswers += 1;
                }

                else if (radioButton9.Checked)
                {
                    button8.Visible = true;
                    label8.Visible = true;
                    label8.ForeColor = Color.Red;
                    label8.Text = "X";
                }

                else if (radioButton8.Checked)
                {
                    button8.Visible = true;
                    label10.Visible = true;
                    label10.ForeColor = Color.Red;
                    label10.Text = "X";
                }

                button5.BackColor = Color.Gray;
                button5.Enabled = false;

                label37.Text = "Итого:" + correntAnswers + "/3";
                label37.Visible = true;
            }
            else
            {
                label37.Text = "Выполнены не все задания.\nНеобходимо нажать кнопку после выполнения 3-х заданий.";
                label37.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int myVar = Convert.ToInt16(textBox1.Text);

            int[] arrayOfNumbers = new int[10];

            if (myVar > 0)
            {

                label13.Text = "Результат:";
                int isNumEven = myVar % 2 == 0 ? 2 : -3;
                int currentNum = myVar;
                if (myVar > 36)
                {
                    currentNum = myVar - 36;
                }

                int remainderOfCurrentNum = 0;
                Console.WriteLine(isNumEven);
                Console.WriteLine(currentNum);
                for (int n = 0; n < 10; n++)
                {
                    if (currentNum > 36)
                    {
                        remainderOfCurrentNum = currentNum - 36;
                        currentNum = 0 + remainderOfCurrentNum;
                    }

                    else if (currentNum < 0)
                    {
                        remainderOfCurrentNum = currentNum + 36;
                        currentNum = 0 + remainderOfCurrentNum;
                    }

                    arrayOfNumbers.Append(currentNum);
                    Console.WriteLine(n + ":" + currentNum);
                    label13.Text += " " + currentNum;
                    currentNum = currentNum + isNumEven;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new Task3()).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new Task2()).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (new Task1()).Show();
        }
    }
}
