using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAE
{
    class CramerMethod : SLAEMethod
    {
        public override double[] Solve(double[,] matrix, double[] b)
        {
            int length = matrix.GetLength(0);
            double detMatrix = Determinant(matrix);
            double[] x = new double[length];

            for (int i = 0; i < length; i++)
            {
                double[,] newMatrix = new double[length, length];
                Array.Copy(matrix, newMatrix, length * length);
                for (int j = 0; j < length; j++)
                {
                    newMatrix[j, i] = b[j];
                }

                x[i] = Determinant(newMatrix) / detMatrix;
            }

            return x;
        }

        private double Determinant(double[,] matrix)
        {
            int length = matrix.GetLength(0);

            for (int k = 1; k < length; k++)
            {
                for (int i = k; i < length; i++)
                {
                    double coeff = matrix[i, k - 1] / matrix[k - 1, k - 1];

                    for (int j = 0; j < length; j++)
                    {
                        matrix[i, j] -= coeff * matrix[k - 1, j];
                    }
                }
            }

            //for (int k = 0; k < length; k++)
            //{
            //    // Initialize maximum value and index for pivot 
            //    int i_max = k;
            //    double v_max = matrix[i_max, k];

            //    /* find greater amplitude for pivot if any */
            //    for (int i = k + 1; i < length; i++)
            //        if (Math.Abs(matrix[i, k]) > v_max)
            //        {
            //            v_max = matrix[i, k];
            //            i_max = i;
            //        }

            //    /* Swap the greatest value row with current row */
            //    if (i_max != k)
            //        swap_row(ref matrix, k, i_max);


            //    for (int i = k + 1; i < length; i++)
            //    {
            //        /* factor f to set current row kth elemnt to 0, 
            //         * and subsequently remaining kth column to 0 */
            //        double f = matrix[i, k] / matrix[k, k];

            //        /* subtract fth multiple of corresponding kth 
            //           row element*/
            //        for (int j = k + 1; j < length; j++)
            //            matrix[i, j] -= matrix[k, j] * f;

            //        /* filling lower triangular matrix with zeros*/
            //        matrix[i, k] = 0;
            //    }
            //}

            double det = 1.0;
            for (int i = 0; i < length; i++)
            {
                det *= matrix[i, i];
            }

            return det;
        }
 
        private void swap_row(ref double[,] matrix, int i, int j)
        {
            int length = matrix.GetLength(0);

            for (int k = 0; k < length; k++)
            {
                double temp = matrix[i, k];
                matrix[i, k] = matrix[j, k];
                matrix[j, k] = temp;
            }
        }
    }
}
