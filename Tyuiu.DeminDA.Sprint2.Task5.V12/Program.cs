using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DeminDA.Sprint2.Task5.V12.Lib;

namespace Tyuiu.DeminDA.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());

            string res = Convert.ToString(ds.FindDateOfPreviousDay(g, m, n));
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
