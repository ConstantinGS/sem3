using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите число");
            string number_string = Console.ReadLine();
            while (number_string.Length !=5)
                {
                    Console.WriteLine("Вы ввели не пятизначное число. Попробуйте еще раз.");
                    number_string = Console.ReadLine();
                }
            Palindrom(number_string);

            void Palindrom(string num)
            {
                if(num[0]==num[4] && num[1]==num[3])
                {
                    Console.WriteLine("Заданное число является палиндромом");
                }
                else{Console.WriteLine("Заданное число не является палиндромом");}

            }

            






        }
    }
}