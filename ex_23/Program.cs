using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        

        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            Cub(n);


            void Cub(int number)
            
            {
                int a;
                for (int i=0; i<number; i++)
                {
                    a = i*i*i;
                    Console.WriteLine($"{i} _|_ {a}");



                }
            }




        }
    }
}