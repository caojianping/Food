using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.AbstractFactory.Interface;

namespace Food.AbstractFactory.Service
{
    public class AnhuiCuisineMain : IMain
    {
        public void CookMain()
        {
            Console.WriteLine(string.Format("徽菜工厂会做{0}主食。", "大米饭"));
        }
    }
}
