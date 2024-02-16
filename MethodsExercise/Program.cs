namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");

            string UserName = Console.ReadLine();

            Console.WriteLine($"Hello, {UserName}");

            Console.WriteLine("What is your favorite color?");

            String favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");

            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite song?");

            string favoriteSong = Console.ReadLine();

            Console.WriteLine($"Hello {UserName}, your favorite color is {favoriteColor}, you want a {favoriteAnimal} and your favorite song is {favoriteSong}");
        }
    }
}
