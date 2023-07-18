using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Food.Order.Interface;
using Food.Order.Service;
using Food.Order.Decorator;

namespace Food.Order
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 欢迎语
            Console.WriteLine("**********欢迎光临《意志亡灵土菜馆》！吃好喝好玩好哦！**********");
            Thread.Sleep(1000);
            #endregion

            #region 菜单
            Console.WriteLine("\r\n**********《意志亡灵土菜馆》菜单，请您过目！**********");
            Menu menu = new Menu();
            List<Tuple<int, string, int, string>> menus = menu.GetData();
            foreach (Tuple<int, string, int, string> item in menus)
            {
                Console.WriteLine(string.Format("{0}：{1}，价格{2}元；", item.Item1, item.Item2, item.Item3));
            }
            Thread.Sleep(1000);
            #endregion

            #region 点菜、做菜、品尝、点评（一个人吃饭）
            Console.WriteLine("\r\n\r\n**********一个人吃饭演示！**********");
            Console.WriteLine("请输入您要点的菜！");
            string id = Console.ReadLine();
            Done(new int[] { int.Parse(id) }, false, true);
            Thread.Sleep(2000);
            #endregion

            #region 多线程演示（多个人吃饭）
            Console.WriteLine("\r\n\r\n**********多个人吃饭演示！**********");
            Thread.Sleep(1000);

            Console.WriteLine("\r\n呦，三位大人里面请！小二！上茶嘞！");
            Thread.Sleep(1000);

            List<AbstractFood> maxList = new List<AbstractFood>();
            //List<Task> taskList = new List<Task>();
            //TaskFactory taskFactory = new TaskFactory();
            //string[] names = new string[] { "甲", "乙", "丙" };
            //taskList.Add(taskFactory.StartNew((name) =>
            //{
            //    var max = Done(Order((string)name, menus), true);
            //    maxList.Add(max);
            //}, names[0]));
            //taskList.Add(taskFactory.StartNew((name) =>
            //{
            //    var max = Done(Order((string)name, menus), true);
            //    maxList.Add(max);
            //}, names[1]));
            //taskList.Add(taskFactory.StartNew((name) =>
            //{
            //    var max = Done(Order((string)name, menus), true);
            //    maxList.Add(max);
            //}, names[2]));
            //Task.WaitAll(taskList.ToArray());

            string[] names = new string[] { "甲", "乙", "丙" };
            ParallelLoopResult result = Parallel.ForEach(names, (name) =>
            {
                var max = Done(Order((string)name, menus), true);
                maxList.Add(max);
            });
            if (result.IsCompleted)
            {
                AbstractFood maxest = maxList.OrderByDescending(o => o.Score).First();
                Console.WriteLine("********************");
                Console.WriteLine(string.Format("\r\n评分最最高的是：{0}！{1}分！", maxest.Name, maxest.Score));
                Console.ReadKey();
            }
            #endregion
        }

        /// <summary>
        /// 点菜
        /// </summary>
        /// <param name="menus"></param>
        /// <returns></returns>
        private static int[] Order(string name, List<Tuple<int, string, int, string>> menus)
        {
            Console.WriteLine(string.Format("\r\n您好！我是{0}！\r\n{1}正在点菜……", name, name));
            Random random = new Random();
            int[] arrs = menus.Select(t => t.Item1).ToArray();
            int[] items = arrs.OrderBy(i => random.NextDouble()).Take(5).ToArray();
            Thread.Sleep(1000);
            Console.Write(string.Format("{0}点了5个菜：", name));
            foreach (int item in items)
            {
                string mname = menus.FirstOrDefault(w => w.Item1 == item).Item2;
                Console.Write(string.Format("{0}：{1}\t", item, mname));
            }
            Console.WriteLine("\r\n");
            return items;
        }

        /// <summary>
        /// 做菜、品尝、点评
        /// </summary>
        /// <param name="ids"></param>
        private static AbstractFood Done(int[] ids, bool comment = false, bool decorator = false)
        {
            List<AbstractFood> list = new List<AbstractFood>();
            for (int j = 0; j < ids.Length; j++)
            {
                int id = ids[j];
                AbstractFood food = FoodFactory.CreateInstance(id);
                if (decorator)
                {
                    food = new DecoratorCut(food);
                    food = new DecoratorWash(food);
                    food = new DecoratorBuy(food);
                    food = new DecoratorPut(food);
                    food = new DecoratorServe(food);
                }
                food.Cook();
                food.Taste();
                int score = food.Comment();
                list.Add(food);
                Thread.Sleep(500);
            }
            AbstractFood item = list.OrderByDescending(o => o.Score).First();
            if (comment)
            {
                Console.WriteLine(string.Format("\r\n评分最高的是：{0}！{1}分！", item.Name, item.Score));
            }
            return item;
        }
    }
}
