using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DichtomyApp
{
    public partial class Integral : Form
    {
        Fuction fuction;
        double a, b, epsilon;
        int AccuracyForView, Steps;
        Form1 MainForm;

        public Integral(Form1 Form)
        {
            InitializeComponent();
            MainForm = Form;
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
                a = Convert.ToDouble(lowerIntegral.Text);
                b = Convert.ToDouble(upperIntegral.Text);
                epsilon = Convert.ToDouble(epsilonTextBox.Text);

                double Accuracy = Math.Log10(epsilon) * -1.0;
                AccuracyForView = Convert.ToInt32(Accuracy);
                if (AccuracyForView < 0)
                {
                    AccuracyForView = 0;
                }

                   Steps = Convert.ToInt32(countOfSteps.Text);                 
                if(Steps <= 0)
                {
                  Steps = 1;
                  MessageBox.Show("Количество шагов неверно", "Ошибка");
                }
              }
              catch
              {
                  MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка");
              }
          }

        private void setupFunction()
        {
            string StringFunction;
            if (formulaIntegral.Text == "" || formulaIntegral.Text == " ")
            {
                StringFunction = "(27 - 18 * x + 2 * x^2) * exp(-x/3)";
            }
            else
            {
                StringFunction = formulaIntegral.Text;
            }
            fuction = new Fuction(StringFunction);
        }

    private double Rectangle(double Splits)
    {
      double start = a;
      double end = b;

      double h = (end - start) / Splits;
      double sum = (fuction.StandartFunction(start) + fuction.StandartFunction(end)) / 2;

      for (int i = 1; i < Splits; i++)
      {
        double x = start + i * h;
        sum += fuction.StandartFunction(x);
      }

      double result = h * sum;
      return result;
    }

    private double Trapezoid(double Splits)
    {
      double start = a;
      double end = b;

      double h = (end - start) / Splits;
      double sum = fuction.StandartFunction(start) + fuction.StandartFunction(end);

      for(int i = 1; i <= Splits - 1; i++)
      {
        sum += 2 * fuction.StandartFunction(start + i * h);
      }

      double result = sum * h / 2;
      return result;
    }

    private double Simpson(double Splits) {
      double sumST = Trapezoid(Splits);
      double sumST2 = Trapezoid(Splits * 2);

      double result = (4 * sumST2 - sumST) / 3;
      return result;
    }

    private void RectangleMethod()
    {
      double result = Rectangle(Steps);

      double roundResult = Math.Truncate(result * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
      rectangleResult.Text = roundResult.ToString();
    }

    private void TrapezoidMethod()
    {
      double result = Trapezoid(Steps);

      double roundResult = Math.Truncate(result * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
      trapeseResult.Text = roundResult.ToString();
    }

    private void SimpsonMethod()
    {
      double result = Simpson(Steps);

      double roundResult = Math.Truncate(result * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
      simpsonResult.Text = roundResult.ToString();
    }

    private void SecondTask()
    {
      double RectangleRount = 0;
      double TrapezRount = 0;
      double SimpsonRount = 0;
      double Splits = 2;

      while (true)
      {
        double Sr = Rectangle(Splits);
        double St = Trapezoid(Splits);
        double Ss = Simpson(Splits);

        RectangleRount = Math.Truncate(Sr * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
        TrapezRount = Math.Truncate(St * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);
        SimpsonRount = Math.Truncate(Ss * Math.Pow(10, AccuracyForView)) / Math.Pow(10, AccuracyForView);

        rectangleResult.Text = RectangleRount.ToString();
        trapeseResult.Text = TrapezRount.ToString();
        simpsonResult.Text = SimpsonRount.ToString();
        countOfSteps.Text = Splits.ToString();
        this.Update();

        if(RectangleRount == TrapezRount && TrapezRount == SimpsonRount && RectangleRount == SimpsonRount)
        {
          break;
        }
        ++Splits;
      }
    }


    private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Integral_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
      
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void formulaIntegral_TextChanged(object sender, EventArgs e)
        {

        }

        private void lowerIntegral_TextChanged(object sender, EventArgs e)
        {

        }

        private void upperIntegral_TextChanged(object sender, EventArgs e)
        {

        }

        private void epsilon_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rectangleResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void countOfSteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateFiotstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            setupFunction();
            Visualisation();

            if (rectangleCheckBox.Checked)
            {
                RectangleMethod();
            }
            if (trapeseCheckBox.Checked)
            {
                TrapezoidMethod();
            }

            if (simpsonCheckBox.Checked) 
            {
                SimpsonMethod();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calculateSecondTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
      ParsFormView();
      setupFunction();
      Visualisation();

      SecondTask();
    }

        private void trapeseResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpsonResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void mathFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
      this.Close();
      MainForm.Show();
        }
    }
}
