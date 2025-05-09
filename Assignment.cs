namespace Assignment
{
    class AssignmentClass
    {
        public static void Task1()
        {
            string myName = "Wesley";
            Console.WriteLine("Hello");
            Console.WriteLine(myName + '\n');
        }

        public static void Task2()
        {
            int a = 10;
            int b = 20;

            int sum = a + b;

            Console.WriteLine("The sum of " + a + " + " + b + " = " + sum + '\n');
        }

        public static void Task3()
        {
            int a = 50;
            int b = 5;

            int division = a / b;

            Console.WriteLine("The division of " + a + " by " + b + " = " + division + '\n');
        }

        public static void Task4()
        {
            int a = 7;
            int b = 5;

            int addition = a + b;
            int substraction = a - b;
            int multiplication = a * b;
            int division = a / b;

            Console.WriteLine("Addition: " + addition);
            Console.WriteLine("Substraction: " + substraction);
            Console.WriteLine("Multiplication: " + multiplication);
            Console.WriteLine("Division: " + division);
            Console.WriteLine("\n");
        }

        public static void Task5()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            decimal average = (a + b + c + d) / 4;
            Console.WriteLine("Average: " + average);
            Console.WriteLine('\n');
        }

        public static void Task6()
        {
            // Convert Celcius to Fahrenheit
            double c = 0;
            double f = (c * (9/5) + 32);
            Console.WriteLine("Conversion of " + c + " Celcius to Fahrenheit is: " + f);

            // Convert Fahrenheit to Celcius
            double f2 = 32;
            double c2 = (f - 32) * 5/9;
            Console.WriteLine("Conversion of " + f2 + " Fahrenheit to Celcius is: " + c2);
        }
    }
}