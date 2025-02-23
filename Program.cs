using System;

namespace ArchitectArithmetic {
    class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
        }

        static double TeotihuacanPrice()
    {
      double totalArea = Rect(2500, 1500) + Tri(500, 750) + (Circ(375)/2);
      double price = totalArea*180;
      double roundedPrice = Math.Round(price, 2);

      return (roundedPrice);
    }

    static double Rect(double length, double width)
    {
      return (length*width);
    }

    static double Circ(double radius)
    {
      double pi = Math.PI;
      double sqRadius = Math.Pow(radius, 2);
      return (pi*sqRadius);
    }

    static double Tri(double bottom, double height)
    {
      return ((bottom*height)/2);
    }
    }
}


