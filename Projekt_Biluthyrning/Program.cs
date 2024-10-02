using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class Program {
		static void Main(string[] args) {
            Console.WriteLine("Please, write your first- and lastname.");
			string inputName = Console.ReadLine();
			while (inputName == "") {
                Console.WriteLine("Invalid input, please try again.");
				inputName = Console.ReadLine();
				Console.Clear();
			}
			

			Console.WriteLine("Write your age.");
			string input = Console.ReadLine();
			int age;
			while(!int.TryParse(input, out age)) {
				Console.WriteLine("Invalid input, please try again.");
				input = Console.ReadLine();
				Console.Clear();
			}
			


            Console.WriteLine("Write your address");
			string inputAddress = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputAddress = Console.ReadLine();
				Console.Clear();
			}
			

			Console.WriteLine("Write your mail");
			string inputMail = Console.ReadLine();
			while (inputMail == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputMail = Console.ReadLine();
				Console.Clear();
			}


			Console.WriteLine("Write your phoneNumber");
			string inputPhoneNumber = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputPhoneNumber = Console.ReadLine();
				Console.Clear();
			}

			Console.WriteLine("Choose pick up location: Stockholm, Malmö & Göteborg");
			string inputPickUpLocation = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputPickUpLocation = Console.ReadLine();
				Console.Clear();
			}

			Console.WriteLine("Write the date you would like to pick up the vehicle. DD/MM/YY");
			string inputStartDate = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputStartDate = Console.ReadLine();
				Console.Clear();
			}

			Console.WriteLine("Write the date you would like to leave the vehicle. DD/MM/YY");
			string inputEndDate = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputEndDate = Console.ReadLine();
				Console.Clear();
			}

			//Booking booking = new Booking(inputName, inputAge, inputAddress, inputMail, inputPhoneNumber, inputPickUpLocation,inputStartDate, inputEndDate);
		}
	}
}
