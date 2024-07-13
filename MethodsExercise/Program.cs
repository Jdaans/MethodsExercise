

using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //MadLib();

            int added = Add(5, 5);
            Console.WriteLine(added);

            int Subtracted = Subtract(20, 15);
            Console.WriteLine(Subtracted);

            int multiplied = Multiply(20, 15);
            Console.WriteLine(multiplied);

            int divided = Divide(20, 15);
            Console.WriteLine(divided);

           

        }



        public static void MadLib()
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello {userName}! what is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("what is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("what is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine($"Last week {userName} saw a {favAnimal} on stage while {favBand} was performing and they were all wearing {favColor} shirts.");

        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        
            








    }

    
}
