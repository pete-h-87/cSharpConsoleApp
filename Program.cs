using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What monument would you like to work with?");
            Console.WriteLine("(1)Teotihuacan, (2)Taj Mahaal, (3)Great Mosque of Mecca : ");

            string? monument = Console.ReadLine();

            double totalCost;

            switch (monument)
            {
                case "1":
                    totalCost = TeotihuacanPrice();
                    break;
                case "2":
                    totalCost = TajPrice();
                    break;
                case "3":
                    totalCost = MecPrice();
                    break;
                default:
                    totalCost = 0;
                    break;
            }

            if (totalCost != 0)
            {
                Console.WriteLine($"The total cost would be: {totalCost} dollars!");
            }
            else
            {
                Console.WriteLine("Please choose one of the three options.");
                Console.WriteLine("(1)Teotihuacan, (2)Taj Mahaal, (3)Great Mosque of Mecca : ");
            }
        }

        static double TeotihuacanPrice()
        {
            double totalArea = Rect(2500, 1500) + Tri(500, 750) + (Circ(375) / 2);
            double roundedPrice = Math.Round(totalArea * 180, 2);
            return roundedPrice;
        }

        static double TajPrice()
        {
            double totalArea = Rect(90.5, 90.5) - Tri(24, 24) * 2;
            double roundedPrice = Math.Round(totalArea * 180, 2);
            return roundedPrice;
        }

        static double MecPrice()
        {
            double totalArea = Rect(284, 264) + Rect(180, 106) - Tri(264, 84);
            double roundedPrice = Math.Round(totalArea * 180, 2);
            return roundedPrice;
        }

        static double Rect(double length, double width)
        {
            return (length * width);
        }

        static double Circ(double radius)
        {
            double pi = Math.PI;
            double sqRadius = Math.Pow(radius, 2);
            return (pi * sqRadius);
        }

        static double Tri(double bottom, double height)
        {
            return ((bottom * height) / 2);
        }
    }
}


