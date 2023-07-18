using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Food.Order.Interface;
using Food.Order.Service;

namespace Food.Order
{
    /// <summary>
    /// Food工厂类
    /// </summary>
    public class FoodFactory
    {
        /// <summary>
        /// Food枚举
        /// </summary>
        public enum FoodType
        {
            LuZhouRoastDuck,//庐州烤鸭
            BaogongFish,//包公鱼
            XiaoYaoChicken,//逍遥鸡
            MapoTofu,//麻婆豆腐
            SpicyChicken,//辣子鸡
            Tangstory,//鱼香肉丝
            Bouilli,//红烧肉
            ChilliFishHead//剁椒鱼头
        }

        #region 普通方式
        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static AbstractFood CreateInstance(int id)
        {
            Menu menu = new Menu();
            List<Tuple<int, string, int, string>> menus = menu.GetData();
            Tuple<int, string, int, string> item = menus.FirstOrDefault(o => o.Item1 == id);
            string name = item.Item2;
            int price = item.Item3;
            FoodType foodType = (FoodType)(Enum.Parse(typeof(FoodType), item.Item4));
            switch (foodType)
            {
                case FoodType.LuZhouRoastDuck:
                    return new LuZhouRoastDuck(name, price, "");
                case FoodType.BaogongFish:
                    return new BaogongFish(name, price, "");
                case FoodType.XiaoYaoChicken:
                    return new XiaoYaoChicken(name, price, "");
                case FoodType.MapoTofu:
                    return new MapoTofu(name, price, "");
                case FoodType.SpicyChicken:
                    return new SpicyChicken(name, price, "");
                case FoodType.Tangstory:
                    return new Tangstory(name, price, "");
                case FoodType.Bouilli:
                    return new Bouilli(name, price, "");
                case FoodType.ChilliFishHead:
                    return new ChilliFishHead(name, price, "");
                default:
                    throw new Exception("Wrong foodType!");
            }
        }
        #endregion

        #region 配置、反射方式
        private static string dllName = ConfigurationManager.AppSettings["dllName"];
        private static string className = ConfigurationManager.AppSettings["className"];

        /// <summary>
        /// 创建实例
        /// </summary>
        /// <returns></returns>
        public static AbstractFood CreateInstanceReflect()
        {
            Assembly assembly = Assembly.Load(dllName);
            Type type = assembly.GetType(className);
            object obj = Activator.CreateInstance(type);
            return (AbstractFood)obj;
        }
        #endregion
    }
}
