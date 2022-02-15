using System;

namespace GameConsoleWhoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, lower, large;
            int tryCount = 5;
            Random random = new Random();
            int userInput;
            //число которое загадывается
            number = random.Next(0, 101);
            //подсказка lower больше чем, large меньше чем
            lower = random.Next(number - 10, number);
            large = random.Next(number + 1, number + 10);

            Console.WriteLine($"Мы загадали число, оно больше чем {lower}, но меньше чем {large}");
            while(tryCount-- > 0)
            {
                Console.Write("Это число: ");
                userInput=Convert.ToInt32(Console.ReadLine());

                if(userInput==number)
                {
                    Console.WriteLine("Вы правы это число: " + number);
                    break;
                }
                else
                {
                    Console.WriteLine("Вы не угадали, попробуй еще, у вас осталось попыток " + tryCount);
                }

            }

            if (tryCount < 0)
                Console.WriteLine("Увы но вы не угадали, число было" + number);
        }
    }
}
