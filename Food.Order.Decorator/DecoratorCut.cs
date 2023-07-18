using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Order.Service;

namespace Food.Order.Decorator
{
    /// <summary>
    /// 切菜
    /// </summary>
    public class DecoratorCut : BaseDecorator
    {
        private AbstractFood _AbstractFood = null;
        public DecoratorCut(AbstractFood food) : base(food)
        {
            this._AbstractFood = food;
        }

        public override void Cook()
        {
            Console.WriteLine("切菜！");
            this._AbstractFood.Cook();            
        }
    }
}
