using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DeminDA.Sprint2.Task3.V13.Lib;

namespace Tyuiu.DeminDA.Sprint2.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
