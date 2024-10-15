using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class UserInterface {
		protected string _chosenVehicle;
		protected string _chosenTrailerType;
		protected string _chosenTrailerTypeInfo;
		protected string _chosenFuelType;
		protected string _chosenGearbox;
		protected string _chosenTowHitch;
		protected Trailer _trailer;

		public void StarPage() {
            Console.WriteLine("  ----------------------------" );
            Console.WriteLine("   Welcome! Bestrent.com");
            Console.WriteLine("  ----------------------------");
            Console.WriteLine("  [PRESS ANY KEY TO CONTINUE]");
			Console.ReadKey();
			Console.Clear();

			Booking bookingLastInfo = BookingDetail();

			MainPage();
			
			CarInfo vehicleSpecification = CheckOut();
			LastInfo lastInfo = new LastInfo();
			lastInfo.Summary(bookingLastInfo, vehicleSpecification, );

		}

	
		/// <summary>
		/// En metod som tar input om namn etc till bokning
		/// </summary>
		/// <returns></returns>
		public Booking BookingDetail() {
			Console.WriteLine("Please, write your first- and lastname.");
			string inputName = Console.ReadLine();
			while (inputName == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputName = Console.ReadLine();
			}
			Console.Clear();

			Console.WriteLine("Write your age.");
			string input = Console.ReadLine();
			int age;
			while (!int.TryParse(input, out age)) {
				Console.WriteLine("Invalid input, please try again.");
				input = Console.ReadLine();
			}
			Console.Clear();

			if (age < 18) {
				Console.WriteLine("Too young.");
				Environment.Exit(1);
			}

			Console.WriteLine("Write your address");
			string inputAddress = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputAddress = Console.ReadLine();
			}
			Console.Clear();


			Console.WriteLine("Write your mail");
			string inputMail = Console.ReadLine();
			while (inputMail == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputMail = Console.ReadLine();
			}
			Console.Clear();


			Console.WriteLine("Write your phoneNumber");
			string inputPhoneNumber = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputPhoneNumber = Console.ReadLine();
			}
			Console.Clear();

			Console.WriteLine("Choose pick up location: Stockholm, Malmö & Göteborg");
			string inputPickUpLocation = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputPickUpLocation = Console.ReadLine();
			}
			Console.Clear();


			Console.WriteLine("Write the date you would like to pick up the vehicle. DD/MM");
			string inputStartDate = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputStartDate = Console.ReadLine();
			}
			Console.Clear();

			Console.WriteLine("Write the date you would like to leave the vehicle. DD/MM");
			string inputEndDate = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Invalid input, please try again.");
				inputEndDate = Console.ReadLine();
			}
			Console.Clear();

			
			Booking booking = new Booking(inputName, age, inputAddress, inputMail, inputPhoneNumber, inputPickUpLocation,inputStartDate, inputEndDate);
			return booking;
		}


		public void MainPage() {
            Console.WriteLine("  Please, choose vehicle selection");
            Console.WriteLine("  ------------------------------------");
			Console.WriteLine("   1. Suv" );
            Console.WriteLine("   2. Sedan");
            Console.WriteLine("   3. Kombi");
			Console.WriteLine("   4. Sport");
			Console.WriteLine("   5. Trailer");
            Console.WriteLine("  ------------------------------------");
            Console.WriteLine("   6. Exit");

			_chosenVehicle = Console.ReadLine();

			if (_chosenVehicle == "1") {
				_chosenVehicle = "Suv";
				Console.Clear();
				FuelType();
			} else if (_chosenVehicle == "2") {
				_chosenVehicle = "Sedan";
				Console.Clear();
				FuelType();
			} else if (_chosenVehicle == "3") {
				_chosenVehicle = "Kombi";
				Console.Clear();
				FuelType();
			} else if (_chosenVehicle == "4"){
				_chosenVehicle = "Sport";
				Console.Clear();
				FuelType();
			} else if (_chosenVehicle == "5") {
				_chosenVehicle = "Trailer";
				Console.Clear();
				TrailerType();
			} else if (_chosenVehicle == "6") {
				Environment.Exit(1);
			}


			CarInfo.MethodOfElimination()

		}

		public void TrailerType() {
			Console.WriteLine("  ------------------------------------");
			Console.WriteLine("  1. Enclosed trailer");
			Console.WriteLine("  2. Grating trailer");
			Console.WriteLine("  ------------------------------------");

			_chosenTrailerType = Console.ReadLine();

			if (_chosenTrailerType == "1") {
				_chosenTrailerType = "Enclosed trailer";
				Console.Clear();
				TrailerTypeinfo();
			} else if (_chosenTrailerType == "2") {
				_chosenTrailerType = "Grating trailer";
				Console.Clear();
				TrailerTypeinfo();
			}
			_trailer
		}

		public void TrailerTypeinfo() {
			Console.WriteLine("  ------------------------------------");
			Console.WriteLine("  1. Continue to choose car");
			Console.WriteLine("  2. Confirm booking ");
			Console.WriteLine("  ------------------------------------");

			_chosenTrailerTypeInfo = Console.ReadLine();

			if (_chosenTrailerTypeInfo == "1") {
				Console.Clear();

			} else if (_chosenTrailerTypeInfo == "2") {
				Console.Clear();
			}
		}

		public void FuelType() {
			Console.WriteLine("  Which fueltype would you prefer?");
			Console.WriteLine("  ------------------------------------");
            Console.WriteLine("  1. Petrol");
			Console.WriteLine("  2. Diesel");
            Console.WriteLine("  3. Electric");
			Console.WriteLine("  ------------------------------------");

			_chosenFuelType = Console.ReadLine();

			if (_chosenFuelType == "1") {
				_chosenFuelType = "Petrol";
				Console.Clear();
				Gearbox();
			}else if (_chosenFuelType == "2") {
				_chosenFuelType = "Diesel";
				Console.Clear();
				Gearbox();
			} else if (_chosenFuelType == "3") {
				_chosenFuelType = "Electric";
				_chosenGearbox = "Automatic";
				Console.Clear();
				TowHitch();
			}
		}

		public void Gearbox() {
			Console.WriteLine("  Which gearbox would you prefer?");
			Console.WriteLine("  ------------------------------------");
			Console.WriteLine("  1. Manual");
			Console.WriteLine("  2. Automatic");
			Console.WriteLine("  ------------------------------------");

			_chosenGearbox = Console.ReadLine();

			if (_chosenGearbox == "1") {
				_chosenGearbox = "Manual";
				Console.Clear();
				TowHitch();
			} else if (_chosenGearbox == "2") {
				_chosenGearbox = "Automatic";
				Console.Clear();
				TowHitch();
			}
		}

		public void TowHitch() {
            Console.WriteLine("  Do you need towhitch?");
			Console.WriteLine("  ------------------------------------");
			Console.WriteLine("  1. Yes");
			Console.WriteLine("  2. No");
			Console.WriteLine("  ------------------------------------");

			_chosenTowHitch = Console.ReadLine().ToLower();

			if (_chosenTowHitch == "1") {
				_chosenTowHitch = "yes";
				
			}else if (_chosenTowHitch == "2") {
				_chosenTowHitch = "no";
				
			}

		}
		public CarInfo CheckOut() {

			Console.WriteLine("Here is the cars best suited for you.");
			List<CarInfo> PossibleCars = CarInfo.MethodOfElimination(_chosenVehicle, _chosenGearbox, _chosenFuelType, _chosenTrailerType);
			for (int i = 0; i < PossibleCars.Count; i++) {
				Console.WriteLine("1. " + PossibleCars[i]._carModel);
			}


			Console.WriteLine("Press '1' to check out.");
			string inputChosenCar = Console.ReadLine();
			int inputChosenCarAsInt = int.Parse(inputChosenCar);
			while (inputChosenCar == "") {
				Console.WriteLine("Invalid input.");
				inputChosenCar = Console.ReadLine();
			}

			CarInfo theChosenCar = PossibleCars[inputChosenCarAsInt - 1];

			return theChosenCar;
		}
	}
}
