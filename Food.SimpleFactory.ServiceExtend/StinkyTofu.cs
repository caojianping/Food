using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;

namespace Food.ServiceExtend
{
    /// <summary>
    /// 臭豆腐
    /// </summary>
    public class StinkyTofu : IFood
    {
        public void Show()
        {
            Console.WriteLine("大家好！我是臭豆腐！");
        }
    }
}
