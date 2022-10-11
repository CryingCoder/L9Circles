namespace L9Circles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INITIALIZE VARIABLES
            double radius = 0;
            string area = "";
            string circumference = "";
            bool goAgain = true;
            int circleCount = 0;


            //GREETING  
            Console.WriteLine("Welcome to the Circle Tester");

            //LOOP ASKING FOR INPUT ON RERUNNING THE PROGRAM
            while (goAgain)
            {
                
                //LOOP FOR VALIDATING USER INPUT
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter radius:");
                        radius = double.Parse(Console.ReadLine());
                        if (radius < 0)
                        {
                            Console.WriteLine("Please enter a positive number value");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }

                //FUNCTION TO INCREMENT NUMBER OF CIRCLE RADIUS' REQUESTED
                circleCount++;          


                //CALLING CIRCLE CLASS TO INITIALIZE NEW VARIABLE
                Circle myCircle = new Circle(radius);


                //CALCULATION FOR AREA - USING CIRCLE CLASS
                area = myCircle.CalculateFormattedArea();
                //CALCULATION FOR CIRCUMFERENCE - USING CIRCLE CLASS
                circumference = myCircle.CalculateFormattedCircumference();
                //OUTPUT CALCULATIONS FOR AREA AND CIRCUMFERENCE TO CONSOLE
                Console.WriteLine($"Circumference: {circumference}\nArea: {area}");

 
                //LOOP TO INQUIRE IF THE USER WOULD LIKE TO CONTINUE - OTHERWISE OUTPUT CIRCLECOUNT
                while (true)
                {
                    Console.WriteLine("Continue?(y/n)");
                    string input = Console.ReadLine().ToLower().Trim();

                    if (input == "n")
                    {
                        Console.WriteLine($"Goodbye. You created {circleCount} Circle object(s).");
                        goAgain = false;
                        break;
                    }
                    else if (input == "y")
                    {
                     
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter y/n");

                    }
                }
            }
        }
    }
}