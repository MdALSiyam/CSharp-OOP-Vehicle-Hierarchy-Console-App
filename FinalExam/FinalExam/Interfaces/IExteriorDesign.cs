using FinalExam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Interfaces
{
    // Generic Interface
    public interface IExteriorDesign<T> where T : Vehicle
    {
        string[] GetExteriorDesign<T>(string data) where T : Vehicle;
    }
}
