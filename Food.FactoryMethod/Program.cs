using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;
using Food.ServiceExtend;

namespace Food.FactoryMethod
{
    class Program
    {
        /// <summary>
        /// 工厂方法
        /// 优点：该模式继承了简单工厂模式的优点又克服了它的缺点，在系统增加新产品时，只需要添加一个具体产品类和对应实现工厂即可，不需要对原工厂进行任何修改，很好地符合了“开闭原则”；
        /// 缺点：在系统每增加一个新产品时，都需要增加一个具体类和对象实现工厂，当系统中类的数目成倍增加时，在一定程度上增加了系统的复杂度，同时也增加了系统具体类的依赖度；
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家品尝合肥特产！下面让我们来介绍下自己吧！\r\n");

            #region 作业要求3
            Console.WriteLine("********************三、工厂方法start********************");
            IFactory duckFactory = new LuZhouRoastDuckFactory();
            IFood duck = duckFactory.CreateInstance();
            duck.Show();

            IFactory fishFactory = new BaogongFishFactory();
            IFood fish = fishFactory.CreateInstance();
            fish.Show();

            IFactory chickenFactory = new XiaoYaoChickenFactory();
            IFood chicken = chickenFactory.CreateInstance();
            chicken.Show();

            IFactory tofuFactory = new StinkyTofuFactory();
            IFood tofu = tofuFactory.CreateInstance();
            tofu.Show();

            IFactory godmotherFactory = new GodmotherFactory();
            IFood godmother = godmotherFactory.CreateInstance();
            godmother.Show();

            IFactory godmotherExtendFactory = new GodmotherFactoryExtend();
            IFood godmotherExtend = godmotherExtendFactory.CreateInstance();
            godmotherExtend.Show();
            Console.WriteLine("********************工厂方法end********************\r\n\r\n");
            #endregion
        }
    }
}
