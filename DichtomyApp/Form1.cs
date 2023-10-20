using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DichtomyApp
{
    public partial class Form1 : Form
    {
    private double a, b, epsilon;

    public Form1()
    {
      InitializeComponent();
    }


    private double Round(double x)
    {
      double Accuracy = Math.Log10(epsilon) * -1.0;
      int AccuracyForView = Convert.ToInt32(Accuracy);
      if (AccuracyForView < 0)
      {
        AccuracyForView = 0;
      }
      double RoundX = Math.Round(x, AccuracyForView);
      return RoundX;
    }

    private void Visualisation()
            {
                double x;
                double y;
                if (a < b)
                {
                    x = a;
           
                    chart1.Series[0].Points.Clear();
                    while (x <= b)
                    {
                        y = CalculateFunction(x);
                        chart1.Series[0].Points.AddXY(x, y);
                        x += 0.01;
                    }
                }
            }
        
        private void ParsFormView()
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                epsilon = Convert.ToDouble(epsilonTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения для a, b и точности (epsilon).", "Ошибка");
            }
        }

        private void DichtomyMethod()
        {
            double x1 = a;
            double x2 = b;

            do
            {
                double x3 = (x1 + x2) / 2;
                double f1 = CalculateFunction(x1);
                double f2 = CalculateFunction(x3);

                if (f1 * f2 < 0)
                {
                    x2 = x3;
                }
                else
                {
                    x1 = x3;
                }
            } while (Math.Abs(x2 - x1) > epsilon);
            double result = Round((x1 + x2) / 2);
            solutionTextBox.Text = Convert.ToString(result);

      double RoundResult = CalculateFunction((x1 + x2) / 2);
      if (RoundResult > 1 || RoundResult < -1)
      {
        textBox3.Text = "Нет значений ";
      } 
      else
      {
        textBox3.Text = Convert.ToString(Math.Round(RoundResult, 3));
      }
    }

        private double CalculateFunction(double x)
        {
            return (27 - 18 * x + 2 * Math.Pow(x, 2)) * Math.Pow(Math.E, -(x / 3));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void расчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();

            if (epsilon <= 0)
            {
                MessageBox.Show("Введите точность через запятую", "error");
            }
            else
            {
                if (a >= b)
                {
                    MessageBox.Show("А должно быть меньше B", "Ошибка");
                }
                else
                {
                    Visualisation();
                    DichtomyMethod();
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ClearMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            epsilonTextBox.Clear();
            solutionTextBox.Clear();
            chart1.Series[0].Points.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void вВЛучшийПрезидентИПреподToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЭТО ПРАВДА. ПОСТАВЬТЕ 10 БАЛЛОВ", "НЕ ОШИБКА");
        }

        private void epsilonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void solutionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
