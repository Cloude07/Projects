using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHomework
{
    class Worker
    {
       public void Feed(Lion lion)
        {
            Console.WriteLine("Сотрудник покормил льва по кличке " + lion.Name);
        }
    }
}
