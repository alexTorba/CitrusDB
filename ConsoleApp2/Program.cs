using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace ConsoleApp2
{




    class Program
    {

        static void Show()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(20);

                Console.Write('.');
            }
        }
        static Task SomeMethod()
        {
            return Task.Run(() =>
            {

                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(20);

                    Console.Write("/");
                }
            });

        }

        async static void Metho()
        {
            await Task.Run(SomeMethod);
        }

        static void Main(string[] args)
        {
            Metho();
            Show();
        }
    }
}
