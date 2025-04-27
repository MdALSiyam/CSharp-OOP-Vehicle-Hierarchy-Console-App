using FinalExam.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Entities
{
    // Generic Sealed Class Inherit Generic Four Wheeler Class
    public sealed class Car<T> : FourWheeler<T>
    {
        // Uncommon Fields
        int numberOfSeat;
        int numberOfDoor;

        // Generate Constructor
        public Car(string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type, int numberOfSeat, int numberOfDoor) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
        {
            this.numberOfSeat = numberOfSeat;
            this.numberOfDoor = numberOfDoor;
        }

        // Encapsulate Fields
        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public int NumberOfDoor { get => numberOfDoor; set => numberOfDoor = value; }

        // Override Virtual Method
        public override void GetDesign()
        {
            Console.WriteLine("This is a very good designed car");
        }

        // Override Abstract Method
        public override void GetDetails()
        {
            Console.WriteLine("Car Information");
            Console.WriteLine("~~~~~~~~~~~~~~~");
            Console.WriteLine($"\t\t 1. Model No: {ModelNo}");
            Console.WriteLine($"\t\t 2. Year Make: {YearMake}");
            Console.WriteLine($"\t\t 3. Number of Seat: {numberOfSeat}");
            Console.WriteLine($"\t\t 4. Number of Gear: {NumberOfGear}");
            Console.WriteLine($"\t\t 5. Number of Door: {NumberOfDoor}");
            Console.WriteLine($"\t\t 6. Engine Capacity in CC: {EngineCapacity}");
            Console.WriteLine($"\t\t 7. Vehicle Type: {Type}");
        }
    }
}
