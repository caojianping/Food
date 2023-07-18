using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;
using Food.ServiceExtend;

namespace Food.FactoryMethod
{
    public class GodmotherFactory : IFactory
    {
        public virtual IFood CreateInstance()
        {
            IFood food = new Godmother(1, "陶华碧");
            return food;
        }
    }

    public class GodmotherFactoryExtend : GodmotherFactory
    {
        public override IFood CreateInstance()
        {
            Console.WriteLine("再说个事，我是有许多豪车的！");
            return base.CreateInstance();
        }
    }
}
