using System;
namespace FactoryPattern
{
	public class BigRig : IVehicle
	{
		public BigRig()
		{
		}

        void IVehicle.Drive()
        {
            Console.WriteLine("Creating a Bigrig");
        }
    }
}

