namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();

            
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

        
    }
}
