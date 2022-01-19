using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("введите значение угла");
            int gradus = Convert.ToInt32(Console.ReadLine());
            int minuta = Convert.ToInt32(Console.ReadLine());
           int secunda = Convert.ToInt32(Console.ReadLine());
            gradusi grad = new gradusi(gradus, minuta, secunda);
            double radian = grad.ToRadians();
            Console.WriteLine("{0}gr{1}'{2}'' равно {3:0.00}", gradus, minuta, secunda, radian);
            Console.ReadKey();
        }
    }
}
