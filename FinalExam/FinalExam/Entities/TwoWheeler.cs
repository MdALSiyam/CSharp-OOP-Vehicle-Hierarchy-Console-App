using FinalExam.Enums;
using FinalExam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Entities
{
    // Generic Child Class Inherit Base (Parent) & Inherit Generic Interface
    public class TwoWheeler<T> : Vehicle, IExteriorDesign<T> where T : Vehicle
    {
        // Generate Constructor
        public TwoWheeler(string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
        {
        }

        // Implement Abstract Class
        public override string ModelNo { get; set; }
        public override int YearMake { get; set; }
        public override int NumberOfGear { get; set; }
        public override int EngineCapacity { get; set; }
        public override VehicleType Type { get; set; }

        // Override Abstract Method
        public override void GetDetails()
        {
            Console.WriteLine("Abstract Method Overriden in Two Wheeler");
        }

        // Virtual Method
        public virtual void Start()
        {
            Console.WriteLine("Starting: Brhum.....");
        }

        // Virtual Method
        public virtual void Cooling(string cool="Automatic System Available")
        {
            Console.WriteLine($"Cooling: {cool}");
        }

        // Implement Generic Interface
        public string[] GetExteriorDesign<T>(string data) where T : Vehicle
        {
            string[] design = data.Split(',');
            return design;
        }
    }
}
