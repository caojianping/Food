using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;
using Food.Service;

namespace Food.FactoryMethod
{
    public class LuZhouRoastDuckFactory : IFactory
    {
        public virtual IFood CreateInstance()
        {
            IFood food = new LuZhouRoastDuck();
            return food;
        }
    }
}
