using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        

        {
            var rand = new Random();
            int[] point1 = new int[3];
            int[] point2 = new int[3];
            double[] sum = new double[3];

            

            for(int i=0; i<3 ;i++)
            {
                point1[i] = rand.Next(0, 15);
                point2[i] = rand.Next(0, 15);
                sum[i] = (point1[i]-point2[i])*(point1[i]-point2[i]);
                Console.WriteLine($"{point1[i]}, {point2[i]}");
            }
            
            double s = Math.Sqrt(sum[0]+sum[1]+sum[2]);
            Console.WriteLine(s);






        }
    }
}