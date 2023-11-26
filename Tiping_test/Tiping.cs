using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiping_test
{
    internal class Tiping
    {
        static private bool end = false;
        public static void Timer(int sec)
        {
            for (int i = 0; i < sec && end==false; i++)
            {
                    Console.ResetColor();

                    Console.SetCursorPosition(0, 9);
                    Console.Write($"00:{sec - i}");

                    Thread.Sleep(1000);

                    Console.SetCursorPosition(0, 9);
                    Console.Write($"      ");
            }
            end = true;
        }

        public static int Tiping_test(string text, Thread clock)
        {
            text = text.Replace("\r", "");
            int schet = 0, cl = 0, pol = 0;

            foreach (var item in text)
            {
                while (!end)
                {
                    if (item == Console.ReadKey(true).KeyChar)
                    {
                        Console.SetCursorPosition(pol, cl);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(item);
                        schet++;
                        pol++;
                        break;
                    }
                }
                if (item == '\n' || pol == Console.BufferWidth)
                {
                    Console.WriteLine();
                    cl++;
                    pol = 0;
                }
            }
            end = true;
            Console.ResetColor();
            return schet;
        }
    }
}
