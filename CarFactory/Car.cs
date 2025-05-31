using System;
namespace CarFactory
{
	public class Car
	{

        public DateTime ProductionDate { get; set; }

        public string SerialNumber { get; set; }
		public string Brand { get; set; }
		public string Model { get; set; }
		public string Color { get; set; }
		public int DoorNumber { get; set; }


		public Car(string serialNumber, string brand, string model, string color, int doorNumber)
		{
			SerialNumber = serialNumber;
			Brand = brand;
			Model = model;
			Color = color;
			DoorNumber = doorNumber;

			ProductionDate = DateTime.Now;
		}
	}
}

