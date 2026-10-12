using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_Проект
{
    internal class PoolActionController
    {
        private Pool pool;
        private Display display;

        public PoolActionController()
        {
            pool = new Pool();
            display = new Display();

            pool.Volume = display.ReadVolume();
            pool.Pipe1 = display.ReadPipe();
            pool.Pipe2 = display.ReadPipe();
            pool.Hours = display.ReadHours();

            if (pool.IsOverflowing())
            {
                display.PrintOverflow(pool.Hours, pool.GetOverflow());
            }
            else
            {
                display.PrintFull(pool.GetPercentFull(), pool.GetPipe1Percent(), pool.GetPipe2Percent());
            }
        }
    }
}