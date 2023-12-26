using OCPAssignment.Factory;
using OCPAssignment.Interfaces;
using OCPAssignment.Model;


IDeviceFactory smartphoneFactory = new SmartphoneFactory();
IDevice smartphone = smartphoneFactory.CreateDevice();

IDeviceFactory laptopFactory = new LaptopFactory();
IDevice laptop = laptopFactory.CreateDevice();

smartphone.DisplayDetails();
laptop.DisplayDetails();