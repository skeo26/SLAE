using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAE
{
    class GaussMethod : SLAEMethod
    {
        public override double[] Solve(double[,] matrix, double[] b)
        {
            int length = matrix.GetLength(0);
            double[] x = new double[length];

            //прямой ход решения
            for (int k = 1; k < length; k++)
            {
                for (int i = k; i < length; i++)
                {
                    double coeff = matrix[i, k - 1] / matrix[k - 1, k - 1];

                    for (int j = 0; j < length; j++)
                    {
                        matrix[i, j] -= coeff * matrix[k - 1, j];
                    }

                    b[i] -= coeff * b[k - 1];
                }
            }

            //обратный ход решения
            for (int i = length - 1; i >= 0; i--)
            {
                x[i] = b[i] / matrix[i, i];

                for (int j = length - 1; j > i; j--)
                {
                    x[i] -= matrix[i, j] * x[j] / matrix[i, i];
                }
            }

            return x;
        }
    }
}
