
using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name:");

            //string UserName = Console.ReadLine();

            //Console.WriteLine($"Hello, {UserName}");

            //Console.WriteLine("What is your favorite color?");

            //String favoriteColor = Console.ReadLine();

            //Console.WriteLine("What is your favorite animal?");

            //string favoriteAnimal = Console.ReadLine();

            //Console.WriteLine("What is your favorite song?");

            //string favoriteSong = Console.ReadLine();

            //Console.WriteLine($"Hello {UserName}, your favorite color is {favoriteColor}, you want a {favoriteAnimal} and your favorite song is {favoriteSong}");

            //exercise 2

            Console.WriteLine("What number to add:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number:");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is : {sum}");

            Console.WriteLine("What number to multiply:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number:");
            int num2 = int.Parse(Console.ReadLine()) ;

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;



        }


        public static int Multiply(int x , int y )
        {
            return x * y;
        }
    }

}
