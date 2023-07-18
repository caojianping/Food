using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.AbstractFactory.Interface;

namespace Food.AbstractFactory.Service
{
    public class AnhuiCuisineSoup : ISoup
    {
        public void CookSoup()
        {
            Console.WriteLine(string.Format("徽菜工厂会做{0}。", "肥西老母鸡汤"));
        }
    }
}
