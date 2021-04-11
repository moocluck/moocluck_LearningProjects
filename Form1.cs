using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Manual_for_solving_differential_equations_by_the_Laplace_method
{
    public partial class Form1 : Form
    {
        SoundPlayer SF1 = new SoundPlayer(@"C:\Users\moocluck\source\repos\Manual\Zvuk examena.wav");

        public Form1()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            (new Form3()).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new Form4()).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            (new Form5()).Show();
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
                    label30.ForeColor = Color.Red;
                    label30.Text = "X";

                }

                else if (radioButton2.Checked)
                {
                    //Corrent Answer
                    button7.Visible = false;
                    label28.ForeColor = Color.Green;
                    label28.Text = "✓";
                    correntAnswers += 1;
                }

                else if (radioButton3.Checked)
                {
                    button7.Visible = true;
                    label29.ForeColor = Color.Red;
                    label29.Text = "X";
                }

                //Задание 2 
                 if (radioButton6.Checked)
                {
                    //correct Answer
                    button6.Visible = false;
                    label38.ForeColor = Color.Green;
                    label38.Text = "✓";
                    label38.Visible = true;
                    correntAnswers += 1;
                }

                else if (radioButton4.Checked)
                {
                    button6.Visible = true;
                    label39.Visible = true;
                    label39.ForeColor = Color.Red;
                    label39.Text = "X";
                }

                else if (radioButton5.Checked)
                {
                    button6.Visible = true;
                    label40.Visible = true;
                    label40.ForeColor = Color.Red;
                    label40.Text = "X";
                }

                //Задание 3 
                 if (radioButton7.Checked)
                {
                    //correct answer
                    button8.Visible = false;
                    label42.Visible = true;
                    label42.ForeColor = Color.Green;
                    label42.Text = "✓";
                    correntAnswers += 1;
                }

                else if (radioButton9.Checked)
                {
                    button8.Visible = true;
                    label41.Visible = true;
                    label41.ForeColor = Color.Red;
                    label41.Text = "X";
                }

                else if (radioButton8.Checked)
                {
                    button8.Visible = true;
                    label43.Visible = true;
                    label43.ForeColor = Color.Red;
                    label43.Text = "X";
                }

                button5.BackColor = Color.Gray;
                button5.Enabled = false;

                label37.Text = "Итого:"+correntAnswers+"/3";
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

                label24.Text = "Результат:";
                int isNumEven = myVar % 2 == 0 ? 2 : -3;
                int currentNum = myVar;
                if (myVar > 23)
                {
                    currentNum = myVar - 23;
                }

                int remainderOfCurrentNum = 0;
                Console.WriteLine(isNumEven);
                Console.WriteLine(currentNum);
                for (int n = 0; n < 10; n++)
                {
                    if (currentNum >= 24)
                    {
                        remainderOfCurrentNum = currentNum - 23;
                        currentNum = 0 + remainderOfCurrentNum;
                    }

                    else if (currentNum <= 0)
                    {
                        remainderOfCurrentNum = currentNum + 23;
                        currentNum = 0 + remainderOfCurrentNum;
                    }

                    arrayOfNumbers.Append(currentNum);
                    Console.WriteLine(n + ":" + currentNum);
                    label24.Text += " " + currentNum;
                    currentNum = currentNum + isNumEven;
                }
            }
        }
    }
}
