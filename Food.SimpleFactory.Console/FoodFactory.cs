using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using Food.Interface;
using Food.Service;

namespace Food.SimpleFactory
{
    /// <summary>
    /// 菜的工厂类
    /// </summary>
    public class FoodFactory
    {
        /// <summary>
        /// 菜的枚举
        /// </summary>
        public enum FoodType
        {
            LuZhouRoastDuck,
            BaogongFish,
            XiaoYaoChicken
        }

        #region 创建实例方式一：普通方法
        public static IFood CreateInstance(FoodType foodType)
        {
            switch (foodType)
            {
                case FoodType.LuZhouRoastDuck:
                    return new LuZhouRoastDuck();
                case FoodType.BaogongFish:
                    return new BaogongFish();
                case FoodType.XiaoYaoChicken:
                    return new XiaoYaoChicken();
                default:
                    throw new Exception("Wrong foodType!");
            }
        }
        #endregion

        #region 创建实例方式二：通过配置
        private static string foodTypeConfig = ConfigurationManager.AppSettings["foodTypeConfig"];

        public static IFood CreateInstanceConfig()
        {
            FoodType foodType = (FoodType)Enum.Parse(typeof(FoodType), foodTypeConfig);
            switch (foodType)
            {
                case FoodType.LuZhouRoastDuck:
                    return new LuZhouRoastDuck();
                case FoodType.BaogongFish:
                    return new BaogongFish();
                case FoodType.XiaoYaoChicken:
                    return new XiaoYaoChicken();
                default:
                    throw new Exception("Wrong foodTypeConfig!");
            }
        }
        #endregion

        #region 创建实例方式三：通过配置+反射
        private static string dllName = ConfigurationManager.AppSettings["dllName"];
        private static string className = ConfigurationManager.AppSettings["className"];

        public static IFood CreateInstanceReflect()
        {
            //object obj = Activator.CreateInstance(assemblyName, typeName).Unwrap();
            //return (IFood)obj;

            Assembly assembly = Assembly.Load(dllName);
            Type type = assembly.GetType(className);
            object obj = Activator.CreateInstance(type);
            return (IFood)obj;
        }
        #endregion
    }
}
