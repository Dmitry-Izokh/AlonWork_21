using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace AlonWork_21
{
    class Program
    {
        //const int a = 5;
        //const int b = 5;
        //static int[,] path = new int[a, b] { { 1, 2, 3, 4, 5 }, { 6, 4, 8, 1, 3 }, { 4, 3, 7, 9, 1 }, { 4, 3, 0, 1, 1 }, { 4, 5, 1, 6, 8 } };

        const int a = 5;
        const int b = 5;
        static int[,] path = new int[a, b];
        

        static void Main(string[] args)
        {
            // ВАРИАНТ 1

            //const int a = 5;
            //const int b = 5;
            //int[,] path = new int[a, b];
            //Random random = new Random();
            //for (int i = 0; i < a; i++)
            //{
            //    for (int j = 0; j < b; j++)
            //    {
            //        path[i, j] = random.Next(0, 10);
            //        Console.Write("{0,5}", path[i, j]);
            //    }
            //    Console.WriteLine();
            //}



            // ВАРИАНТ 2

            //int[,] path = new int[a, b];
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    path[i, j] = random.Next(0, 10);
                    Console.Write("{0,5}", path[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardner2();                       

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"{path[i,j],5}");
                }
                Console.WriteLine();
            }



            Console.ReadKey();


        }
        static void Gardner1()
        {
            for (int i = 0; i < a; i++)
            {
               
                for (int j = 0; j < b; j++)
                {
                    if (path[i,j] >= 0)
                    {
                        int make_1 = path[i,j];
                        path[i,j] = -1;
                        Thread.Sleep(make_1);
                    }
                }
            }
        }

        static void Gardner2()
        {
            for (int i = a-1; i >= 0; i--)
            {

                for (int j = b-1; j >=0; j--)
                {
                    if (path[i, j] >= 0)
                    {
                        int make_2 = path[i, j];
                        path[i, j] = -2;
                        Thread.Sleep(make_2);
                    }
                }
            }
        }
    }
}