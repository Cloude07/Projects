using System;

namespace zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача:
             Вывести имя в прямоугольник из символа, которые введет сам пользователь.
     Вы запрашиваете имя, после запрашиваете символ, а после отрисовываете в консоль его имя в прямоугольнике из его символов.  */
            Console.WriteLine("Напишите свое имя: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Введите символ: ");
            char inputUse = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            for(int i=0;i<inputName.Length + 2;i++)
            {
                Console.Write(inputUse);
            }
            Console.WriteLine("\n"+ inputUse + "" + inputName + "" + inputUse);
            for (int i = 0; i < inputName.Length + 2; i++)
            {
                Console.Write(inputUse);
            }
            Console.ReadKey();


        }
    }
}
