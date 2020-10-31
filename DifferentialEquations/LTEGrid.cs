using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentialEquations
{
    class LTEGrid : Grid
    {

        public LTEGrid(Grid grid1, Grid grid2) : base(grid1.N, grid1.x[0], grid1.x[grid1.N])
        {
            for (int i = 0; i <= N; i++)
            {
                y[i] = grid1.y[i] - grid2.y[i];
            }
        }
        public LTEGrid(int N, double x0, double X) : base(N, x0, X)
        {

        }
    }
}
