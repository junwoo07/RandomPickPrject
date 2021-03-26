using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RandomPickPrject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> items = new List<int>(new int[]{1,2,3,4,5});
            double down_speed_scale = 0.03 ;
            double speed = 0.01;
            int value ;
            double endspeed = 0.6;
            while (speed < endspeed)
            {
                value = items[random.Next(items.Count())];
                speed += ((double)random.Next(-2,3))*down_speed_scale;
                if (speed < 0)
                {
                    speed -= ((double)random.Next(-1, 3)) * down_speed_scale;
                }
                Console.WriteLine((int)(speed * 1000));
                Thread.Sleep((int)(speed * 1000));
                Console.Write("\r"+value.ToString());
            }
            Console.WriteLine("\n\n\n\n\nFinished!");
        }
    }
}
