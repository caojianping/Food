using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Order.Service;

namespace Food.Order.Decorator
{
    /// <summary>
    /// 洗菜
    /// </summary>
    public class DecoratorWash : BaseDecorator
    {
        private AbstractFood _AbstractFood = null;
        public DecoratorWash(AbstractFood food) : base(food)
        {
            this._AbstractFood = food;
        }

        public override void Cook()
        {
            Console.WriteLine("洗菜！");
            this._AbstractFood.Cook();            
        }
    }
}
