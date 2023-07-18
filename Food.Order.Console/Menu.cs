using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Food.Order
{
    /// <summary>
    /// 菜单
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// 菜单配置文件
        /// </summary>
        private static string config = ConfigurationManager.AppSettings["menus"];

        /// <summary>
        /// 菜单数据结构 Tuple<int, string, int, string> 分别表示 编号、名称、价格、类名称
        /// </summary>
        private static List<Tuple<int, string, int, string>> data = new List<Tuple<int, string, int, string>>();

        static Menu()
        {
            string[] arrs = config.Split(new char[] { ';', '；' });
            foreach (string item in arrs)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] parts = item.Split(new char[] { ',', '，' });
                string id = parts.Length >= 1 ? parts[0] : string.Empty;
                string name = parts.Length >= 2 ? parts[1] : parts[0];
                string price = parts.Length >= 3 ? parts[2] : parts[1];
                string cname = parts.Length >= 4 ? parts[3] : parts[2];
                data.Add(new Tuple<int, string, int, string>(int.Parse(id), name, int.Parse(price), cname));
            }
        }

        public List<Tuple<int, string, int, string>> GetData()
        {
            return data;
        }
    }
}
