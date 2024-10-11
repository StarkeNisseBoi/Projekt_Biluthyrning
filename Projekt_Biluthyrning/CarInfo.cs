using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class CarInfo : VehicleInfo {
		public int _horsepower;
		public int _towCapacity;
		public int _doors;
		public string _towHitch;
		public string _gearBox;
		public string _carModel;

		public CarInfo(int inputHorsepower, int inputTowCapacity, int inputDoors, string inputTowHitch, string inputGearbox, string inputTotalTyres, string inputFuelInfo, string inputVehicleType, string inputCarModel) : 
			base(inputTotalTyres, inputFuelInfo, inputVehicleType) {
			_horsepower = inputHorsepower;
			_towCapacity = inputTowCapacity;
			_doors = inputDoors;
			_towHitch = inputTowHitch;
			_gearBox = inputGearbox;
			_carModel = inputCarModel;
			
		}

		static List<CarInfo> ListOfAvaiableCars = new List<CarInfo>() {
			new CarInfo(250, 1000,4,"yes","Automatic", "4", "Diesel", "Sedan", "Volvo S60"),
			new CarInfo(120, 0,4,"no","Manual", "4", "Petrol", "Sedan", "Volvo S70"),
			new CarInfo(400, 750,4,"yes","Automatic", "4","Electric", "Sedan", "Tesla Model 3"),

			new CarInfo(300, 850,4,"yes","Automatic", "4", "Diesel", "Suv", "Peugeot 3800"),
			new CarInfo(275, 1250,4,"yes","Automatic", "4", "Petrol", "Suv", "Volvo XC60"),
			new CarInfo(500, 1000,4,"yes","Automatic", "4", "Electric", "Suv", "Mercedes EQE-Suv 53 AMG"),

			new CarInfo(300, 750,4,"yes","Manual", "4", "Petrol", "Kombi", "Mercedes C-Class"),
			new CarInfo(300, 750,4,"yes","Automatic", "4", "Diesel", "Kombi", "Mercedes E-Class"),
			new CarInfo(325, 1000,4,"yes","Automatic", "4", "Electric", "Kombi", "Polestar 3"),

			new CarInfo(400, 0,2,"no","Automatic", "4","Petrol", "Sport", "BMW M5"),
			new CarInfo(600, 0,2,"no","manual", "4","Petrol", "Sport", "Porsche GT3 rs"),
			new CarInfo(430, 0,2,"no","Automatic", "4","Electric", "Sport", "BMW i4"),

		};

		public static List<CarInfo> MethodOfElimination(string inputCarType, string inputGearbox, string inputFueltype, string inputTowHitch) {
			//Console.WriteLine(inputCarType);
			//Console.WriteLine(inputGearbox);
			//Console.WriteLine(inputFueltype);
			//Console.WriteLine(inputTowHitch);
			List<CarInfo> AvailableCars = new List<CarInfo>();
			for (int i = 0; i < ListOfAvaiableCars.Count; i++) { 
				if (ListOfAvaiableCars[i].VehicleType == inputCarType && ListOfAvaiableCars[i]._gearBox == inputGearbox && ListOfAvaiableCars[i].FuelInfo == inputFueltype) {
					AvailableCars.Add(ListOfAvaiableCars[i]);
				}
			}
			return AvailableCars;

		}
	}
}
