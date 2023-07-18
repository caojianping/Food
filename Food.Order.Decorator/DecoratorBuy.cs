using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Order.Service;

namespace Food.Order.Decorator
{
    /// <summary>
    /// 买菜
    /// </summary>
    public class DecoratorBuy : BaseDecorator
    {
        private AbstractFood _AbstractFood = null;
        public DecoratorBuy(AbstractFood food) : base(food)
        {
            this._AbstractFood = food;
        }

        public override void Cook()
        {
            Console.WriteLine("买菜！");
            this._AbstractFood.Cook();            
        }
    }
}
