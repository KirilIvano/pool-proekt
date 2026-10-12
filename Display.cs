using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_Проект
{
    internal class Display
    {
        public int ReadVolume()
        {
            int volume = int.Parse(Console.ReadLine());
            return volume;
        }

        
        public int ReadPipe()
        {
            int pipe = int.Parse(Console.ReadLine());
            return pipe;
        }

       
        public double ReadHours()
        {
            double hours = double.Parse(Console.ReadLine());
            return hours;
        }

        
        public void PrintFull(int percentFull, int pipe1Percent, int pipe2Percent)
        {
            Console.WriteLine("The pool is " + percentFull + "% full. Pipe 1: " + pipe1Percent + "%. Pipe 2: " + pipe2Percent + "%.");
        }

        
        public void PrintOverflow(double hours, double overflow)
        {
            Console.WriteLine("For " + hours + " hours the pool overflows with " + overflow + " liters.");
        }
    }
}
