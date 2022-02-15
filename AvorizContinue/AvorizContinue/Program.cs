using System;

namespace AvorizContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            string  password = "123456789";
            int tryPass = 0;
            string setUser;
            int continueTry = 5;
            
            while(continueTry > tryPass)
            {
                Console.Write("Введите пароль: ");
                setUser = Console.ReadLine();
            
                if(setUser==password)
                {
                    Console.WriteLine("Добро пожаловать!");
                    break;
                }
                else
                {
                    continueTry--;
                    Console.WriteLine($"Вы вели не правильно, у вас {continueTry} попыток");
                }


            }
        }
    }
}
