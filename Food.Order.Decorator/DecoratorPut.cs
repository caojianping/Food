using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Order.Service;

namespace Food.Order.Decorator
{
    /// <summary>
    /// 摆菜
    /// </summary>
    public class DecoratorPut : BaseDecorator
    {
        private AbstractFood _AbstractFood = null;
        public DecoratorPut(AbstractFood food) : base(food)
        {
            this._AbstractFood = food;
        }

        public override void Cook()
        {
            this._AbstractFood.Cook();
            Console.WriteLine("摆菜！");
        }
    }
}
