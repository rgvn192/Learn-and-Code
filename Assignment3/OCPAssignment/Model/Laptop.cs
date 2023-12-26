using OCPAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPAssignment.Model
{
    
    public class Laptop : IDevice
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Laptop : Model Y, RAM : 16 GB, Storage : 512GB");
        }
    }
}
