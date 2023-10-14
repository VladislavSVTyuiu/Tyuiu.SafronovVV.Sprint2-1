using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SafronovVV.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string res;

            switch (value1)
            {
                case 1: res = "пики"; break;
                case 2: res = "трефы"; break;
                case 3: res = "бубны"; break;
                case 4: res = "червы"; break;
                default: throw new NotImplementedException($"Существует всего 4 масти, и 9 карт.");
            }

            string res2;

            switch (value2)
            {
                case 6: res2 = "Шесть"; break;
                case 7: res2 = "Семь"; break;
                case 8: res2 = "Восемь"; break;
                case 9: res2 = "Девять"; break;
                case 10: res2 = "Десять"; break;
                case 11: res2 = "Валет"; break;
                case 12: res2 = "Дама"; break;
                case 13: res2 = "Король"; break;
                case 14: res2 = "Туз"; break;
                default: throw new NotImplementedException($"Существует всего 4 масти, и 9 карт.");
            }

            return res2 + " " + res;
        }
    }
}
