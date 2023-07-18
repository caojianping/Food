using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Food.Interface;

namespace Food.ServiceExtend
{
    /// <summary>
    /// 老干妈
    /// </summary>
    public class Godmother : IFood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Godmother(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void Show()
        {
            Console.WriteLine(string.Format("大家好！我是{0}，这是我的老干妈！", this.Name));
        }
    }
}
