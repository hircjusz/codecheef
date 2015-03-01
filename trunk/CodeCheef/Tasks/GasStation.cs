using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCheef.Tasks
{
    public class GasStation
    {

        int[] D = null;
        double[] P = null;
        double[,] C = null;
        int T = 5;
        int StationNumber = 3;

        public void Init()
        {
            D = new int[StationNumber];
            D[0] = 0;
            D[1] = 5;
            D[2] = 10;

            P = new double[StationNumber];
            P[0] = 1;
            P[1] = 3.0;
            P[2] = 4.0;


            C = new double[StationNumber, T];





        }


        public void Run()
        {

        }

        public void Solution()
        {



        }
    }
}
