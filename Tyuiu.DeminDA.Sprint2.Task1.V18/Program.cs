using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DeminDA.Sprint2.Task1.V18.Lib;

namespace Tyuiu.DeminDA.Sprint2.Task1.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();


            DataService ds = new DataService();
            int a = 155, b = 696, c = 242, d = 541;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
