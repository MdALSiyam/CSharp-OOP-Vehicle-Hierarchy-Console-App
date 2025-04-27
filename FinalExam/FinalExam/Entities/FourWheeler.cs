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
    public class FourWheeler<T> : Vehicle, IInteriorDesign<T>
    {
        // Generate Constructor
        public FourWheeler(string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type) : base(modelNo, yearMake, numberOfGear, engineCapacity, type)
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
            Console.WriteLine("Abstract Method Overriden in Four Wheeler");
        }

        // Virtual Method
        public virtual void GetDesign()
        {
            Console.WriteLine();
        }

        // Implement Generic Interface
        public string[] GetInteriorDesign<T>(string data)
        {
            string[] design = data.Split(',');
            return design;
        }
    }
}
