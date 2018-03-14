using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>("Luxu");
            var car = container.Resolve<ICar>("Luxu");
            var driver = container.Resolve<Driver>();

            Console.WriteLine(car.Name);
            Console.WriteLine(driver.ShowCarName());
            Console.WriteLine(driver.ShowCar2Name());
            Console.ReadLine();
        }
    }
}
