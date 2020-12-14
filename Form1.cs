using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Flee.PublicTypes;


namespace int_diff_calcapp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            double x, fSumm = 0, f_result, f2Max = 0, f2_result, pogr = 0;
            double b = double.Parse(textBox1.Text);
            double a = double.Parse(textBox2.Text);
            double h = double.Parse(textBox3.Text);

            ExpressionContext context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            VariableCollection variables = context.Variables;
            variables.Add("pi", 3.14);
            variables.Add("e", 2.718);

            double n = Math.Abs((a - b) / h);
            double alpha = a + (h / 2.0);
            for (int k = 0; k < n; k++)
            {
                x = alpha + (h * (double)k);
                context.Variables["x"] = x;
                IDynamicExpression f = context.CompileDynamic(textBox4.Text);
                IDynamicExpression f2 = context.CompileDynamic(textBox12.Text);
                f_result = (double)f.Evaluate();
                f2_result = (double)f2.Evaluate();
                fSumm += f_result;
                if (f2Max < f2_result)
                {
                    f2Max = f2_result;
                }
            }
            pogr = Math.Round((Math.Pow((b - a), 3) * f2Max) / (24 * Math.Pow(n, 2)), 6);
            double integ = Math.Round(fSumm * h, 4);
            textBox6.Text += integ.ToString() + "\r \n";
            textBox13.Text += pogr.ToString() + "\r \n";
        }

        public double Diffirentiation(double x, double y, double h)
        {
            ExpressionContext context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            VariableCollection variables = context.Variables;
            context.Variables["x"] = x;
            context.Variables["y"] = y;
            IDynamicExpression f = context.CompileDynamic(textBox11.Text);
            return (h * (double)f.Evaluate());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Titles.Clear();
            textBox10.Clear();
            double k0, k1, k2, k3;
            double y = double.Parse(textBox8.Text);
            double x = double.Parse(textBox7.Text);
            double h = double.Parse(textBox5.Text);
            double b = double.Parse(textBox9.Text);
            List<double> xMass;
            List<double> yMass;
            xMass = new List<double>();
            yMass = new List<double>();

            for (double i = x; i < b+h; i += h)
            {
                i = Math.Round(i, 3);
                xMass.Add(i);
                yMass.Add(Math.Round(y, 3));
                k0 = Diffirentiation(i, y, h);
                k1 = Diffirentiation(i + (h / 2), y + (k0 / 2), h);
                k2 = Diffirentiation(i + (h / 2), y + (k1 / 2), h);
                k3 = Diffirentiation(i + h, y + k2, h);
                textBox10.Text += $"Значение X: {i, -7} Значение Y: {Math.Round(y, 3)}";
                y = y + (((double)1 / 6) * (k0 * (k1 + 2) * (k2 + 2) + k3));
                if (i != b) { textBox10.Text += "\r\n";}
            }
 
            chart1.Titles.Add("График функции f(x,y)");
            for (int i = 0; i < xMass.Count; i++)
            {
                chart1.Series["F(x,y)"].Points.AddXY(xMass[i], yMass[i]);
            }
        }
    }
}
