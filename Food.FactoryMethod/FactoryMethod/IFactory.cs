using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;

namespace Food.FactoryMethod
{
    public interface IFactory
    {
        IFood CreateInstance();
    }
}
