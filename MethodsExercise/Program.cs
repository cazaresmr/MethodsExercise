using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var favBand = Console.ReadLine();

            Console.WriteLine($"Once upon a time, {name} was walking through the forest. Suddenly, a {favColor} {favAnimal} appeared. {name} was so scared, but then the {favColor} {favAnimal} started singing {favBand} songs. {name} was so happy and started dancing with the {favColor} {favAnimal}. The end.");

            // Math operations
            Console.WriteLine(Add(5, 5));
            Console.WriteLine(Subtract(10, 5));
            Console.WriteLine(Multiply(5, 5));
            Console.WriteLine(Divide(10, 2));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }
    }
}
