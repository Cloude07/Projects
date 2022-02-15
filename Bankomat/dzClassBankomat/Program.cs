using System;

namespace dzClassBankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            bool liveprogram = true;
            Bankomat bankomat1 = new Bankomat("Муся", "Пуся", "Куся", 50000);
            while (liveprogram)
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать!!!\nВыберите функцию: \n 1-Вывести информацию;\n 2-Снятие наличности;\n 3-Зачисление денег;\n 4-Перевод валюты;\n 5-Выход;");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        bankomat1.Information();
                        break;
                    case 2:
                        Console.WriteLine("Введите сколько хотите снять денег:");
                        int enterGiveMoney = Convert.ToInt32(Console.ReadLine());
                        bankomat1.GiveMoney(enterGiveMoney);
                        break;
                    case 3:
                        Console.WriteLine("Введите сколько хотите положить денег:");
                        int enterSetMoney = Convert.ToInt32(Console.ReadLine());
                        bankomat1.SetMoney(enterSetMoney);
                        break;
                    case 4:
                        bankomat1.Translate();
                        break;
                    case 5:
                        liveprogram = false;
                        break;

                }

            }
        }
    }
}
