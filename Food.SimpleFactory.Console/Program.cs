using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;
using Food.Service;

namespace Food.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎大家品尝合肥特产！下面让我们来介绍下自己吧！\r\n");

            #region 作业要求1    
            Demo1();
            #endregion

            #region 作业要求2
            Demo2();
            #endregion
        }

        /// <summary>
        /// 普通方式
        /// 优点：简单明了（如果只是一个非常非常简单的功能，当然就用这种方式了）；
        /// 缺点：扩展性差、稳定性差、后期维护性也差；
        /// </summary>
        static void Demo1()
        {
            Console.WriteLine("********************一、普通方式start********************");
            LuZhouRoastDuck duck = new LuZhouRoastDuck();
            duck.Show();

            BaogongFish fish = new BaogongFish();
            fish.Show();

            XiaoYaoChicken chicken = new XiaoYaoChicken();
            chicken.Show();
            Console.WriteLine("********************普通方式end********************\r\n\r\n");
        }

        /// <summary>
        /// 简单工厂
        /// 优点：各司其职，明确了各自的职责和权利，转移了细节处理，细节处理由工厂类负责，在一定程度上增强了代码的可维护性，有利于整个软件体系结构的优化。
        /// 缺点：工厂类创建实例的方法实现了对各个对象实例创建的封装，耦合性高，扩展性差（配置、反射一定程序上做了优化）；
        /// </summary>
        static void Demo2()
        {
            Console.WriteLine("********************二、简单工厂start********************");

            Console.WriteLine("**********工厂类示例**********");
            IFood duck = FoodFactory.CreateInstance(FoodFactory.FoodType.LuZhouRoastDuck);
            duck.Show();

            IFood fish = FoodFactory.CreateInstance(FoodFactory.FoodType.BaogongFish);
            fish.Show();

            IFood chicken = FoodFactory.CreateInstance(FoodFactory.FoodType.XiaoYaoChicken);
            chicken.Show();

            Console.WriteLine("\r\n**********配置示例**********");
            IFood cfood = FoodFactory.CreateInstanceConfig();
            cfood.Show();

            Console.WriteLine("\r\n**********反射示例**********");
            Console.WriteLine("备注：添加一道新菜时，您的操作只需要如下所示。");
            Console.WriteLine("1、首先，编写新菜的功能代码（例如Food.ServiceExtend类库中的StinkyTofu臭豆腐）；");
            Console.WriteLine("2、其次，添加新菜类库的配置参数（assemblyName,typeName）；");
            Console.WriteLine("3、最后，复制新菜类库的dll文件至此程序exe可执行文件的同级目录即可。");
            IFood rfood = FoodFactory.CreateInstanceReflect();
            rfood.Show();

            Console.WriteLine("********************简单工厂end********************\r\n\r\n");
        }
    }
}
