using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DeminDA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            int day = k;
            int week = d;

            // Вычисление дня недели
            int dayOfWeek = (k + d - 2) % 7 + 1;

            string res1;

            // Вывод результата
            switch (dayOfWeek)
            {
                case 1:
                    res1 = "Понедельник";
                    break;
                case 2:
                    res1= "Вторник";
                    break;
                case 3:
                    res1 = "Среда";
                    break;
                case 4:
                    res1 = "Четверг";
                    break;
                case 5:
                    res1 = "Пятница";
                    break;
                case 6:
                    res1 = "Суббота";
                    break;
                case 7:
                    res1 = "Воскресенье";
                    break;
                default:
                    res1 = "Некорректное значение";
                    break;
            }

            return res1;

        }
    }
}
