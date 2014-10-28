using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    class Program
    {
        /// <summary>
        /// Main method in class program, calls different methods and read manu choice from user.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            do
            {
            Console.Title = "Geometriska figurer - Nivå C";
            Console.Clear();
            ViewMenu();
            
                try
                {
                    int index = int.Parse(Console.ReadLine());
                    if (index < 0 || index > 8)
                    {
                        throw new Exception();
                    }
                    Shape shape;
                    switch (index)
                    {
                        case 0:
                            return;
                        case 1:
                            shape = CreateShape(ShapeType.Rectangle);
                            ViewShapeDetail(shape);
                            break;
                        case 2:
                            shape = CreateShape(ShapeType.Circle);
                            ViewShapeDetail(shape);
                            break;
                        case 3:
                            shape = CreateShape(ShapeType.Ellipse);
                            ViewShapeDetail(shape);
                            break;
                        case 4:
                            shape = CreateShape(ShapeType.Cuboid);
                            ViewShapeDetail(shape);
                            break;
                        case 5:
                            shape = CreateShape(ShapeType.Cylinder);
                            ViewShapeDetail(shape);
                            break;
                        case 6:
                            shape = CreateShape(ShapeType.Sphere);
                            ViewShapeDetail(shape);
                            break;
                        case 7:
                            ViewShapes(Randomize2DShapes());
                            break;
                        case 8:
                            ViewShapes(Randomize3DShapes());
                            break;

                    }
                }
                catch (Exception)
                {
                    ViewMenuErrorMessage("FEL! Ange ett nummer mellan 0 och 8. ");
                }
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n");
                    Console.WriteLine(" {0} ", Extensions.CenterAlignString("Tryck tangent för att fortsätta", PartOfMenu(1)));
                    Console.Write("\n");
                    Console.ResetColor();

                    Console.ReadKey();
                    Console.Clear();
                
            } while (true) ;
        }
        /// <summary>
        /// Create new shape
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        private static Shape CreateShape(ShapeType shapeType)
        {
            Console.Clear();
            string model = Extensions.AsText(shapeType);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("={0}=", PartOfMenu(1));
            Console.WriteLine("={0}=", Extensions.CenterAlignString(model, PartOfMenu(1)));
            Console.WriteLine("={0}=", PartOfMenu(1));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            double[] userInputs = ReadDimensions(shapeType);

            switch (Extensions.AsText(shapeType))
            {
                case "Cuboid":
                    return new Cuboid(userInputs[0], userInputs[1], userInputs[2]);
                case "Cylinder":
                    return new Cylinder(userInputs[0], userInputs[1], userInputs[2]);
                case "Ellipse":
                    return new Ellipse(userInputs[0], userInputs[1]);
                case "Rectangle":
                    return new Rectangle(userInputs[0], userInputs[1]);
                case "Sphere":
                    return new Sphere(userInputs[0]);
                default:
                    return new Ellipse(userInputs[0]);
            }
        }
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            string title = Extensions.CenterAlignString("Geometriska figurer", PartOfMenu(1));
            Console.WriteLine("={0}=", PartOfMenu(1));
            Console.WriteLine("={0}=", PartOfMenu(2));
            Console.WriteLine("={0}=", title);
            Console.WriteLine("={0}=", PartOfMenu(2));
            Console.WriteLine("={0}=", PartOfMenu(1));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n0. Avsluta.");
            Console.WriteLine("1. Rektangel.");
            Console.WriteLine("2. Cirkel.");
            Console.WriteLine("3. Ellips.");
            Console.WriteLine("4. Rätblock.");
            Console.WriteLine("5. Cylinder.");
            Console.WriteLine("6. Sfär.");
            Console.WriteLine("7. Slumpa 2D-figurer.");
            Console.WriteLine("8. Slumpa 3D-figurer.\n");
            Console.WriteLine("={0}=", PartOfMenu(1));
            Console.Write("\nAnge menyval [0-8]:");
        }
        /// <summary>
        /// Help for display of headers....
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        private static string PartOfMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    return "===================================";
                case 2:
                    return "                                   ";
                case 3:
                    return "___________________________________________";
                case 4:
                    return "___________________________________________________________________";
                case 5:
                    return "-------------------------------------------------------------------";
                default:
                    return "-------------------------------------------";
            }
        }
        /// <summary>
        /// Randomize random number of 2D shapes
        /// </summary>
        /// <returns></returns>
        private static Shape2D[] Randomize2DShapes()
        {
            Random random = new Random();
            int numberOfShapes = random.Next(5, 21);
            Shape2D[] newShapes = new Shape2D[numberOfShapes];
            Random randomArr = new Random();


            for (int i = 0; i < numberOfShapes; i++)
            {
                randomArr.Next(5, 100);

                switch (random.Next(0, 3))
                {
                    case 0:
                        newShapes[i] = new Ellipse(GetRandomNumber(5.0, 100.0, randomArr), GetRandomNumber(5.0, 100.0, randomArr));
                        break;
                    case 1:
                        newShapes[i] = new Ellipse(GetRandomNumber(5.0, 100.0, randomArr));
                        break;
                    case 2:
                        newShapes[i] = new Rectangle(GetRandomNumber(5.0, 100.0, randomArr), GetRandomNumber(5.0, 100.0, randomArr));
                        break;
                }
            }
            Array.Sort(newShapes);
            return newShapes;
        }
        /// <summary>
        /// Randomize random number of 3D shapes
        /// </summary>
        /// <returns></returns>
        private static Shape3D[] Randomize3DShapes()
        {
            Random random = new Random();
            int numberOfShapes = random.Next(5, 21);
            Shape3D[] newShapes = new Shape3D[numberOfShapes];
            Random randomArr = new Random();
            for (int i = 0; i < numberOfShapes; i++)
            {
                int choice = random.Next(0, 3);
                randomArr.Next(5, 100);
                switch (random.Next(0, 3))
                {
                    case 0:
                        newShapes[i] = new Cuboid(GetRandomNumber(5.0, 100.0, randomArr), GetRandomNumber(5.0, 100.0, randomArr), GetRandomNumber(5.0, 100.0, randomArr));
                        break;
                    case 1:
                        newShapes[i] = new Cylinder(GetRandomNumber(5.0, 100.0, randomArr), GetRandomNumber(5.0, 100.0, randomArr), GetRandomNumber(5.0, 100.0, randomArr));
                        break;
                    case 2:
                        newShapes[i] = new Sphere(GetRandomNumber(5.0, 100.0, randomArr));
                        break;
                }
            }
            Array.Sort(newShapes);
            return newShapes;
        }
        /// <summary>
        /// Returns random number between two doubles. I could maybe do this in extensions.
        /// http://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
        /// </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <returns></returns>
        private static double GetRandomNumber(double minimum, double maximum, Random random)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
        /// <summary>
        /// Call method ReadDoublesGreaterThanZero and sends arguments, message in console and number of values that user has to write.
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        private static double[] ReadDimensions(ShapeType shapeType)
        {
            switch (Extensions.AsText(shapeType))
            {
                case "Cuboid":
                    return ReadDoublesGreaterThanZero("Ange figurens längd, bredd och höjd:", 3);
                case "Cylinder":
                    return ReadDoublesGreaterThanZero("Ange figurens längd, bredd och höjd:", 3);
                case "Ellipse":
                    return ReadDoublesGreaterThanZero("Ange figurens längd och bredd:", 2);
                case "Rectangle":
                    return ReadDoublesGreaterThanZero("Ange figurens längd och bredd:", 2);
                default:
                    return ReadDoublesGreaterThanZero("Ange figurens diameter:"); // Circle and Sphere
            }
        }
        /// <summary>
        /// Reads user input in console.
        /// Splits it into given number of strings and writes it to an array
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="numberOfValues"></param>
        /// <returns></returns>
        private static double[] ReadDoublesGreaterThanZero(string prompt, int numberOfValues = 1)
        {
            while (true)
            {
                Console.Write("\n{0}", prompt);
                string userInput = Console.ReadLine();
                string[] inputs = userInput.Split(' ');
                double[] valideInputs = new double[numberOfValues];
                try
                {
                    if (inputs.Length != numberOfValues)
                        throw new Exception("FEL! Ett fel inträffade då figurens dimensioner tolkades.");

                    for (int i = 0; i < numberOfValues; i++)
                    {
                        valideInputs[i] = double.Parse(inputs[i]);
                        if (valideInputs[i] <= 0)
                            throw new Exception("FEL! Ett fel inträffade då figurens dimensioner tolkades.");
                    }
                    return valideInputs;
                }
                catch (Exception e)
                {
                    ViewMenuErrorMessage(e.Message);
                }
            }
        }
        /// <summary>
        /// Display error messages
        /// </summary>
        /// <param name="message"></param>
        private static void ViewMenuErrorMessage(string message)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        /// <summary>
        /// Showes details of one Shape
        /// </summary>
        /// <param name="shape"></param>
        private static void ViewShapeDetail(Shape shape)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("={0}=", PartOfMenu(1));
            Console.WriteLine("={0}=", Extensions.CenterAlignString("Detaljer", PartOfMenu(1)));
            Console.WriteLine("={0}=", PartOfMenu(1));
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(shape.ToString("G"));
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("={0}=", PartOfMenu(1));
            Console.ResetColor();
        }
        /// <summary>
        /// Display shape´s details in console.
        /// </summary>
        /// <param name="shapes"></param>
        private static void ViewShapes(Shape[] shapes)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            if (shapes[0].IsShape3D)
            {
                Console.WriteLine("{0}", PartOfMenu(5));
                Console.WriteLine(string.Format("{0,-11}{1,5}{2,6}{3,6}{4,13}{5,13}{6,13}", "Figur", "Längd", "Bredd", "Höjd", "Mantelarea", "Begräns.area", "Volym"));
                Console.WriteLine("{0}", PartOfMenu(4));
            }
            else
            {
                Console.WriteLine("{0}", PartOfMenu(6));
                Console.WriteLine(string.Format("{0,-12}{1,8}{2,6}{3,8}{4,9}", "Figur", "Längd", "Bredd", "Omkrets", "Area"));
                Console.WriteLine("{0}", PartOfMenu(3));
            }
            Console.ResetColor();

            /*Iterates all members in area and display details*/
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString("R"));
            }
        }
    }
}
