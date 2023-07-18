using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.AbstractFactory.Interface;

namespace Food.AbstractFactory.Service
{
    public class SichuanCuisineGreens : IGreens
    {
        public void CookGreens()
        {
            Console.WriteLine(string.Format("川菜厨会做{0}、{1}、{2}三个菜等等。", "四川回锅肉", "鱼香肉丝", "麻婆豆腐"));
        }
    }
}
