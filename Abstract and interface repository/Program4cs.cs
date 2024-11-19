using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_and_interface_repository
{
    interface IFlyable
    {
        void FlyObj();
    }

    class Spacecraft : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Spacecraft is flying in space.");
        }
    }

    class Airplane : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Airplane is flying in the sky.");
        }
    }

    class Helicopter : IFlyable
    {
        public void FlyObj()
        {
            Console.WriteLine("Helicopter is hovering in the air.");
        }
    }

    class Program4
    {
        //static void Main()
        //{
        //    IFlyable spacecraft = new Spacecraft();
        //    spacecraft.FlyObj();

        //    IFlyable airplane = new Airplane();
        //    airplane.FlyObj();

        //    IFlyable helicopter = new Helicopter();
        //    helicopter.FlyObj();
        //}
    }
}
