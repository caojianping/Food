using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.AbstractFactory.Interface;

namespace Food.AbstractFactory.Service
{
    public class SichuanCuisineSoup : ISoup
    {
        public void CookSoup()
        {
            Console.WriteLine(string.Format("川菜工厂会做{0}。", "酸萝卜老鸭汤"));
        }
    }
}
