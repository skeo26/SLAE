using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAE
{
    class GaussSeidelMethod : SLAEMethod
    {
        private readonly double eps;

        public GaussSeidelMethod(double eps = 0.01)
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

            do
            {
                Array.Copy(x, p, length);

                for (int i = 0; i < length; i++)
                {
                    double var = 0.0;
                    for (int j = 0; j < i; j++)
                    {
                        var += matrix[i, j] * x[j];
                    }
                    for (int j = i + 1; j < length; j++)
                    {
                        var += matrix[i, j] * p[j];
                    }
                    x[i] = (b[i] - var) / matrix[i, i];
                }

            } while (!Converge(ref x, ref p));

            return x;
        }
    }
}
