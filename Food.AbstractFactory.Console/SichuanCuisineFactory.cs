using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.AbstractFactory.Interface;
using Food.AbstractFactory.Service;

namespace Food.AbstractFactory
{
    public class SichuanCuisineFactory : AbstractFactory
    {
        public override IGreens CreateGreens()
        {
            return new SichuanCuisineGreens();
        }

        public override IMain CreateMain()
        {
            return new SichuanCuisineMain();
        }

        public override ISoup CreateSoup()
        {
            return new SichuanCuisineSoup();
        }
    }
}
