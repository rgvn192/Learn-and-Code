using OCPAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPAssignment.Model
{
    public class Smartphone : IDevice
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Smartphone : Model X, RAM : 8 GB, Storage : 128GB");
        }
    }
}
