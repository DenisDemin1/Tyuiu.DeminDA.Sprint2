using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DeminDA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.DeminDA.Sprint2.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int k = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindDayName(k, d);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
