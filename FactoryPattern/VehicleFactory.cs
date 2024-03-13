using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{


		public static IVehicle GetVehicle(int amountOfTires)
		{
			switch (amountOfTires)
			{
				case 4:
					return new Car();
				case 18:
					return new BigRig();
				default:
					return new Car();
			}
		}
	}
}

