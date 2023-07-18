using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.AbstractFactory.Interface;

namespace Food.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IGreens CreateGreens();

        public abstract ISoup CreateSoup();

        public abstract IMain CreateMain();
    }
}
