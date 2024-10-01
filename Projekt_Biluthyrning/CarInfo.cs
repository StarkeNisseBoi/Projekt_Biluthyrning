using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class CarInfo : VehicleInfo {
		protected int _horsepower;
		protected int _towCapacity;
		protected int _doors;
		protected string _towHitch;

		public CarInfo(int inputHorsepower, int inputTowCapacity, int inputDoors, string inputTowHitch, string inputGearBox, string inputFuelInfo, string inputCarType) : base(inputGearBox, inputFuelInfo, inputCarType) {
			_horsepower = inputHorsepower;
			_towCapacity = inputTowCapacity;
			_doors = inputDoors;
			_towHitch = inputTowHitch;
		}

		List<CarInfo> ListOfAvaiableCars = new List<CarInfo>() {
			new CarInfo(250, 1000,4,"yes","Automatic", "Diesel", "Sedan"),
			new CarInfo(120, 0,4,"no","Manual", "Petrol", "Sedan"),
			new CarInfo(400, 750,4,"yes","Automatic", "Electric", "Sedan"),

			new CarInfo(300, 850,4,"yes","Manual", "Diesel", "Suv"),
			new CarInfo(275, 1250,4,"yes","Automatic", "Petrol", "Suv"),
			new CarInfo(500, 1000,4,"yes","Automatic", "Electric", "Suv"),

			new CarInfo(300, 750,4,"yes","Manual", "Petrol", "Kombi"),
			new CarInfo(300, 750,4,"yes","Manual", "Petrol", "Kombi"),
			new CarInfo(325, 1000,4,"yes","Automatic", "Electric", "Kombi"),

			new CarInfo(400, 0,2,"no","Automatic", "Petrol", "Sport"),
			new CarInfo(600, 0,2,"no","manual", "Petrol", "Sport"),
			new CarInfo(430, 0,2,"no","Automatic", "Electric", "Sport"),

		};

		

	}
}
