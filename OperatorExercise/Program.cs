namespace OperatorExercise
{
    //Exercise 1
    //Addition: x + y
    //Subtraction: x - y//
    //Multiplication: x* y
    //Division: x / y
    //Modulus: x % y
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;


            //Exercise 2
            Console.WriteLine($"{a}/{b} is {quotient} remainder  {remainder}");

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }


        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}
