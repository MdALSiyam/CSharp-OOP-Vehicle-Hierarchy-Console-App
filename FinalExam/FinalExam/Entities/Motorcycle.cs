using FinalExam.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Entities
{
    // Generic Sealed Class Inherit Generic Two Wheeler Class
    public sealed class Motorcycle<T> : TwoWheeler<T> where T : Vehicle
    {
        // Uncommon Fields
        int maxPower;
        int maxTorque;
        int mileage;
        string frontBrake;
        string rearBrake;

        // Generate Constructor
        public Motorcycle(string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type, int maxPower, int maxTorque, int mileage, string frontBrake, string rearBrake) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
        {
            this.maxPower = maxPower;
            this.maxTorque = maxTorque;
            this.mileage = mileage;
            this.frontBrake = frontBrake;
            this.rearBrake = rearBrake;
        }

        // Encapsulate Fields
        public int MaxPower { get => maxPower; set => maxPower = value; }
        public int MaxTorque { get => maxTorque; set => maxTorque = value; }
        public int Mileage { get => mileage; set => mileage = value; }
        public string FrontBrake { get => frontBrake; set => frontBrake = value; }
        public string RearBrake { get => rearBrake; set => rearBrake = value; }

        // Override Virtual Method
        public override void Start()
        {
            base.Start();
        }

        // Override Virtual Method
        public override void Cooling(string cool = "Automatic System Available")
        {
            base.Cooling(cool);
        }

        // Override Abstract Method
        public override void GetDetails()
        { 
            Console.WriteLine("============================================================");
            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine("Motorcycle Information");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"\t\t\t 1. Model No: {ModelNo}");
            Console.WriteLine($"\t\t\t 2. Year Make: {YearMake}");
            Console.WriteLine($"\t\t\t 3. Number of Gear: {NumberOfGear}");
            Console.WriteLine($"\t\t\t 4. Engine Capacity in CC: {EngineCapacity}");
            Console.WriteLine($"\t\t\t 5. Max Power in KMPL: {maxPower}");
            Console.WriteLine($"\t\t\t 6. Max Torque in NM: {maxTorque}");
            Console.WriteLine($"\t\t\t 7. Mileage: {mileage}");
            Console.WriteLine($"\t\t\t 8. Front Brake: {frontBrake}");
            Console.WriteLine($"\t\t\t 9. Rear Brake: {rearBrake}");
            Console.WriteLine($"\t\t\t 10. Vehicle Type: {Type}");
        }
    }
}
