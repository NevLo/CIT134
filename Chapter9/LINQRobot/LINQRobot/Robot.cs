using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQRobot
{
    public class Robot
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public char Model  { get; set; }

        //Constructors
        public Robot() { }
        public Robot(string s, decimal p, char m)
        {
            Name = s;
            Price = p;
            Model = m;
        }

        //Override the toString
        public override string ToString()
        {
            if(this.GetType().IsArray){
                for(int i = 0; i < this.GetType().GetArrayRank(); i++)
                {
                    //this[i];
                }
            }
            return $"{Name, -7} | {Model, -3} | {Price, 10:C}";
        }
    }
}
