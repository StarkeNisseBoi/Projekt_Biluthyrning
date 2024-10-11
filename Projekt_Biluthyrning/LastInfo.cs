using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class LastInfo {
		Booking bookingSum;
		CarInfo carSum;
		public void Summary(Booking bookingSum, CarInfo carSum) {
			Console.WriteLine("Summary of your booking:");
			Console.WriteLine("Name: " + bookingSum._bookingName);
			Console.WriteLine("Age: " + bookingSum._age);
			Console.WriteLine("Adress: " + bookingSum._address);
			Console.WriteLine("Mail: " + bookingSum._mail);
			Console.WriteLine("Phonenumber: " + bookingSum._phoneNumber);
			Console.WriteLine("Pick up location: " + bookingSum._pickUpLocation);
            Console.WriteLine("Pick up date: " + bookingSum._startDate);
			Console.WriteLine("End date: " + bookingSum._endDate);

			Console.WriteLine("Your booked car: " + carSum._carModel);
			Console.WriteLine("Car type: " + carSum.VehicleType);
			Console.WriteLine("Fuel: " + carSum.FuelInfo);
			Console.WriteLine("Transmission: " + carSum._gearBox);
			Console.WriteLine("Tow hitch: " + carSum._towHitch);
			Console.WriteLine("Tow capacity: " + carSum._towCapacity + " kg");
			Console.WriteLine("Total horsepower: " + carSum._horsepower);
			Console.WriteLine("Number of doors: " + carSum._doors);
		}
	}
}
