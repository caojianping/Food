using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;

namespace Food.Service
{
    /// <summary>
    /// 合肥特产之庐州烤鸭
    /// </summary>
    public class LuZhouRoastDuck : IFood
    {
        public void Show()
        {
            Console.WriteLine("大家好！我是庐州烤鸭！");
        }
    }
}
