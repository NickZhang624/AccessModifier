using System;


/* 1.所有的class都是从object继承过来的
 * 比如： class Vehicle: Object(这是最顶端的)
 * 
 * 2.
 * car的实例也是vehicle 的实例，所以vechle 的变量可以引用一个car 的实例
 * 
 * 3.
 * 子类对父类的继承可以说是横向继承和纵向继承，横向表示类下的方式属性增加，纵向可以说的不断的重写父类
 */
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Type t = typeof(Car);
            //Type tb = t.BaseType;
            //Type tb1 = tb.BaseType;
            //Console.WriteLine(tb1);

            //2.
            //Vehicle vehicle = new Car();
            //Object ob = new Vehicle();
            //Object ob1 = new Car();

            //3.
            //Racecar racecar = new Racecar();
            //racecar.Owner;
            ////gettype 实际上是object 的method，F12 shortcut
            //racecar.GetType


            ////4.在this.owner打断点，可以看到先触发父类，然后触发基类
            //Car car = new Car();
            //Console.WriteLine(car.Owner);

            //5.如果是增加一个string 在constractor 里面，那么基类的constractor空着或者是也是增加一个string
            // 说明子类的constractor是不能继承父类的constractor！！！！





        }
        /* 2.如果在class Vehicle前面加上 sealed那么这就是一个封闭的class，不能作为父类
         * 一个基类只支持一个父类，但是可以实现多个基接口（interface）
         * 错误表达：
         * class car: vehicle, transport{}
         * 
         * 错误表达：
         *  internal class Vehicle
         *  public class Car : Vehicle（子类的访问级别不能超越父类的访问级别，但是可以相互交换过来， ）
         * 
         * 
         */
        class Vehicle
        {
            public String Owner { get; set; }

            public Vehicle()
            {
                this.Owner = "None";
            }

        }

        class Car : Vehicle
        {
            public Car()
            {
                this.Owner = "car owner";
            }
        }

        class Racecar: Car
        {

        }
    }
}
