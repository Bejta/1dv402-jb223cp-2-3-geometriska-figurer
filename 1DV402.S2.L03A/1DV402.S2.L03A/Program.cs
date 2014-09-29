using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Title="Geometriska figurer -Nivå A";
            do
            {
                Console.Clear();
                ViewMenu();
                string input = Console.ReadLine();
                try
                {
                    int userChoice = int.Parse(input);
                    if (userChoice < 0 || userChoice > 2)
                    {
                        throw new OverflowException();
                    }
                    switch (userChoice)
                    {
                        case 0: return;
                        case 1: ViewShapeDetail(CreateShape(ShapeType.Elipse));
                            break;
                        case 2: ViewShapeDetail(CreateShape(ShapeType.Rectangle));
                            break;
                    }
                }
                catch(OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Ange ett nummer mellan 0 och 2!");
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! {0} kan inte tolkas som ett giltigt värde!", input);
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nTryck tangent för att fortsätta. Esc - avslutar");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        private static Shape CreateShape(ShapeType ShapeType)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine(" ========================================");
            switch(ShapeType)
            {
                case ShapeType.Elipse:
                    Console.WriteLine(" =                Ellips                =");
                    break;
                case ShapeType.Rectangle:
                    Console.WriteLine(" =              Rektangel               =");
                    break;
            }
            Console.WriteLine(" ========================================\n");
            Console.ResetColor();
            double length = ReadDoubleGreaterThanZero("\nAnge längden:");
            double width = ReadDoubleGreaterThanZero("\nAnge höjden:");
            if (ShapeType==ShapeType.Elipse)
            {
                Elipse myElipse = new Elipse(length, width);
                return myElipse;
            }
            Rectangle myRectangle = new Rectangle(length, width);
            return myRectangle;
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(prompt);
                string userInput = Console.ReadLine();
                try
                {
                    double value = double.Parse(userInput);
                    if (value<=0)
                    {
                        throw new OverflowException();
                    }
                    return value; ;
                }
                catch(OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! Ange ett flyttal större än 0");
                    Console.ResetColor();
                }
                catch(FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFEL! {0} kan inte tolkas som ett giltigt värde!", userInput);
                    Console.ResetColor();
                }
            }
        }
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ========================================");
            Console.WriteLine(" =                                      =");
            Console.WriteLine(" =          Geometriska figurer         =");
            Console.WriteLine(" =                                      =");
            Console.WriteLine(" ========================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n 0. Avsluta.");
            Console.WriteLine("\n 1. Ellips.");
            Console.WriteLine("\n 2. Rektangel.");
            Console.WriteLine("\n ========================================");
            Console.Write("\n Ange menyval [0-2]:");
            Console.ResetColor();
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n ========================================");
            Console.WriteLine(" =               Detaljer               =");
            Console.WriteLine(" ========================================\n");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("\n ========================================\n");
        }
    }
}
