using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.AbstractFactory.Interface;

namespace Food.AbstractFactory.Service
{
    public class AnhuiCuisineGreens : IGreens
    {
        public void CookGreens()
        {
            Console.WriteLine(string.Format("徽菜工厂会做{0}、{1}、{2}三个菜等等。", "庐州烤鸭", "包公鱼", "逍遥鸡"));
        }
    }
}
