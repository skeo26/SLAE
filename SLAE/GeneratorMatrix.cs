using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAE
{
    class GeneratorMatrix
    {
        Random random = new Random();

        public double[,] GenerateMatrix(int size)
        {
            double[,] matrix = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                double sum = 0.0;
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                    sum += Math.Abs(matrix[i, j]);
                }

                matrix[i, i] = sum + random.Next(0, 10);
            }

            return matrix;
        }

        public double[] GenerateVector(int size)
        {
            double[] b = new double[size];

            for (int i = 0; i < size; i++)
            {
                b[i] = random.Next(-10, 10);
            }

            return b;
        }
    }
}
