using System;

namespace InterfacesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            People[] peoples = { new Schoolboy(), new Worker(), new Student(), new Worker() };
            Random random = new Random();

            foreach (People people in peoples)
            {
                int toPlace = random.Next(20, 200);
                int speed = random.Next(30, 180);
                Console.WriteLine(people.Name);
                if (people is IDriver) 
                {
                    var peopleDrive = (IDriver)people;
                    Console.WriteLine("Умеет водить\n Имеет опыт: " + peopleDrive.DrivingExperience + " лет\n");
                    peopleDrive.DriverToPlace( toPlace, speed);
                }
                else
                {
                    Console.WriteLine("Не умеет водить\n");
                }

            }
        }
    }
}
