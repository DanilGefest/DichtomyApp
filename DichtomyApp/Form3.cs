using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace DichtomyApp
{
    public partial class SLAE : Form
    {
         double[,] excelTable;

         int N = 0;

        Form1 MainForm;
        public SLAE(Form1 Form)
        {
            InitializeComponent();
            MainForm = Form;
        }

    
       class CramerMethod
    {
      int N;
      double[,] Matrix;
      double[,] MatrixA;
      double[] MatrixB;

      public CramerMethod(double[,] matrix, int N)
      {
        this.N = N;
        Matrix = matrix;
        MatrixA = new double[N, N];
        MatrixB = new double[N];
      }

      static double determinant(double[,] m)
      {
        int numRows = m.GetLength(0);
        int numCols = m.GetLength(1);
        int n = numCols;
        double[,] matrix = new double[n, n];
        matrix = m;

        for (int k = 1; k < n; k++)
        {
          for (int i = k; i < n; i++)
          {
            double C = matrix[i, k - 1] / matrix[k - 1, k - 1];
            for (int j = 0; j < numCols; j++)
            {
              matrix[i, j] -= C * matrix[k - 1, j];
            }
          }
        };
        double result = 1;
        for (int i = 0; i < n; i++)
        {
          result *= matrix[i, i];
        };
        return result;
      }

      private void ShareMatrix()
      {
        for (int i = 0; i < N; ++i)
        {
          for (int j = 0; j < N; ++j)
          {
            MatrixA[i, j] = Matrix[i, j];
          }
        }

        for (int i = 0; i < N; ++i)
        {
          MatrixB[i] = Matrix[i, N];
        }
      }

      public double[] Cramer()
      {
        ShareMatrix();
        double[,] MatrixForDet = MatrixA.Clone() as double[,];
        double detMatrix = determinant(MatrixForDet);
        double[] result = new double[N];

        for (int c = 0; c < N; ++c)
        {
          double[,] NewMatriX = new double[N, N];
          for (int i = 0; i < N; ++i)
          {
            for (int j = 0; j < N; ++j)
            {
              if (j == c)
              {
                NewMatriX[i, j] = MatrixB[i];
              }
              else
              {
                NewMatriX[i, j] = MatrixA[i, j];
              }
            }
          }
          result[c] = determinant(NewMatriX) / detMatrix;
        }
        return result;
      }
    }

    class GaussMethod
    {
      int n;
      double[,] Matrix;
      double[,] a;
      double[] b;
      public GaussMethod(double[,] matrix, int N)
      {
        this.n = N;
        Matrix = matrix;
        a = new double[n + 1, n + 1];
        b = new double[n + 1];
      }

      private void ShareMatrix()
      {
        for (int i = 0; i < n; ++i)
        {
          for (int j = 0; j < n; ++j)
          {
            a[i, j] = Matrix[i, j];
          }
        }

        for (int i = 0; i < n; ++i)
        {
          b[i] = Matrix[i, n];
        }
      }

      private static bool Solve(double[,] M)
      {
        // input checks
        int rowCount = M.GetUpperBound(0) + 1;
        if (M == null || M.Length != rowCount * (rowCount + 1))
          throw new ArgumentException("The algorithm must be provided with a (n x n+1) matrix.");
        if (rowCount < 1)
          throw new ArgumentException("The matrix must at least have one row.");

        // pivoting
        for (int col = 0; col + 1 < rowCount; col++) if (M[col, col] == 0)
          // check for zero coefficients
          {
            // find non-zero coefficient
            int swapRow = col + 1;
            for (; swapRow < rowCount; swapRow++) if (M[swapRow, col] != 0) break;

            if (M[swapRow, col] != 0) // found a non-zero coefficient?
            {
              // yes, then swap it with the above
              double[] tmp = new double[rowCount + 1];
              for (int i = 0; i < rowCount + 1; i++)
              { tmp[i] = M[swapRow, i]; M[swapRow, i] = M[col, i]; M[col, i] = tmp[i]; }
            }
            else return false; // no, then the matrix has no unique solution
          }

        // elimination
        for (int sourceRow = 0; sourceRow + 1 < rowCount; sourceRow++)
        {
          for (int destRow = sourceRow + 1; destRow < rowCount; destRow++)
          {
            double df = M[sourceRow, sourceRow];
            double sf = M[destRow, sourceRow];
            for (int i = 0; i < rowCount + 1; i++)
              M[destRow, i] = M[destRow, i] * df - M[sourceRow, i] * sf;
          }
        }

        // back-insertion
        for (int row = rowCount - 1; row >= 0; row--)
        {
          double f = M[row, row];
          if (f == 0) return false;

          for (int i = 0; i < rowCount + 1; i++) M[row, i] /= f;
          for (int destRow = 0; destRow < row; destRow++)
          { M[destRow, rowCount] -= M[destRow, row] * M[row, rowCount]; M[destRow, row] = 0; }
        }
        return true;
      }

      public double[] Gauss()
      {
        Solve(Matrix);
        ShareMatrix();
        double[] result = new double[n];

        for (int i = 0; i < n; ++i)
        {
          result[i] = b[i] / a[i, i];
        }

        return result;
      }
    }

    class GaussJordanMethod
    {
      int N;
      double[,] Matrix;
      double[,] MatrixA;
      double[] MatrixB;

      public GaussJordanMethod(double[,] matrix, int N)
      {
        this.N = N;
        Matrix = matrix;
        MatrixA = new double[N, N];
        MatrixB = new double[N];
      }

      private void ShareMatrix()
      {
        for (int i = 0; i < N; ++i)
        {
          for (int j = 0; j < N; ++j)
          {
            MatrixA[i, j] = Matrix[i, j];
          }
        }

        for (int i = 0; i < N; ++i)
        {
          MatrixB[i] = Matrix[i, N];
        }
      }

      private double[,] ToDiagonal(double[,] Matrix)
      {
        double[,] Result = Matrix;

        for (int LeadingElement = 0; LeadingElement < N; ++LeadingElement)
        {
          for (int RowIndex = 0; RowIndex < N; ++RowIndex)
          {
            if (RowIndex != LeadingElement)
            {
              for (int ClolumnIndex = 0; ClolumnIndex < N; ++ClolumnIndex)
              {
                if (ClolumnIndex != LeadingElement)
                {
                  Result[RowIndex, ClolumnIndex] = (Result[RowIndex, ClolumnIndex] * Result[LeadingElement, LeadingElement]) - (Result[RowIndex, LeadingElement] * Result[LeadingElement, ClolumnIndex]);
                }
              }
            }
          }

          for (int RowIndex = 0; RowIndex < N; ++RowIndex)
          {
            if (RowIndex != LeadingElement)
            {
              Result[LeadingElement, RowIndex] = 0;
            }
          }
        }

        for (int DiagonalIndex = 0; DiagonalIndex < N; ++DiagonalIndex)
        {
          if (Result[DiagonalIndex, DiagonalIndex] == 0)
          {
            return Result;
          }
        }

        bool Key = true;
        for (int DiagonalIndex = 0; DiagonalIndex < N; ++DiagonalIndex)
        {
          if (Result[DiagonalIndex, DiagonalIndex] % Result[N - 1, N - 1] != 0)
          {
            Key = false;
          }
        }
        if (Key = true)
        {
          for (int DiagonalIndex = 0; DiagonalIndex < N; ++DiagonalIndex)
          {
            Result[DiagonalIndex, DiagonalIndex] = Result[DiagonalIndex, DiagonalIndex] / Result[N - 1, N - 1];
          }
        }
        return Result;
      }


      public double[] GaussJordan()
      {
        ToDiagonal(Matrix);
        ShareMatrix();
        double[] result = new double[N];

        for (int i = 0; i < N; ++i)
        {
          result[i] = MatrixB[i] / MatrixA[i, i];
        }

        return result;
      }
    }

    private bool setValue()
    {
      try
      {
        N = Convert.ToInt32(nTextBox.Text);

        if (N < 2)
        {
          N = 2;
          MessageBox.Show("n должно быть больше 2", "Внимание");
        }
        if (N > 50)
        {
          N = 50;
          MessageBox.Show("n должно быть меньше 50", "Внимание");
        }
        excelTable = new double[N, N+1];
        return true;
      }
      catch
      {
        N = 1;
        MessageBox.Show("некорректное значение n", "Ошибка");
        return false;
      }
    }

    private void GenerateRandomMatrix()
    {
      Random r = new Random();

      for (int i = 0; i < N; ++i)
      {
        for (int j = 0; j < N+1; ++j)
        {
          excelTable[i, j] = r.Next(-10, 10);
        }
      }
    }

    private void createMatrix()
    {
      dataGridView1.RowCount = N;
      dataGridView1.ColumnCount = N+1;
    }

    private void showMatrix()
    {
      for (int i = 0; i < N; ++i)
      {
        for (int j = 0; j < N+1; ++j)
        {
          dataGridView1.Rows[i].Cells[j].Value = excelTable[i, j];
        }
      }
    }

    private void MatrixFromView()
    {
      try
      {
        for (int i = 0; i < N; ++i)
        {
          for (int j = 0; j < N+1; ++j)
          {
            if (dataGridView1.Rows[i].Cells[j].Value == "" || dataGridView1.Rows[i].Cells[j].Value == " ")
            {
              excelTable[i, j] = 0;
            }
            else
            {
              try
              {
                excelTable[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
              }
              catch
              {
                MessageBox.Show("Некорректный ввод", "Ошибка");
              }
            }
          }
        }
      }
      catch
      {
        //какая то ошибка
      }
    }

    private bool EmptyMatrix()
    {
      int countNull = 0;
      for (int i = 0; i < N; ++i)
      {
        for (int j = 0; j < N+1; ++j)
        {
          if (Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value) == 0d)
          {
            ++countNull;
          }
        }
      }
      if (countNull == N * N + N)
      {
        return false;
      }
      else
      {
        return true;
      }
    }

    private void FillAnswer(double[] Mass, int index)
    {
      for (int i = 0; i < N; ++i)
      {
        dataGridView2.Rows[i].Cells[index].Value = Mass[i];
      }
    }

    private void cramer()
    {
      CramerMethod cm = new CramerMethod(excelTable, N);
      double[] result = cm.Cramer();
      FillAnswer(result, 0);
    }

    private void gauss()
    {
      GaussMethod gm = new GaussMethod(excelTable, N);
      double[] result = gm.Gauss();
      FillAnswer(result, 2);
    }

    private void gaussJordan()
    {
      GaussJordanMethod gjm = new GaussJordanMethod(excelTable, N);
      double[] result = gjm.GaussJordan();
      FillAnswer(result, 1);
    }
    


    private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void нижнийПорогToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void otherTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mathFunktionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.Show();
        }

        private void clearMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nTextBox.Clear();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

        }

        static double determinant(double[,] m)
    {
      int numRows = m.GetLength(0);
      int numCols = m.GetLength(1);
      int n = numCols;
      double[,] matrix = new double[n, n];
      matrix = m;

      for (int k = 1; k < n; k++)
      {
        for (int i = k; i < n; i++)
        {
          double C = matrix[i, k - 1] / matrix[k - 1, k - 1];
          for (int j = 0; j < numCols; j++)
          {
            matrix[i, j] -= C * matrix[k - 1, j];
          }
        }
      };
      double result = 1;
      for (int i = 0; i < n; i++)
      {
        result *= matrix[i, i];
      };
      return result;
    }

    private void getExel()
    {
      double[,] Table;
      int Rows = 0;
      int Columns = 0;

      try
      {
        DialogResult res = openFileDialog1.ShowDialog();
        if (res == DialogResult.OK)
        {
          ExcelPackage excelFile = new ExcelPackage(new FileInfo(openFileDialog1.FileName));
          ExcelWorksheet worksheet = excelFile.Workbook.Worksheets[1]; //индекс листа, котрый импортируем, добавь комбобокс
          Rows = worksheet.Dimension.End.Row;
          Columns = worksheet.Dimension.End.Column; // колл-во строк и столбцов из хцеля передаются в переменные. добавить обработчик ошибки на неквадратность конечной импортируемой матрицы

          Table = new double[Rows, Columns];

          for (int rowIndex = 1; rowIndex <= Rows; rowIndex++)
          {
            IEnumerable<string> row = worksheet.Cells[rowIndex, 1, rowIndex, Columns].Select(c => c.Value == null ? string.Empty : c.Value.ToString());

            List<string> list = row.ToList<string>();

            for (int i = 0; i < list.Count; i++)
            {
              Table[rowIndex - 1, i] = Convert.ToDouble(list[i].Replace('.', ','));
            }
          }

          excelTable = Table;
          N = Rows;
        }
        else
        {
          throw new Exception("Не выбран файл!");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
      getExel();
      createMatrix();
      showMatrix();
      nTextBox.Text = N.ToString();
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (setValue())
            {
                createMatrix();
            }
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (setValue() && EmptyMatrix())
            {
                MatrixFromView();
                dataGridView2.RowCount = N;

                if (kramerCheckBox.Checked)
                {
                    double[,] MatrixA = new double[N, N];
                    for (int i = 0; i < N; ++i)
                    {
                        for (int j = 0; j < N; ++j)
                        {
                            MatrixA[i, j] = excelTable[i, j];
                        }
                    }
                    double[,] MatrixForDet = MatrixA.Clone() as double[,];
                    double detMatrix = determinant(MatrixForDet);
                    if (detMatrix == 0)
                    {
                        MessageBox.Show("Определитель равен нулю. Система имеет бесконечное количестов решений", "Внимание");
                    }
                    else
                    {
                        cramer();
                    }
                }

                if (gaussCheckBox.Checked)
                {
                    gauss();
                }

                if (gaussJordanaCheckBox.Checked)
                {
                    gaussJordan();
                }
            }
        }

        private void gaussJordanaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kramerCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void generateToolStripMenuItem_Click(object sender, EventArgs e)
        {
      if (setValue())
      {
        dataGridView1.Rows.Clear();
        createMatrix();
        GenerateRandomMatrix();
        showMatrix();
      }
    }
    }
}
