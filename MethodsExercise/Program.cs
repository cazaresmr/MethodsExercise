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

            Console.WriteLine(Sum(2, 4));
            Console.WriteLine(Sum(2, 4, 6));
            Console.WriteLine(Sum(1, 1, 1, 1, 1));
            Console.WriteLine(Subtract(10, 3, 2));
            Console.WriteLine(Multiply(2, 3, 4));
            Console.WriteLine(Divide(100, 2, 5));
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static int Subtract(params int[] numbers)
        {
            if (numbers.Length == 0) throw new ArgumentException("At least one number is required");

            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }
            return result;
        }

        public static int Multiply(params int[] numbers)
        {
            if (numbers.Length == 0) throw new ArgumentException("At least one number is required");

            int product = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }

        public static int Divide(params int[] numbers)
        {
            if (numbers.Length == 0) throw new ArgumentException("At least one number is required");

            int result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                result /= numbers[i];
            }
            return result;
        }
    }
}
