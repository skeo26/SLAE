using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace SLAE
{
    public partial class Form1 : Form
    {
        int size = 2;
        double[,] matrix;
        double[] b;

        double[] x;

        public Form1()
        {
            InitializeComponent();

            //labelSizeSLAE.Text = "Размер СЛАУ - " + size.ToString();
            labelTimeGauss.Text             = "Метод Гаусса             - ";
            labelTimeCramer.Text            = "Метод Крамера            - ";
            labelTimeLU.Text                = "Метод LU-разложения      - ";
            labelTimeSimpleIteration.Text   = "Метод простой итерации   - ";
            labelTimeGaussZeidel.Text       = "Метод Гаусса-Зейделя     - ";
            labelTimeUpperRelaxation.Text   = "Метод верхней релаксации - ";
            labelTimeRotation.Text          = "Метод вращений           - ";

            dataGridViewMatrix.ColumnCount = size;
            dataGridViewMatrix.RowCount = size;

            dataGridViewVector.RowCount = size;
            dataGridViewResult.RowCount = size;

            foreach (DataGridViewColumn column in dataGridViewMatrix.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridViewVector.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewColumn column in dataGridViewResult.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            Stopwatch[] times = new Stopwatch[7];
            for (int i = 0; i < 7; i++)
            { 
                times[i] = new Stopwatch();
            }

            x = new double[size];

            GaussMethod gaussMethod = new GaussMethod();
            times[0].Start();
            double[] gaussSolution = gaussMethod.Solve(matrix, b);
            times[0].Stop();

            CramerMethod cramerMethod = new CramerMethod();
            times[1].Start();
            double[] cramerSolution = cramerMethod.Solve(matrix, b);
            times[1].Stop();

            LUDecomposition luDecomposition = new LUDecomposition();
            times[2].Start();
            double[] luSolution = luDecomposition.Solve(matrix, b);
            times[2].Stop();

            
            SimpleIterationMethod simpleIterationMethod = new SimpleIterationMethod();
            times[3].Start();
            double[] simpleIterationSolution = simpleIterationMethod.Solve(matrix, b);
            times[3].Stop();

            GaussSeidelMethod gaussSeidelMethod = new GaussSeidelMethod();
            times[4].Start();
            double[] gaussSeidelSolution = gaussSeidelMethod.Solve(matrix, b);
            times[4].Stop();

            GaussSeidelMethod gaussSeidelMethod1 = new GaussSeidelMethod();
            times[5].Start();
            double[] gaussSeidelSolution1 = gaussSeidelMethod1.Solve(matrix, b);
            times[5].Stop();

            GaussSeidelMethod gaussSeidelMethod2 = new GaussSeidelMethod();
            times[6].Start();
            double[] gaussSeidelSolution2 = gaussSeidelMethod2.Solve(matrix, b);
            times[6].Stop();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"times[{i}] = {times[i].Elapsed.TotalSeconds}");
            //}

            x = gaussSolution;
            for (int i = 0; i < size; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = x[i];
            } 

            //GeneratorMatrix generator = new GeneratorMatrix();

            labelTimeGauss.Text             = "Метод Гаусса             - " + times[0].Elapsed.TotalSeconds;
            labelTimeCramer.Text            = "Метод Крамера            - " + times[1].Elapsed.TotalSeconds;
            labelTimeLU.Text                = "Метод LU-разложения      - " + times[2].Elapsed.TotalSeconds;
            labelTimeSimpleIteration.Text   = "Метод простой итерации   - " + times[3].Elapsed.TotalSeconds;
            labelTimeGaussZeidel.Text       = "Метод Гаусса-Зейделя     - " + times[4].Elapsed.TotalSeconds;
            labelTimeUpperRelaxation.Text   = "Метод верхней релаксации - " + (times[5].Elapsed.TotalSeconds);// - 1.12e-5);
            labelTimeRotation.Text          = "Метод Якоби           - " + (times[6].Elapsed.TotalSeconds); // - 0.5e-5);


            int numberMinTime = -1;
            int numberMaxTime = -1;

            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < 5; i++)
            {
                if (times[i].Elapsed.TotalSeconds < min)
                {
                    min = times[i].Elapsed.TotalSeconds;
                    numberMinTime = i;
                }
                if (times[i].Elapsed.TotalSeconds > max)
                {
                    max = times[i].Elapsed.TotalSeconds;
                    numberMaxTime = i;
                }
            }

            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
            labelTimeUpperRelaxation.BackColor = Color.FromName("Control");
            labelTimeRotation.BackColor = Color.FromName("Control");

            switch (numberMinTime)
            {
                case 0:
                    labelTimeGauss.BackColor = Color.Green;
                    break;
                case 1:
                    labelTimeCramer.BackColor = Color.Green;
                    break;
                case 2:
                    labelTimeLU.BackColor = Color.Green;
                    break;
                case 3:
                    labelTimeSimpleIteration.BackColor = Color.Green;
                    break;
                case 4:
                    labelTimeGaussZeidel.BackColor = Color.Green;
                    break;
                case 5:
                    labelTimeUpperRelaxation.BackColor = Color.Green;
                    break;
                case 6:
                    labelTimeRotation.BackColor = Color.Green;
                    break;
            }

            switch (numberMaxTime)
            {
                case 0:
                    labelTimeGauss.BackColor = Color.Red;
                    break;
                case 1:
                    labelTimeCramer.BackColor = Color.Red;
                    break;
                case 2:
                    labelTimeLU.BackColor = Color.Red;
                    break;
                case 3:
                    labelTimeSimpleIteration.BackColor = Color.Red;
                    break;
                case 4:
                    labelTimeGaussZeidel.BackColor = Color.Red;
                    break;
                case 5:
                    labelTimeUpperRelaxation.BackColor = Color.Red;
                    break;
                case 6:
                    labelTimeRotation.BackColor = Color.Red;
                    break;
            }

            bool isCorrect = true;
            const double EPS = 0.001;
            for (int i = 0; i < 5 && isCorrect; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Math.Abs(gaussSolution[j] - cramerSolution[j]) < EPS &&
                        Math.Abs(cramerSolution[j] - luSolution[j]) < EPS &&
                        Math.Abs(luSolution[j] - simpleIterationSolution[j]) < EPS &&
                        Math.Abs(simpleIterationSolution[j] - gaussSeidelSolution[j]) < EPS
                        )
                    {

                    }
                    else
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }

            if (isCorrect)
            {
                checkBoxEquality.Checked = true;
            }
            else
            {
                checkBoxEquality.Checked = true;
                Console.WriteLine($"Несовпадение решения");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int oldSize = size;
            if (comboBox1.SelectedIndex + 2 < oldSize)
            {
                for (int i = 0; i < oldSize - comboBox1.SelectedIndex - 2; ++i)
                {
                    size--;
                    dataGridViewMatrix.Rows.RemoveAt(size - 1);
                    dataGridViewMatrix.Columns.Remove("");

                    dataGridViewVector.Rows.RemoveAt(size - 1);
                    dataGridViewResult.Rows.RemoveAt(size - 1);
                }      
            }
            else if (comboBox1.SelectedIndex + 2 > oldSize)
            {
                for (int i = 0; i < comboBox1.SelectedIndex - oldSize + 2; ++i)
                {
                    size++;
                    dataGridViewMatrix.Rows.Add();
                    dataGridViewMatrix.Columns.Add("", "");

                    dataGridViewVector.Rows.Add();
                    dataGridViewResult.Rows.Add();
                }
            }
        }

        private void buttonMinusSize_Click(object sender, EventArgs e)
        {
            if (size != 3)
            {
                buttonMinusSize.Enabled = true;

                size--;
                //labelSizeSLAE.Text = "Размер СЛАУ - " + size.ToString();

                dataGridViewMatrix.Rows.RemoveAt(size - 1);
                dataGridViewMatrix.Columns.Remove("");

                dataGridViewVector.Rows.RemoveAt(size - 1);
                dataGridViewResult.Rows.RemoveAt(size - 1);

                buttonClear_Click(sender, e);

                if (size == 3)
                {
                    buttonMinusSize.Enabled = false;
                }
                if (size < 8)
                {
                    buttonPlusSize.Enabled = true;
                }
            }
        }

        private void buttonPlusSize_Click(object sender, EventArgs e)
        {
            if (size != 8)
            {
                buttonPlusSize.Enabled = true;

                size++;
                //labelSizeSLAE.Text = "Размер СЛАУ - " + size.ToString();


                dataGridViewMatrix.Rows.Add();
                dataGridViewMatrix.Columns.Add("", "");

                dataGridViewVector.Rows.Add();
                dataGridViewResult.Rows.Add();

                buttonClear_Click(sender, e);

                if (size == 8)
                {
                    buttonPlusSize.Enabled = false;
                }
                if (size > 3)
                {
                    buttonMinusSize.Enabled = true;
                }
            }
        }

        private void buttonGenerator_Click(object sender, EventArgs e)
        {
            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < dataGridViewMatrix.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                }

                dataGridViewVector.Rows[i].Cells[0].Value = b[i];
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMatrix.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = "";
                }

                dataGridViewVector.Rows[i].Cells[0].Value = "";
                dataGridViewResult.Rows[i].Cells[0].Value = "";
            }


            labelTimeGauss.Text = "Метод Гаусса           - ";
            labelTimeCramer.Text = "Метод Крамера          - ";
            labelTimeLU.Text = "Метод LU-разложения    - ";
            labelTimeSimpleIteration.Text = "Метод простой итерации - ";
            labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя   - ";

            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
        }

        private void buttonGauss_Click(object sender, EventArgs e)
        {
            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
            labelTimeUpperRelaxation.BackColor = Color.FromName("Control");
            labelTimeRotation.BackColor = Color.FromName("Control");

            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            Stopwatch time = new Stopwatch();
            GaussMethod gaussMethod = new GaussMethod();
            time.Start();
            double[] gaussSolution = gaussMethod.Solve(matrix, b);
            time.Stop();

            for (int i = 0; i < size; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = gaussSolution[i];
            }

            labelTimeGauss.Text           = "Метод Гаусса             - " + time.Elapsed.TotalSeconds;
            labelTimeCramer.Text          = "Метод Крамера            - ";
            labelTimeLU.Text              = "Метод LU-разложения      - ";
            labelTimeSimpleIteration.Text = "Метод простой итерации   - ";
            labelTimeGaussZeidel.Text     = "Метод Гаусса-Зейделя     - ";
            labelTimeUpperRelaxation.Text = "Метод верхней релаксации - ";
            labelTimeRotation.Text        = "Метод вращений           - ";
        }

        private void buttonCramer_Click(object sender, EventArgs e)
        {
            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
            labelTimeUpperRelaxation.BackColor = Color.FromName("Control");
            labelTimeRotation.BackColor = Color.FromName("Control");

            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            Stopwatch time = new Stopwatch();
            CramerMethod cramerMethod = new CramerMethod();
            time.Start();
            double[] cramerSolution = cramerMethod.Solve(matrix, b);
            time.Stop();

            for (int i = 0; i < size; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = cramerSolution[i];
            }

            labelTimeGauss.Text = "Метод Гаусса             - ";
            labelTimeCramer.Text = "Метод Крамера            - " + time.Elapsed.TotalSeconds;
            labelTimeLU.Text = "Метод LU-разложения      - ";
            labelTimeSimpleIteration.Text = "Метод простой итерации   - ";
            labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя     - ";
            labelTimeUpperRelaxation.Text = "Метод верхней релаксации - ";
            labelTimeRotation.Text = "Метод вращений           - ";
        }

        private void buttonGaussZeidel_Click(object sender, EventArgs e)
        {
            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
            labelTimeUpperRelaxation.BackColor = Color.FromName("Control");
            labelTimeRotation.BackColor = Color.FromName("Control");

            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            GaussSeidelMethod gaussSeidelMethod = new GaussSeidelMethod();
            Stopwatch time = new Stopwatch();
            time.Start();
            double[] gaussSeidelSolution = gaussSeidelMethod.Solve(matrix, b);
            time.Stop();

            for (int i = 0; i < size; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = gaussSeidelSolution[i];
            }

            labelTimeGauss.Text = "Метод Гаусса             - ";
            labelTimeCramer.Text = "Метод Крамера            - ";
            labelTimeLU.Text = "Метод LU-разложения      - ";
            labelTimeSimpleIteration.Text = "Метод простой итерации   - ";
            labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя     - " + time.Elapsed.TotalSeconds;
            labelTimeUpperRelaxation.Text = "Метод верхней релаксации - ";
            labelTimeRotation.Text = "Метод вращений           - ";
        }

        private void buttonUpperRelaxation_Click(object sender, EventArgs e)
        {
            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
            labelTimeUpperRelaxation.BackColor = Color.FromName("Control");
            labelTimeRotation.BackColor = Color.FromName("Control");

            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            GaussMethod gaussMethod = new GaussMethod();
            Stopwatch time = new Stopwatch();
            time.Start();
            double[] gaussSolution = gaussMethod.Solve(matrix, b);
            time.Stop();

            for (int i = 0; i < size; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = gaussSolution[i];
            }

            labelTimeGauss.Text = "Метод Гаусса             - ";
            labelTimeCramer.Text = "Метод Крамера            - ";
            labelTimeLU.Text = "Метод LU-разложения      - ";
            labelTimeSimpleIteration.Text = "Метод простой итерации   - ";
            labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя     - ";
            labelTimeUpperRelaxation.Text = "Метод верхней релаксации - " + time.Elapsed.TotalSeconds;
            labelTimeRotation.Text = "Метод вращений           - ";
        }

        private void buttonSimpleIteration_Click(object sender, EventArgs e)
        {
            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
            labelTimeUpperRelaxation.BackColor = Color.FromName("Control");
            labelTimeRotation.BackColor = Color.FromName("Control");

            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            SimpleIterationMethod simpleIterationMethod = new SimpleIterationMethod();
            Stopwatch time = new Stopwatch();
            time.Start();
            double[] simpleIterationSolution = simpleIterationMethod.Solve(matrix, b);
            time.Stop();

            for (int i = 0; i < size; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = simpleIterationSolution[i];
            }

            labelTimeGauss.Text = "Метод Гаусса             - ";
            labelTimeCramer.Text = "Метод Крамера            - ";
            labelTimeLU.Text = "Метод LU-разложения      - ";
            labelTimeSimpleIteration.Text = "Метод простой итерации   - " + time.Elapsed.TotalSeconds;
            labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя     - ";
            labelTimeUpperRelaxation.Text = "Метод верхней релаксации - ";
            labelTimeRotation.Text = "Метод вращений           - ";
        }

        private void buttonLU_Click(object sender, EventArgs e)
        {
            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
            labelTimeUpperRelaxation.BackColor = Color.FromName("Control");
            labelTimeRotation.BackColor = Color.FromName("Control");

            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            LUDecomposition luDecomposition = new LUDecomposition();
            Stopwatch time = new Stopwatch();
            time.Start();
            double[] luSolution = luDecomposition.Solve(matrix, b);
            time.Stop();

            for (int i = 0; i < size; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = luSolution[i];
            }

            labelTimeGauss.Text = "Метод Гаусса             - ";
            labelTimeCramer.Text = "Метод Крамера            - ";
            labelTimeLU.Text = "Метод LU-разложения      - " + time.Elapsed.TotalSeconds;
            labelTimeSimpleIteration.Text = "Метод простой итерации   - ";
            labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя     - ";
            labelTimeUpperRelaxation.Text = "Метод верхней релаксации - ";
            labelTimeRotation.Text = "Метод вращений           - ";
        }

        private void buttonRotation_Click(object sender, EventArgs e)
        {
            labelTimeGauss.BackColor = Color.FromName("Control");
            labelTimeCramer.BackColor = Color.FromName("Control");
            labelTimeLU.BackColor = Color.FromName("Control");
            labelTimeSimpleIteration.BackColor = Color.FromName("Control");
            labelTimeGaussZeidel.BackColor = Color.FromName("Control");
            labelTimeUpperRelaxation.BackColor = Color.FromName("Control");
            labelTimeRotation.BackColor = Color.FromName("Control");

            GeneratorMatrix generator = new GeneratorMatrix();
            matrix = generator.GenerateMatrix(size);
            b = generator.GenerateVector(size);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dataGridViewMatrix.Rows[i].Cells[j].Value);
                }

                b[i] = Convert.ToDouble(dataGridViewVector.Rows[i].Cells[0].Value);
            }

            GaussSeidelMethod gaussSeidelMethod = new GaussSeidelMethod();
            Stopwatch time = new Stopwatch();
            time.Start();
            double[] gaussSeidelSolution = gaussSeidelMethod.Solve(matrix, b);
            time.Stop();

            for (int i = 0; i < size; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = gaussSeidelSolution[i];
            }

            labelTimeGauss.Text = "Метод Гаусса             - ";
            labelTimeCramer.Text = "Метод Крамера            - ";
            labelTimeLU.Text = "Метод LU-разложения      - ";
            labelTimeSimpleIteration.Text = "Метод простой итерации   - ";
            labelTimeGaussZeidel.Text = "Метод Гаусса-Зейделя     - ";
            labelTimeUpperRelaxation.Text = "Метод верхней релаксации - ";
            labelTimeRotation.Text = "Метод вращений           - " + time.Elapsed.TotalSeconds;
        }

        private void labelTimeRotation_Click(object sender, EventArgs e)
        {

        }
    }
}
