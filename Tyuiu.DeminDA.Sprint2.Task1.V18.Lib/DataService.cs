using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DeminDA.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18

    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = (a < b) | (c > d);
            result[1] = (a < b) & (c < d);
            result[2] = (a < b) || (c < d);
            result[3] = (a > b) && (c < d);
            result[4] = !(c > d);
            result[5] = (a < b) & (c > d);
            return result;

        }
    }
}
