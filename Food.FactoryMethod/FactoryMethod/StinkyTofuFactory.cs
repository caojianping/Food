using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;
using Food.ServiceExtend;

namespace Food.FactoryMethod
{
    public class StinkyTofuFactory : IFactory
    {
        public IFood CreateInstance()
        {
            IFood food = new StinkyTofu();
            return food;
        }
    }
}
