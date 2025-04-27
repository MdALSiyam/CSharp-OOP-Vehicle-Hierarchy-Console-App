using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam.Interfaces
{
    // Generic Interface
    public interface IInteriorDesign<T>
    {
        string[] GetInteriorDesign<T>(string data);
    }
}
