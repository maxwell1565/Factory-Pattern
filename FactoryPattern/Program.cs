namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of tires you vehilce has. Must be 4 or 18.");
            int amountOfTires;
            var input = int.TryParse(Console.ReadLine(), out amountOfTires);
            var vehicle = VehicleFactory.GetVehicle(amountOfTires);
            vehicle.Drive();
        }
    }
}
