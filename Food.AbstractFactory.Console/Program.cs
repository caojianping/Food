using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.AbstractFactory.Interface;

namespace Food.AbstractFactory
{
    class Program
    {
        /// <summary>
        /// 抽象工厂
        /// 优点：抽象工厂继承了简单工厂、工厂方法模式的优点，不仅增加了产品簇的概念，而且由于封装中包含了虚方法，这样就有利于系统功能的扩展；
        /// 缺点：在增加新的产品簇时，等级结构很复杂，需要修改抽象工厂和所有的具体工厂类，在一定程度上增加了系统的复杂度，同时也增加了系统具体类的依赖度，对“开闭原则”的支持呈现倾斜性。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家品尝合肥特产！下面让我们来介绍下自己吧！\r\n");

            #region 作业要求4
            Console.WriteLine("********************四、抽象工厂start********************");
            AbstractFactory anhuiFactory = new AnhuiCuisineFactory();
            IGreens anhuiGreens = anhuiFactory.CreateGreens();
            anhuiGreens.CookGreens();
            ISoup anhuiSoup = anhuiFactory.CreateSoup();
            anhuiSoup.CookSoup();
            IMain anhuiMain = anhuiFactory.CreateMain();
            anhuiMain.CookMain();
            Console.WriteLine();

            AbstractFactory sichuanFactory = new SichuanCuisineFactory();
            IGreens sichuanGreens = sichuanFactory.CreateGreens();
            sichuanGreens.CookGreens();
            ISoup sichuanSoup = sichuanFactory.CreateSoup();
            sichuanSoup.CookSoup();
            IMain sichuanMain = sichuanFactory.CreateMain();
            sichuanMain.CookMain();
            Console.WriteLine("********************抽象工厂end********************\r\n\r\n");
            #endregion
        }
    }
}
