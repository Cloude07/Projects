using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    class Worker : People, IDriver
    {
        public override string Name { get; } = "Рабочий";
        public int DrivingExperience { get; } = 5;

        public void DriverToPlace(int toPlace, int speed)
        {
            int place = toPlace;
            place /= speed;
            Console.WriteLine("Время поестки до точки назначения = " + place + " Часов");
        }
    }
}
