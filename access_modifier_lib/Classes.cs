using System;

/*1.类成员的访问级别是以类的访问级别为上限的
 * 那就是如果一个class是internal， 他的类成员是public，那在其他assembly里面也是访问不到的
 * 那就是如果一个class是public，   他的类成员是internal，那在其他的assmbly里面也是访问不到的，在其他assembly 的子类下页访问不了，但是可以在同一个namespace下的子类访问该internal成员
 *                                他的类成员是private（也是默认的）， 那只能在该class 里面访问，同一个namespace下的基类也无法访问
 *                                他的类成员是protected, 可以在基类下访问，也可以在其他assembly下的子类访问，但是不能在其他assembly的其他类下进行访问
 
     */
namespace access_modifier_lib
{
    public class Vehicle
    {
        protected int _rpm;//转速

        private int _fuel;

        public void Refuel()
        {
            this._fuel = 100;
        }

        protected void Burn()//作为一个司机不应该是能看得到油耗的多少，是属于发动机自己的处理，所以改成protected
        {
            _fuel--;
        }
        public void Accelerate()//加速
        {
            Burn();
            _rpm += 1000;
        }

        public int Speed { get { return _rpm / 100; } }//速度
    }

    public class Car: Vehicle
    {
        public void TurboAccelerate()
        {
            Burn();
            Burn();
            _rpm += 3000;//这里原来的——rpm是private， 因为这里需要call，所以改成protected。
        }
    }
}
