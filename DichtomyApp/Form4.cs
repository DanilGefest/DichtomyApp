using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DichtomyApp
{
    public partial class Form4 : Form
    {
    List<double> MassY = new List<double>();
    List<double> MassX = new List<double>();
    double Start, End, Epsilon;
    string Function;
    int AccuracyForView;

    
    Form1 MainForm;
    public Form4(Form1 Form)
        {
      InitializeComponent();
      MainForm = Form;
    }


    
    private bool getValue()
    {
      try
      {
        int Count = dataGridView1.Rows.Count;
        for (int i = 0; i < Count; ++i)
        {
          MassY.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value));
          MassX.Add(Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value));
        }
      }
      catch
      {
        MessageBox.Show("Данные введены неверно", "Ошибка");
        return false;
      }
      try
      {
        Epsilon = Convert.ToDouble(epsilonTextBox.Text);
        double Accuracy = Math.Log10(Epsilon) * -1.0;
        AccuracyForView = Convert.ToInt32(Accuracy);
        if (AccuracyForView < 0)
        {
          AccuracyForView = 0;
        }
      }
      catch
      {
        Epsilon = 0.01;
        AccuracyForView = 3;
      }
      return true;
    }

    private void setMinMaxValue()
    {
      Start = MassX.Min();
      End = MassX.Max();
    }

    private void CreateViewGraf(string StringFunction)
    {
      Fuction f = new Fuction(StringFunction);
      double Step = (End - Start) / 50;

      System.Windows.Forms.DataVisualization.Charting.Series MainSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
      MainSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      MainSeries.BorderWidth = 3;
      MainSeries.Color = Color.CornflowerBlue;
      this.chart1.Series.Add(MainSeries);

      for (double x = Start; x < End; x += Step)
      {
        double y = f.StandartFunction(x);
        chart1.Series[0].Points.AddXY(x, y);
        this.Update();
      }
    }

    private void CreateViewPoints()
    {
      for (int i = 0; i < MassX.Count; ++i)
      {
        System.Windows.Forms.DataVisualization.Charting.Series Point = new System.Windows.Forms.DataVisualization.Charting.Series();
        Point.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
        Point.Color = Color.Pink;
        Point.BorderWidth = 4;
        Point.Points.AddXY(MassX[i], MassY[i]);
        chart1.Series.Add(Point);
      }
    }

    private string ConvertRount(double a, bool Sign)
    {
      string result = "";
      if (Sign)
      {
        if (a >= 0)
        {
          result = "+";
        }
        else
        {
          result = "-";
        }
      }
      result += Convert.ToString(Math.Round(Math.Abs(a), AccuracyForView));
      return result;
    }

    private string LinearFunction()
    {
      int N = dataGridView1.Rows.Count;
      double sumX = 0, sumY = 0, sumXY = 0, sumXX = 0;

      for (int i = 0; i < N; ++i)
      {
        sumX += MassX[i];
        sumY += MassY[i];
        sumXY += MassX[i] * MassY[i];
        sumXX += MassX[i] * MassX[i];
      }

      double a = (N * sumXY - sumX * sumY) / (N * sumXX - sumX * sumX);
      double b = (sumY - a * sumX) / N;
      string result = a + " * x + (" + b + ")";
      result = result.Replace(',', '.');
      Function = result;
      Console.WriteLine(result);
      textBox4.Text = ConvertRount(a, false) + " x " + ConvertRount(b, true);
      return result;
    }

    private void GoldenMethodPoint(string f)
    {
      Fuction function = new Fuction(f);
      double start = Start;
      double end = End;

      double phi = (1 + Math.Sqrt(5)) / 2;
      double h = end - start;
      double c = end - h / phi;
      double d = start + h / phi;
      double fc = function.AbsFunction(c);
      double fd = function.AbsFunction(d);

      while (Math.Abs(fc - fd) > Epsilon)
      {
        if (fc < fd)
        {
          end = d;
          d = c;
          c = end - (end - start) / phi;
          fd = fc;
          fc = function.AbsFunction(c);
        }
        else
        {
          start = c;
          c = d;
          d = start + (end - start) / phi;
          fc = fd;
          fd = function.AbsFunction(d);
        }
      }

      double result = (start + end) / 2;
      textBox3.Text = Convert.ToString(Math.Round(result, AccuracyForView));
      functionTextBox.Text = Convert.ToString(function.StandartFunction(result));
    }

    private void GoldenMethodMinimum(string f)
    {
      Fuction function = new Fuction(f);
      double start = Start;
      double end = End;

      double phi = (1 + Math.Sqrt(5)) / 2;
      double h = end - start;
      double c = end - h / phi;
      double d = start + h / phi;
      double fc = function.StandartFunction(c);
      double fd = function.StandartFunction(d);

      while (Math.Abs(fc - fd) > Epsilon)
      {
        if (fc < fd)
        {
          end = d;
          d = c;
          c = end - (end - start) / phi;
          fd = fc;
          fc = function.StandartFunction(c);
        }
        else
        {
          start = c;
          c = d;
          d = start + (end - start) / phi;
          fc = fd;
          fd = function.StandartFunction(d);
        }
      }

      double result = (start + end) / 2;
      textBox5.Text = Convert.ToString(Math.Round(result, AccuracyForView));
    }

    private void GoldenMethodMaximum(string f)
    {
      Fuction function = new Fuction(f);
      double start = Start;
      double end = End;

      double phi = (1 + Math.Sqrt(5)) / 2;
      double h = end - start;
      double c = end - h / phi;
      double d = start + h / phi;
      double fc = function.MinusFunction(c);
      double fd = function.MinusFunction(d);

      while (Math.Abs(fc - fd) > Epsilon)
      {
        if (fc < fd)
        {
          end = d;
          d = c;
          c = end - (end - start) / phi;
          fd = fc;
          fc = function.MinusFunction(c);
        }
        else
        {
          start = c;
          c = d;
          d = start + (end - start) / phi;
          fc = fd;
          fd = function.MinusFunction(d);
        }
      }

      double result = (start + end) / 2;
      textBox6.Text = Convert.ToString(Math.Round(result, AccuracyForView));
    }

    private void ExtremumFunction(string Function)
    {
      GoldenMethodPoint(Function);
      GoldenMethodMinimum(Function);
      GoldenMethodMaximum(Function);
    }

    private void ClearDate()
    {
      MassY = new List<double>();
      MassX = new List<double>();
      Start = new double();
      End = new double();
    }

    private void ClearFunc()
    {
      textBox1.Text = "";
      epsilonTextBox.Text = "";
      textBox4.Text = "";
      functionTextBox.Text = "";
      textBox5.Text = "";
      textBox6.Text = "";
        }
    
    private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            ClearDate();
            if (getValue())
            {
                chart1.Series.Clear();
                setMinMaxValue();
        CreateViewGraf(LinearFunction());
        CreateViewPoints();
        ExtremumFunction(Function);
            }
      
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
      chart1.Series.Clear();
      dataGridView1.Rows.Clear();
      ClearFunc();
    }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void epsilonTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      Random r = new Random();
      int Count;
      try
      {
        Count = Convert.ToInt32(textBox1.Text);
      }
      catch
      {
        MessageBox.Show("Точность указана неверно", "Ошибка");
        return;
      }
      ClearDate();
      chart1.Series.Clear();
      dataGridView1.RowCount = Count;
      dataGridView1.ColumnCount = 2;

      bool FuncType = radioButton1.Checked;
      switch (FuncType)
      {
        case true: //Прямая
          int x = r.Next(-Count, Count);
          int al = r.Next(-20, 20);
          int bl = r.Next(-50, 50);
          string LineFunction = al + "x + " + bl;
          Fuction lcalculate = new Fuction(LineFunction);
          for (int i = 0; i < Count; ++i)
          {
            x = r.Next(x - Count, x + Count);
            dataGridView1.Rows[i].Cells[0].Value = lcalculate.StandartFunction(x + r.Next(-Count, Count));
            dataGridView1.Rows[i].Cells[1].Value = x;
          }
          break;
        case false: //Рандом
          for (int i = 0; i < Count; ++i)
          {
            int randomY = r.Next(-Count, Count);
            int randomX = r.Next(-Count, Count);
            dataGridView1.Rows[i].Cells[0].Value = randomY + r.NextDouble();
            dataGridView1.Rows[i].Cells[1].Value = randomX + r.NextDouble();
          }
          break;
        default:
          break;
      }
      getValue();
      CreateViewPoints();
    }

    private void label5_Click(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void functionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void otherTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mathFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Show();
         }
    }
}
