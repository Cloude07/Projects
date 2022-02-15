using System;

namespace ConvertValueMane
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Задача:
                 Написать конвертер валют(3 валюты).

     У пользователя есть баланс в каждой из представленных валют.
     Он может попросить сконвертировать часть баланса в одной валюты в другую.
     Тогда у него с баланса одной валюты снимет X и зачислится на баланс другой Y.
     Курс конвертации должен быть просто прописан в программе.

     Программа должна завершиться тогда, когда это решит пользователь.
     */
            double myeur = 4, myusd = 5.4, myjpy = 100, myRUB = 25000;
            string inputUser1, inputUser2="", inputUserValue1, inputUserValue2, name1, name2;
            Console.WriteLine("Добро пожаловать в банк, хотите узнать ваш баланс? или конвертировать валюту? ");
            replay:
            Console.Write("Если хотите узнать баланс напишите валюту, если перевод то слово - Перевод ");
            inputUser1 = Console.ReadLine();
           

            switch (inputUser1)
            {
                case "Евро":
                    Console.WriteLine("Ваш баланc в евро: " + myeur + " Хотите добавить ?");
                    inputUser2 = Console.ReadLine();
                    break;
                case "Долар":
                    Console.WriteLine("Ваш баланc в доларов: " + myusd + " Хотите добавить ?");
                    inputUser2 = Console.ReadLine();
                    break;
                case "Йен":
                    Console.WriteLine("Ваш баланc в Йенах: " + myjpy + " Хотите добавить ?");
                    inputUser2 = Console.ReadLine();
                    break;
                case "Рубли":
                    Console.WriteLine("Ваш баланc в Рублях: " + myRUB + " Хотите добавить ?");
                    inputUser2 = Console.ReadLine();
                    break;
                case "Перевод":
                    replace1:
                    Console.WriteLine("Выберите сначала от какой валюты перевод");
                    inputUserValue1 = Console.ReadLine();
                    name1 = inputUserValue1;
                    switch (inputUserValue1)
                    {
                        case "Евро":
                            Console.WriteLine($"Вы выбрали евро ваш баланс: {myeur}");
                            break;
                        case "Долар":
                            Console.WriteLine($"Вы выбрали Долар ваш баланс: {myusd}");
                            break;
                        case "Йен":
                            Console.WriteLine($"Вы выбрали Йен ваш баланс: {myjpy}");
                            break;
                        case "Рубли":
                            Console.WriteLine($"Вы выбрали Рубли ваш баланс: {myRUB}");
                            break;
                        default:
                            Console.WriteLine("Нет такой валюты");
                            goto replace1;
                            
                    }
                    replace2:
                    Console.WriteLine("Теперь в какую");
                    inputUserValue2 = Console.ReadLine();
                    name2 = inputUserValue2;
                    switch (inputUserValue2)
                    {
                        case "Евро":
                            switch (inputUserValue1)
                            {
                                case "Рубли":
                                    if (myRUB >= 86.46)
                                    {
                                        myeur = myRUB / 86.46;
                                        myRUB = myRUB % 86.46;
                                        inputUserValue1 = Convert.ToString(myRUB);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                case "Долар":
                                    if (myusd >= 1.18)
                                    {
                                        myeur = myusd / 1.18;
                                        myusd = myusd % 1.18;
                                        inputUserValue1 = Convert.ToString(myusd);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                case "Йен":
                                    if (myjpy >= 129.87)
                                    {
                                        myeur = myjpy / 129.87;
                                        myjpy = myjpy % 129.87;
                                        inputUserValue1 = Convert.ToString(myjpy);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                default:
                                    Console.WriteLine("Мы не можем перевести");
                                    goto replace2;
                            }
                            inputUserValue2 = Convert.ToString(myeur);
                            break;
                        case "Долар":
                            switch (inputUserValue1)
                            {
                                case "Рубли":
                                    if (myRUB >= 73.13)
                                    {
                                        myusd = myRUB / 73.13;
                                        myRUB = myRUB % 73.13;
                                        inputUserValue1 = Convert.ToString(myRUB);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                case "Евро":
                                    if (myeur >= 0.85)
                                    {
                                        myusd = myeur / 0.85;
                                        myeur = myeur % 0.85;
                                        inputUserValue1 = Convert.ToString(myeur);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                case "Йен":
                                    if (myjpy >= 110.25)
                                    {
                                        myusd = myjpy / 110.25;
                                        myjpy = myjpy % 110.25;
                                        inputUserValue1 = Convert.ToString(myjpy);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                default:
                                    Console.WriteLine("Мы не можем перевести");
                                    goto replace2;
                            }
                            inputUserValue2 = Convert.ToString(myusd);
                            break;
                        case "Йен":         
                            switch (inputUserValue1)
                            {
                                case "Рубли":
                                    if (myRUB >= 0.67)
                                    {
                                        myjpy = myRUB / 0.67;
                                        myRUB = myRUB % 0.67;
                                        inputUserValue1 = Convert.ToString(myRUB);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                case "Евро":
                                    if (myeur >= 0.0077)
                                    {
                                        myjpy = myeur / 0.0077;
                                        myeur = myeur % 0.0077;
                                        inputUserValue1 = Convert.ToString(myeur);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                case "Долар":
                                    if (myusd >= 0.0091)
                                    {
                                        myjpy = myusd / 0.0091;
                                        myusd = myusd % 0.0091;
                                        inputUserValue1 = Convert.ToString(myusd);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                default:
                                    Console.WriteLine("Мы не можем перевести");
                                    goto replace2;
                            }
                            inputUserValue2 = Convert.ToString(myjpy);
                            break;
                        case "Рубли":     
                            switch (inputUserValue1)
                            {
                                case "Долар":
                                    if (myusd >= 0.014)
                                    {
                                        myRUB = myusd / 0.014;
                                        myusd = myusd % 0.014;
                                        inputUserValue1 = Convert.ToString(myusd);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                case "Евро":
                                    if (myeur >= 0.012)
                                    {
                                        myRUB = myeur / 0.012;
                                        myeur = myeur % 0.012;
                                        inputUserValue1 = Convert.ToString(myeur);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                case "Йен":
                                    if (myjpy >= 1.5)
                                    {
                                        myRUB = myjpy / 1.5;
                                        myjpy = myjpy % 1.5;
                                        inputUserValue1 = Convert.ToString(myjpy);
                                    }
                                    else
                                        Console.WriteLine("Не хватает денег");
                                    break;
                                default:
                                    Console.WriteLine("Мы не можем перевести");
                                    goto replace2;
                            }
                            inputUserValue2 = Convert.ToString(myRUB);
                            break;
                        default:
                            Console.WriteLine("Нет такой валюты");
                            goto replace2;

                    }
                    Console.WriteLine($"итоги перевода с {inputUserValue1} {name1} в {inputUserValue2} {name2}");
                    goto replay;
                case "Пока":
                    goto exitbank;                    
                default:
                    goto replay;


            }
            if (inputUser2 == "Да" || inputUser2 == "да")    
            {
                switch (inputUser1)
                {
                    case "Евро":
                        Console.WriteLine("Сколько хотите добавить?: ");
                        myeur += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Теперь ваш баланс: {myeur}");
                        break;
                    case "Долар":
                        Console.WriteLine("Сколько хотите добавить?: ");
                        myusd += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Теперь ваш баланс: {myusd}");
                        break;
                    case "Йен":
                        Console.WriteLine("Сколько хотите добавить?: ");
                        myjpy += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Теперь ваш баланс: {myjpy}");
                        break;
                    case "Рубли":
                        Console.WriteLine("Сколько хотите добавить?: ");
                        myRUB += Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Теперь ваш баланс: {myRUB}");
                        break;
                }
            }
            goto replay;
        exitbank:
            Console.WriteLine("Приходите еще");
        }
    }
}
