namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Input the first number:");
            string inputFirstAsText = Console.ReadLine();
            int number1 = Convert.ToInt32(inputFirstAsText);

            Console.WriteLine("Input the first number:");
            string inputSecondAsText = Console.ReadLine();
            int number2 = Convert.ToInt32(inputSecondAsText);

            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd numbers");
            Console.WriteLine("[S]ubtract numbers");
            Console.WriteLine("[M]ultiply numbers");


            var userChoice = Console.ReadLine();
            if (EqualsCaseSensitive(userChoice, "A"))
            {
               
                var sum = number1 + number2;
                PrintFinalEquation(number1, number2, sum, "+");
            }

            else if (EqualsCaseSensitive(userChoice, "S"))
            {
                
                var difference = number1 - number2;
                PrintFinalEquation(number1, number2, difference, "-");
            }
            else if (EqualsCaseSensitive(userChoice, "M"))
            {

                var multiplied= number1 * number2;
                PrintFinalEquation(number1, number2, multiplied, "+");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.WriteLine("Press any key to close the app..");
            Console.ReadKey(); 

            void PrintFinalEquation(int number1 , int number2,  int result, string @operator)
            {
                Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
            }

            bool EqualsCaseSensitive(string left,string right)
            {
                return left.ToUpper() == right.ToUpper();
            }
        }
    }
}
