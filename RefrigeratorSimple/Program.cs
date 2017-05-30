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
            Refrigerator fridge= new Refrigerator(true, true, false, false, true, -5, BrigthnessLevel.Normal);
            char KeyPressed;
            while (true)
            {
                Console.Clear();
                Console.WriteLine(fridge.Info()+" \n");
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
                        fridge.On();
                        break;
                    case '2':
                        fridge.Off();
                        break;
                    case '3':
                        fridge.Increase();
                        break;
                    case '4':
                        fridge.Decrease();
                        break;
                    case '5':
                        fridge.HightLightTurn();
                        break;
                    case '6':
                        fridge.NormalLightTurn();
                        break;
                    case '7':
                        fridge.LowLightTurn();
                        break;
                    case '8':
                        fridge.FreezingOn();
                        break;
                    case '9':
                        fridge.FreezingOff();
                        break;
                    case 'a':
                        fridge.DefrostingOn();
                        break;
                    case 'b':
                        fridge.DefrostingOff();
                        break;
                    case 'c':
                        fridge.VacOn();
                        break;
                    case 'd':
                        fridge.VacOff();
                        break;
                    case 'e':
                        fridge.ProtectOn();
                        break;
                    case 'f':
                        fridge.ProtectOff();
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
