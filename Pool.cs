using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_Проект
{
    internal class Pool
    {
        public int Volume;    
        public int Pipe1;      
        public int Pipe2;      
        public double Hours;   

        public double GetPipe1Liters()
        {
            return Pipe1 * Hours;
        }

        
        public double GetPipe2Liters()
        {
            return Pipe2 * Hours;
        }

       
        public double GetTotalLiters()
        {
            return GetPipe1Liters() + GetPipe2Liters();
        }

        
        public bool IsOverflowing()
        {
            return GetTotalLiters() > Volume;
        }

        
        public double GetOverflow()
        {
            return GetTotalLiters() - Volume;
        }

        
        public int GetPercentFull()
        {
            return (int)(GetTotalLiters() * 100 / Volume);
        }

        
        public int GetPipe1Percent()
        {
            return (int)(GetPipe1Liters() * 100 / GetTotalLiters());
        }

       
        public int GetPipe2Percent()
        {
            return (int)(GetPipe2Liters() * 100 / GetTotalLiters());
        }
    }
}
