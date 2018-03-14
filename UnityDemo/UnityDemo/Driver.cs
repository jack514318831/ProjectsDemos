using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace UnityDemo
{
    public class Driver
    {
        [Dependency]
        public ICar car { get; set; }

        
        public ICar car2 { get; set; }
       // public string Name { get; set; }

        public Driver()
        {
            car2 = new Audi();
        }

        public Driver(ICar c)
        {
            car2 = c;
        }

        //public Driver(string str)
        //{
        //    Name = str;
        //}

        public string ShowCarName()
        {
            return car.Name;
        }

        public string ShowCar2Name()
        {
            return car2.Name;
        }
    }
}
