using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    class Student : People, IDriver
    {
        public override string Name { get; } = "Студент";
        public int DrivingExperience { get; } = 2;

        public void DriverToPlace(int toPlace, int speed)
        {
            int place = toPlace;
            place = speed * place;
            place = place / 60;

            Console.WriteLine("Время поестки до точки назначения = " + place + " Часов");
        }
    }
}
