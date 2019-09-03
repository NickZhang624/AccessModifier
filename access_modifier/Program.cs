using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using access_modifier_lib;

namespace access_modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Accelerate();
            //Console.WriteLine(car.Speed);

            //开始使用protected 之后的code
            Car car = new Car();
            car.TurboAccelerate();
            Console.WriteLine(car.Speed);


            Bus bus = new Bus();
            bus.SlowAccelerate();
            Console.WriteLine(car.Speed);
        }

    }

    class Bus: Vehicle
    {
        public void SlowAccelerate()
        {
            Burn();
            _rpm += 500;
        }
    }
}
