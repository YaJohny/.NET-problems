using OOP.Entities;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Bus
            Bus bus = new Bus();
            bus.Model = "Bussiness Vehicle";
            bus.Year = DateTime.Now.Year;
            bus.PassengersCapacity = 40;
            bus.NumberOfSeats = 20;

            bus.Engine = new Engine();
            bus.Engine.SerialNumber = Guid.NewGuid().ToString();
            bus.Engine.Power = 4000;
            bus.Engine.Volume = 100;
            bus.Engine.Type = "Deisel";

            bus.Chassis = new Chassis();
            bus.Chassis.WheelsNumber = 8;
            bus.Chassis.Number = Guid.NewGuid().ToString();
            bus.Chassis.PermissibleLoad = 10000;

            bus.Transmission = new Transmission();
            bus.Transmission.Type = "Mechanic";
            bus.Transmission.Manufacturer = "Yutong";
            bus.Transmission.NumberOfGears = 50;
            bus.print();

            //  Passanger car
            PassangerCar passangerCar = new PassangerCar();
            passangerCar.Model = "Toyota Corolla";
            passangerCar.Year = DateTime.Now.Year;
            passangerCar.PassengersCapacity = 4;
            
            passangerCar.Engine = new Engine();
            passangerCar.Engine.SerialNumber = Guid.NewGuid().ToString();
            passangerCar.Engine.Power = 2000;
            passangerCar.Engine.Volume = 50;
            passangerCar.Engine.Type = "Hybrid";

            passangerCar.Chassis = new Chassis();
            passangerCar.Chassis.WheelsNumber = 4;
            passangerCar.Chassis.Number = Guid.NewGuid().ToString();
            passangerCar.Chassis.PermissibleLoad = 3500;

            passangerCar.Transmission = new Transmission();
            passangerCar.Transmission.Type = "Automatic";
            passangerCar.Transmission.Manufacturer = "Toyota";
            passangerCar.Transmission.NumberOfGears = 25;
            passangerCar.print();

            //  Scooter
            Scooter scooter = new Scooter();
            scooter.Model = "Yahama motor";
            scooter.Year = DateTime.Now.Year;
            scooter.MaxSpeed = 120;
            scooter.Weight = 280;
            
            scooter.Engine = new Engine();
            scooter.Engine.SerialNumber = Guid.NewGuid().ToString();
            scooter.Engine.Power = 1000;
            scooter.Engine.Volume = 20;
            scooter.Engine.Type = "Induction";

            scooter.Chassis = new Chassis();
            scooter.Chassis.WheelsNumber = 2;
            scooter.Chassis.Number = Guid.NewGuid().ToString();
            scooter.Chassis.PermissibleLoad = 1000;
            scooter.print();

            //  Truck
            Truck truck = new Truck();
            truck.Model = "The MAN TGX";
            truck.Year = DateTime.Now.Year;
            truck.Type = "Box";
            truck.TankCapacity = 100;

            truck.Engine = new Engine();
            truck.Engine.SerialNumber = Guid.NewGuid().ToString();
            truck.Engine.Power = 10000;
            truck.Engine.Volume = 1000;
            truck.Engine.Type = "Diesel";

            truck.Chassis = new Chassis();
            truck.Chassis.WheelsNumber = 16;
            truck.Chassis.Number = Guid.NewGuid().ToString();
            truck.Chassis.PermissibleLoad = 20000;

            truck.Transmission = new Transmission();
            truck.Transmission.Type = "SelectShift";
            truck.Transmission.NumberOfGears = 100;
            truck.Transmission.Manufacturer = "MAN";
            truck.print();
        }
    }
}