using System;

namespace DzMethodStringCount
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCount();
            Console.ReadKey();
        }

        static void StringCount()
        {
            string text = Console.ReadLine();
            //split записывает количество пропусков, получается проверка каждого слова
           int count = text.Split(" ").Length;
            Console.WriteLine(count);
        } 
    }
}
