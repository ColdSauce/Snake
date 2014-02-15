using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            while (true)
            {
                System.Threading.ThreadPool.QueueUserWorkItem(delegate
                {
                    key = Console.ReadKey();
                }, null);
                snake.testKeys(key);
                Location.printAtLocation("*",snake.getLoc());
                System.Threading.Thread.Sleep(25);

            }
             
            

            
        }

        

    }

}

