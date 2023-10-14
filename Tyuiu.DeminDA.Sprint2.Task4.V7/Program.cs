using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DeminDA.Sprint2.Task4.V7.Lib;

namespace Tyuiu.DeminDA.Sprint2.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = ds.Calculate(x, y);
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
