using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAE
{
    class SimpleIterationMethod : SLAEMethod
    {
        private readonly double eps;

        public SimpleIterationMethod(double eps = 0.00001)
        {
            this.eps = eps;
        }
        private bool Converge(ref double[] xk, ref double[] xkp)
        {
            int length = xk.GetLength(0);

            double norm = 0.0;
            for (int i = 0; i < length; i++)
            {
                norm += (xk[i] - xkp[i]) * (xk[i] - xkp[i]);
            }

            return Math.Sqrt(norm) < eps;
        }
        public override double[] Solve(double[,] matrix, double[] b)
        {
            int length = matrix.GetLength(0);
            double[] p = new double[length];
            double[] x = new double[length];

            double[,] alpha = new double[length, length];
            double[] beta = new double[length];

            for (int i = 0; i < length; i++)
            {
                beta[i] = b[i] / matrix[i, i];
                for (int j = 0; j < length; j++)
                {
                    alpha[i, j] = (i != j) ? -matrix[i, j] / matrix[i, i] : 0;
                }
            }

            Array.Copy(beta, x, length);

            do
            {
                Array.Copy(x, p, length);
            
                for (int i = 0; i < length; i++)
                {
                    double[] c = new double[length];
                    for (int j = 0; j < length; j++)
                    {
                        c[i] += alpha[i, j] * p[j];
                    }

                    x[i] = beta[i] + c[i];
                }

            } while (!Converge(ref x, ref p));


            return x;
        }
    }
}
