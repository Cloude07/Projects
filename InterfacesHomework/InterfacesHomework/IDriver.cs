using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesHomework
{
    public interface IDriver
    {
        int DrivingExperience { get;}
        void DriverToPlace(int toPlace, int speed);
    }
}
