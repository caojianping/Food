using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Order.Service
{
    public abstract class AbstractFood
    {
        public AbstractFood() { }

        public AbstractFood(string name, int price, string intro)
        {
            this.Name = name;
            this.Price = price;
            this.Intro = intro;
        }

        public string Name { get; set; }

        public int Price { get; set; }

        public string Intro { get; set; }

        public int Score { get; set; }

        public void Taste()
        {
            Console.WriteLine(string.Format("开始品尝{0}!", this.Name));
        }

        public virtual int Comment()
        {
            int score = new Random().Next(50, 100);
            this.Score = score;
            Console.WriteLine(string.Format("{0}评分：{1}", this.Name, score));
            return score;
        }

        public abstract void Cook();
    }
}
