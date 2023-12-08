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
    private double a = 1, b = 10, epsilon = 0.1;
    private int AccuracyForView;
    private string StringFunction;
    private Fuction fuction;

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

    private void ClearTextBox()
    {
      solutionTextBox.Text = "";
      textBox3.Text = "";
      textBox5.Text = "";
      textBox6.Text = "";
    }

    private void setupFunction()
    {
      if(textBox4.Text == "" || textBox4.Text == " ")
      {
        StringFunction = "(27 - 18 * x + 2 * x^2) * exp(-x/3)";
      }
      else
      {
        StringFunction = textBox4.Text;
      }
      fuction = new Fuction(StringFunction);
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
                        y = fuction.StandartFunction(x);
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

                double Accuracy = Math.Log10(epsilon) * -1.0;
                AccuracyForView = Convert.ToInt32(Accuracy);
                if(AccuracyForView < 0)
                {
                  AccuracyForView = 0;
                }
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
                double f1 = fuction.StandartFunction(x1);
                double f2 = fuction.StandartFunction(x3);

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

            double RoundResult = fuction.StandartFunction((x1 + x2) / 2);
            if (RoundResult > 1 || RoundResult < -1)
            {
                solutionTextBox.Text = "нет";
                textBox3.Text = "Нет значений";
            }
            else
            {
                solutionTextBox.Text = Convert.ToString(Math.Round(RoundResult, AccuracyForView));
                textBox3.Text = Convert.ToString(result);
            }
        }

    private void NewtonsPoint()
    {
      double x0, x1, x2;
      x0 = b;
      x1 = x0 - (fuction.StandartFunction(x0) / fuction.DerivFunction(x0));
      x2 = x1 - (fuction.StandartFunction(x1) / fuction.DerivFunction(x1));

      while (x1 - x2 >= epsilon)
      {
        x1 = x2;
        x2 = x1 - (fuction.StandartFunction(x1) / fuction.DerivFunction(x1));
      }

      double x = x2;
      double fx = fuction.StandartFunction(x2);

      if(x < a || x > b)
      {
        solutionTextBox.Text = "нет";
        textBox3.Text = "Нет значений";
        MessageBox.Show("x = " + x + "     fx = " + fx);
        return;
      }

      if (fx > 1 || fx < -1)
      {
        solutionTextBox.Text = "нет";
        textBox3.Text = "Нет значений";
        MessageBox.Show("x = " + x + "     fx = " + fx);
      }
      else
      {
        solutionTextBox.Text = Convert.ToString(Math.Round(fx, AccuracyForView));
        textBox3.Text = Convert.ToString(Math.Round(x, AccuracyForView));
      }
    }

        private void GoldenMethodPoint()
        {
      double start = a;
      double end = b;

      double phi = (1 + Math.Sqrt(5)) / 2;
      double h = end - start;
      double c = end - h / phi;
      double d = start + h / phi;
      double fc = fuction.AbsFunction(c);
      double fd = fuction.AbsFunction(d);

      while (Math.Abs(fc - fd) > epsilon)
      {
        if (fc < fd)
        {
          end = d;
          d = c;
          c = end - (end - start) / phi;
          fd = fc;
          fc = fuction.AbsFunction(c);
        }
        else
        {
          start = c;
          c = d;
          d = start + (end - start) / phi;
          fc = fd;
          fd = fuction.AbsFunction(d);
        }
      }

      double result = (start + end) / 2;
      textBox3.Text = Convert.ToString(Math.Round(result, AccuracyForView));
      solutionTextBox.Text = Convert.ToString(fuction.StandartFunction(result));
    }

        private void GoldenMethodMinimum()
        {
      double start = a;
      double end = b;

      double phi = (1 + Math.Sqrt(5)) / 2;
      double h = end - start;
      double c = end - h / phi;
      double d = start + h / phi;
      double fc = fuction.StandartFunction(c);
      double fd = fuction.StandartFunction(d);

      while (Math.Abs(fc - fd) > epsilon)
      {
        if (fc < fd)
        {
          end = d;
          d = c;
          c = end - (end - start) / phi;
          fd = fc;
          fc = fuction.StandartFunction(c);
        }
        else
        {
          start = c;
          c = d;
          d = start + (end - start) / phi;
          fc = fd;
          fd = fuction.StandartFunction(d);
        }
      }

      double result = (start + end) / 2;
      textBox5.Text = Convert.ToString(Math.Round(result, AccuracyForView));
    }

        private void GoldenMethodMaximum()
        {
      double start = a;
      double end = b;

      double phi = (1 + Math.Sqrt(5)) / 2;
      double h = end - start;
      double c = end - h / phi;
      double d = start + h / phi;
      double fc = fuction.MinusFunction(c);
      double fd = fuction.MinusFunction(d);

      while (Math.Abs(fc - fd) > epsilon)
      {
        if (fc < fd)
        {
          end = d;
          d = c;
          c = end - (end - start) / phi;
          fd = fc;
          fc = fuction.MinusFunction(c);
        }
        else
        {
          start = c;
          c = d;
          d = start + (end - start) / phi;
          fc = fd;
          fd = fuction.MinusFunction(d);
        }
      }

      double result = (start + end) / 2;
      textBox6.Text = Convert.ToString(Math.Round(result, AccuracyForView));
    }

        private void CoordinateDescent()
        {
            double x = (a + b) / 2;

            while (true)
            {
                if (x - epsilon <= a || x + epsilon >= b)
                {
                    break;
                }
                // смотрит в какой стороне меньше и тудап ходит (если слева значение функции меньше то идет туда, если нет то проверяент справа и если меньше то туда)
                if (fuction.StandartFunction(x) > fuction.StandartFunction(x - epsilon))
                {
                    x -= epsilon;
                }
                else if (fuction.StandartFunction(x) > fuction.StandartFunction(x + epsilon))
                {
                    x += epsilon;
                }
                else
                {
                    break;
                }
            }
      double result = Math.Round(x, AccuracyForView);

            textBox5.Text = result.ToString();
        }

        private void CoordinateDescentNegative()
        {
            double x = (a + b) / 2;

            while (true)
            {
                if (x - epsilon <= a || x + epsilon >= b)
                {
                    break;
                }
                // смотрит в какой стороне меньше и тудап ходит (если слева значение функции меньше то идет туда, если нет то проверяент справа и если меньше то туда)
                if (fuction.MinusFunction(x) > fuction.MinusFunction(x - epsilon))
                {
                    x -= epsilon;
                }
                else if (fuction.MinusFunction(x) > fuction.MinusFunction(x + epsilon))
                {
                    x += epsilon;
                }
                else
                {
                    break;
                }
            }
      double result = Math.Round(x, AccuracyForView);


      textBox6.Text = result.ToString();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void расчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* ParsFormView();

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
            }*/
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ClearMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            epsilonTextBox.Clear();
            chart1.Series[0].Points.Clear();
            ClearTextBox(); 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void вВЛучшийПрезидентИПреподToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЭТО ПРАВДА. ПОСТАВЬТЕ 10 БАЛЛОВ", "НЕ ОШИБКА");
        }

        private void calculateDichtomyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            ClearTextBox();

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
                    setupFunction(); 
                    Visualisation();
                    DichtomyMethod();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //эта текстбокс куда формула писать
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //минимум функции
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //максимум функции
        }

        private void calculateGoldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
      ParsFormView();
      ClearTextBox();
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
                    setupFunction();
                    Visualisation();
                    GoldenMethodPoint();
                 GoldenMethodMinimum();
                    GoldenMethodMaximum();
        }
      }
        }

        private void calculateNewtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            ClearTextBox();

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
                    setupFunction();
                    Visualisation();
                    NewtonsPoint();
                }
            }
        }

        private void calculateDecentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            ClearTextBox();

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
                    setupFunction();
                    Visualisation();
                    CoordinateDescent();
                    CoordinateDescentNegative();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void integralToolStripMenuItem_Click(object sender, EventArgs e)
        {
      Integral newForm = new Integral(this);
      this.Hide();
      newForm.Show();
        }

        private void epsilonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void solutionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
