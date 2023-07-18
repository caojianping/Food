using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Order.Service;

namespace Food.Order.Decorator
{
    /// <summary>
    /// 基装饰器类
    /// </summary>
    public class BaseDecorator : AbstractFood
    {
        private AbstractFood _AbstractFood = null;

        public BaseDecorator(AbstractFood food)
        {
            this._AbstractFood = food;
        }

        public override void Cook()
        {
            this._AbstractFood.Cook();
        }
    }
}
