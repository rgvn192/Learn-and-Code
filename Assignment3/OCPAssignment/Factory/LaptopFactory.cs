using OCPAssignment.Interfaces;
using OCPAssignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPAssignment.Factory
{
    public class LaptopFactory : IDeviceFactory
    {
        public IDevice CreateDevice()
        {
            return new Laptop();
        }
    }
}
