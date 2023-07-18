using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Order.Interface;

namespace Food.Order.Service
{
    /// <summary>
    /// 麻婆豆腐
    /// </summary>
    public class MapoTofu : AbstractFood
    {
        public MapoTofu(string name, int price, string intro) : base(name, price, intro)
        {

        }

        public override void Cook()
        {
            Console.WriteLine(string.Format("\r\n开始做{0}！", this.Name));
        }
    }
}
