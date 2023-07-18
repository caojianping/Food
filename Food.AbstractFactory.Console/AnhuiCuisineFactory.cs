using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.AbstractFactory.Interface;
using Food.AbstractFactory.Service;

namespace Food.AbstractFactory
{
    public class AnhuiCuisineFactory : AbstractFactory
    {
        public override IGreens CreateGreens()
        {
            return new AnhuiCuisineGreens();
        }

        public override IMain CreateMain()
        {
            return new AnhuiCuisineMain();
        }

        public override ISoup CreateSoup()
        {
            return new AnhuiCuisineSoup();
        }
    }
}
