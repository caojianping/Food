using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;
using Food.Service;

namespace Food.FactoryMethod
{
    public class BaogongFishFactory : IFactory
    {
        public virtual IFood CreateInstance()
        {
            IFood food = new BaogongFish();
            return food;
        }
    }
}
