using FinalExam.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Entities
{
    // Base (Parent) & Abstract Class

    public abstract class Vehicle
    {
        // Common Fields
        string modelNo;
        int yearMake;
        int numberOfGear;
        int engineCapacity;
        VehicleType type;

        // Generate Constructor
        protected Vehicle(string modelNo, int yearMake, int numberOfGear, int engineCapacity, VehicleType type)
        {
            ModelNo = modelNo;
            YearMake = yearMake;
            NumberOfGear = numberOfGear;
            EngineCapacity = engineCapacity;
            Type = type;
        }

        // Encapsulate Fields
        public abstract string ModelNo { get; set; }
        public abstract int YearMake { get; set; }
        public abstract int NumberOfGear { get; set; }
        public abstract int EngineCapacity { get; set; }
        public abstract VehicleType Type { get; set; }

        // Abstract Method
        public abstract void GetDetails();
    }
}
