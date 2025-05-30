using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Point<T>
    {
        public T X { get; set; }
        public T Y { get; set; } 
        public Point() { }
        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"X = {X}\nY = {Y}");
        }
    }
}
