using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite place to visit?");
            string favoriteHoliday = Console.ReadLine();
            Console.WriteLine("What is the name of a close friend?");
            string friendOne = Console.ReadLine();
            Console.WriteLine("What is the name of another friend?");
            string friendTwo = Console.ReadLine();
            Console.WriteLine("What is your favorite fantasy or mythical creature?");
            string monster = Console.ReadLine();

            Console.WriteLine($"Traveling is my favorite thing to do and hands down my most memorable trip took place in {favoriteHoliday}.");
            Console.WriteLine($"I remember going with my best friends {friendOne} and {friendTwo}. They also thought it was the best trip ever.");
            Console.WriteLine($"{friendOne} had traveled to {favoriteHoliday} before, this was my first time ever seeing such an amazing place!");
            Console.WriteLine($"Our favorite memory had to be when all three of us got to ride on the back of a {monster}! I didn't even think any of these existed!!");
            Console.WriteLine($"To this day {friendOne} and {friendTwo} still talk about this all the time.");


            int sum = Add(12, 8);
            Console.WriteLine($"12 plus 8 is {sum}.");

            int sub = Minus(80, 20);
            Console.WriteLine($"80 minus 20 is {sub}.");

            int prod = Times(19, 3);
            Console.WriteLine($"19 times 3 is {prod}.");

            int quot = Divide(21, 7);
            Console.WriteLine($"21 divided by 7 is {quot}.");

            static int Add(int num1, int num2)
            {
                int sum = num1 + num2;

                return sum;

            }
            static int Minus(int num1, int num2)
            {
                int diff = num1 - num2;

                return diff;

            }
            static int Times(int num1, int num2)
            {
                int prod = num1 / num2;

                return prod;
            }
            static int Divide(int num1, int num2)
            {

                int quot = num1 / num2;

                return quot;
                

               






            }
        }
    }
}
