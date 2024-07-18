namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
Write a C# program that takes user input and creates a story. Ask the user for things like a name, color, an animal, etc. Make up a story and be creative.
            */
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            var favBand = Console.ReadLine();
            Console.WriteLine($"Once upon a time, {name} was walking through the forest. Suddenly, a {favColor} {favAnimal} appeared. {name} was so scared, but then the {favColor} {favAnimal} started singing {favBand} songs. {name} was so happy and started dancing with the {favColor} {favAnimal}. The end.");
        }
    }
}
