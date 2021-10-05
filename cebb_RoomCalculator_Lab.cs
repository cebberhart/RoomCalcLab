using System;

namespace LabProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //0) ask user for length and width of room
            //1) get user input
            //2) convert the input into double
            //3) run formula and store result for Area
            //4) run formula and store result for Perimeter
            //5) run formula for Height
            //6) run formula for Paint
            //7) run formula for Carpit
            //8) print results to console
            //9) prompt user to continue onto another room

            
            bool calcAgain = true;
            while (calcAgain)
            {
                Console.WriteLine("Welcome to the Paint and Carpet Calculator!");

                Console.WriteLine("Please input the length of your room!");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Please input the width of you room!");
                double width = double.Parse(Console.ReadLine());

                double area = length * width;

                double perimeter = 2 * (length + width);

                double height = area / length;

                double carpetPerSqrFoot = area / 5.0;

                double result = ((2 * length * height) + (2 * width * height) + (length * width));

                double paintPerSqrFoot = 4 * length * width * height / result;

                Console.WriteLine("Length: " + length);
                Console.WriteLine("Width: " + width);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Carpet Tiles: " + carpetPerSqrFoot);
                Console.WriteLine("Paint: " + paintPerSqrFoot);

                Console.WriteLine("Would you like to continue onto another room? [y/n]");

                string loop = Console.ReadLine();
                if (loop == "y")
                    calcAgain = true;
                else if (loop == "n")
                    calcAgain = false;
                
            }
                Console.ReadLine();
            
         

           



            

            



           
           
            
            

           

        }   
        
    }
}
