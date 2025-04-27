using FinalExam.Entities;
using FinalExam.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                DoTask();
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
			}
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            CarInfo();
            Console.WriteLine();
            MotorcycleInfo();
        }

        // Print Motorcycle Infromation
        private static void MotorcycleInfo()
        {
            // All Fields (Common & Uncommon)
            string ModelNo = "Honda";
            int YearMake = 2020;
            int NumberOfGear = 5;
            int EngineCapacity = 150;
            VehicleType Type = VehicleType.Personal;
            int MaxPower = 100;
            int MaxTorque = 150;
            int Mileage = 200;
            string FrontBrake = "Hard Brake";
            string RearBrake = "Light Brake";

            // Object Oriented Program
            Motorcycle<Vehicle> motorcycle = new Motorcycle<Vehicle>(ModelNo, YearMake, NumberOfGear, EngineCapacity, Type, MaxPower, MaxTorque, Mileage, FrontBrake, RearBrake);

            motorcycle.GetDetails();
            Console.WriteLine();

            motorcycle.Start();
            Console.WriteLine();

            motorcycle.Cooling();
            Console.WriteLine();

            Console.WriteLine("Exterior Design");
            Console.WriteLine("---------------");

            // Array
            string[] design = motorcycle.GetExteriorDesign<Vehicle>("Bike Cover, Bike Sticker, Phone Holder, Helmet Lock, Portable Charger");

            for (int i = 0; i < design.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + design[i].Trim());
            }
        }

        // Print Motorcycle Infromation
        private static void CarInfo()
        {
            // All Fields (Common & Uncommon)
            string ModelNo = "BMW-X";
            int YearMake = 2020;
            int NumberOfGear = 5;
            int EngineCapacity = 150;
            VehicleType Type = VehicleType.Personal;
            int NumberOfSeat = 6;
            int NumberOfDoor = 4;

            // Object Oriented Program
            Car<Vehicle> car = new Car<Vehicle>(ModelNo, YearMake, NumberOfGear, EngineCapacity, Type, NumberOfSeat, NumberOfDoor);
            
            car.GetDetails();
            Console.WriteLine();

            car.GetDesign();
            Console.WriteLine();

            Console.WriteLine("Interior Design");
            Console.WriteLine("---------------");

            // Array
            string[] design = car.GetInteriorDesign<Vehicle>("Tissue Box, Neck Pillow, Perfume, USB Charger, Travel Mug");

            for (int i = 0; i < design.Length; i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + design[i].Trim());
            }
        }


    }
}
