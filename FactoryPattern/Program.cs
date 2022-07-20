using FactoryPattern;

bool x = true;
do
{


    Console.WriteLine("How many wheels is on the vehicle you want to create?");
    var input = int.Parse(Console.ReadLine());
    if (input > 0 && input < 5)
    {
        x = false;
    }
    var vehicle = VehicleFactory.GetVehicle(input);
    Console.WriteLine("------------------------------");
    vehicle.Drive();
} while (x == true) ;