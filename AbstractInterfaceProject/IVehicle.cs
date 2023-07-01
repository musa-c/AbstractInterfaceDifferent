using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceProject
{
    internal interface IVehicle
    {
        void Go();
        void Stop();
    }

    internal abstract class BaseVehicle : IVehicle
    {
        public void Go()
        {
            Console.WriteLine("Vehicle is going...");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle has stopped...");
        }
    }

    internal interface IRideable
    {
        void Ride();
    }

    internal interface IFlyable
    {
        void Soar();
    }

    internal class Car : BaseVehicle
    {


    }
    internal class Plane : BaseVehicle, IFlyable
    {
        public void Soar()
        {
            throw new NotImplementedException();
        }
    }
    internal class Bike : BaseVehicle, IRideable
    {
        public void Ride()
        {
            throw new NotImplementedException();
        }
    }
     
    internal class Boat : BaseVehicle, IFlyable
    {
        public void Soar()
        {
            throw new NotImplementedException();
        }
    }
         
    

}
