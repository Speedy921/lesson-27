using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_27
{
    public class Point: ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        //переопределить Objeect.ToString()

        public override string ToString() => $"{X}:{Y}";

        //Возвратить копию текущего обьекта 
        public  object Clone() => new Point(this.X, this.Y);
    }
}
