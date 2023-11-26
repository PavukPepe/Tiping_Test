using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tiping_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string text = "ааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааааа";

                Console.WriteLine("Введите имя пользователя для таблицы рекордов");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(text);

                Console.WriteLine("Для старта нажмите Enter");
                int i = 0;
                
                while (true)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        Thread clock = new Thread(_ => { Tiping.Timer(60); });
                        clock.Start();
                        i = Tiping.Tiping_test(text, clock);
                        break;
                    }
                }
                Console.Clear();
                User user = new User(name, i);
                TableRec.Getter(user);
                Console.ReadKey(true);
            }
        }

        
    }
}