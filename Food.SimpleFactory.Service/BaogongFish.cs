using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;

namespace Food.Service
{
    /// <summary>
    /// 合肥特产之包公鱼
    /// </summary>
    public class BaogongFish : IFood
    {
        public void Show()
        {
            Console.WriteLine("大家好！我是包公鱼！");
        }
    }
}
