using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SafronovVV.Sprint2.Task6.V6.Lib;

namespace Tyuiu.SafronovVV.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил Сафронов В.В. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #6                                                                                      *");
            Console.WriteLine("* Вариант #6                                                                                      *");
            Console.WriteLine("* Выполнил: Сафронов Владислав Валерьевич | АСОиУб-23-1                                           *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Задание:                                                                                        *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и           *");
            Console.WriteLine("* возвращает результат.                                                                           *");
            Console.WriteLine("* Условие: Мастям игральных карт условно присвоены следующие порядковые номера: масти «пики» — 1, *");
            Console.WriteLine("* масти «трефы» — 2, масти «бубны» — 3, масти «червы» — 4, а достоинству карт: «валету» — 11,     *");
            Console.WriteLine("* «даме» — 12, «королю» — 13, «тузу» — 14(порядковые номера карт остальных достоинств             *");
            Console.WriteLine("* соответствуют их названиям: «шестерка», «девятка» и т.п.).По заданным номеру масти              *");
            Console.WriteLine("* m (1 <= m <= 4) и номеру достоинства карты k (6 <= k <= 14) определить полное название (масть   *");
            Console.WriteLine("* и достоинство) соответствующей карты в виде «Дама пик», Шестерка бубен» и т. п.                 *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("Введите значение масти от 1 до 4: ");
            int value1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение карты от 6 до 14: ");
            int value2 = Convert.ToInt32(Console.ReadLine());

            string res;

            if (((value1 < 1) || (value1 > 4)) && ((value2 < 6) || (value2 > 14)))
            {
                res = "Неверно введённое зачение масти или карты.";
            }
            else
            {
                res = "Ваша карта: " + ds.FindCardNameAndValue(value1, value2);
            }

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
