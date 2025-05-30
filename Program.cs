using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите int X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите int Y: ");
            int y = int.Parse(Console.ReadLine());
            Point<int> point = new Point<int>(x, y);
            point.DisplayInfo();

            Console.Write("Введите uint X: ");
            uint xUint = uint.Parse(Console.ReadLine());
            Console.Write("Введите uint Y: ");
            uint yUint = uint.Parse(Console.ReadLine());
            Point<uint> pointUint = new Point<uint>(xUint, yUint);
            pointUint.DisplayInfo();

            Console.Write("Введите double X: ");
            double xD = double.Parse(Console.ReadLine());
            Console.Write("Введите double Y: ");
            double yD = double.Parse(Console.ReadLine());
            Point<double> pointD = new Point<double>(xD, yD);
            pointD.DisplayInfo();

            Console.Read();
        }
    }
}
