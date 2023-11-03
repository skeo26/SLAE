using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAE
{
    class UpperRelaxationMethod : SLAEMethod
    {
        public override double[] Solve(double[,] matrix, double[] b)
        {
            int length = matrix.GetLength(0);
            double[] x = new double[length];

            //double coeff;

            GeneratorMatrix generator = new GeneratorMatrix();


            return x;
        }
    }
}
