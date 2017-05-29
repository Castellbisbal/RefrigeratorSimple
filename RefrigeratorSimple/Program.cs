using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            char KeyPressed;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Состояние холодильника... \n");
                Console.WriteLine("Панель управления холодильником. Выберите пункт меню \n");
                Console.WriteLine(" 1 - Включить холодильник");
                Console.WriteLine(" 2 - Выключить холодильник");
                Console.WriteLine(" 3 - Увеличить температуру");
                Console.WriteLine(" 4 - Уменьшить температуру");
                Console.WriteLine(" 5 - Включить яркую подсветку");
                Console.WriteLine(" 6 - Включить нормальную подсветку");
                Console.WriteLine(" 7 - Включить тусклую подсветку");
                Console.WriteLine(" 8 - Включить режим Суперзаморозка");
                Console.WriteLine(" 9 - Отключить режим Суперзаморозка");
                Console.WriteLine(" A - Включить режим Быстрая разморозка");
                Console.WriteLine(" B - Отключить режим Быстрая разморозка");
                Console.WriteLine(" C - Включить режим Отпуск");
                Console.WriteLine(" D - Отключить режим Отпуск");
                Console.WriteLine(" E - Включить режим Защита от детей");
                Console.WriteLine(" F - Отключить режим Защита от детей");
                Console.WriteLine(" X - Выход из меню");

                KeyPressed = Console.ReadKey().KeyChar;

                switch (KeyPressed)
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                    case 'a':
                        break;
                    case 'b':
                        break;
                    case 'c':
                        break;
                    case 'd':
                        break;
                    case 'f':
                        break;
                    case 'x':
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
