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
		protected string _gearBox;

		public CarInfo(int inputHorsepower, int inputTowCapacity, int inputDoors, string inputTowHitch, string inputGearbox, string inputTotalTyres, string inputFuelInfo, string inputVehicleType) : 
			base(inputTotalTyres, inputFuelInfo, inputVehicleType) {
			_horsepower = inputHorsepower;
			_towCapacity = inputTowCapacity;
			_doors = inputDoors;
			_towHitch = inputTowHitch;
			_gearBox = inputGearbox;
		}

		List<CarInfo> ListOfAvaiableCars = new List<CarInfo>() {
			new CarInfo(250, 1000,4,"yes","Automatic", "4", "Diesel", "Sedan"),
			new CarInfo(120, 0,4,"no","Manual", "4", "Petrol", "Sedan"),
			new CarInfo(400, 750,4,"yes","Automatic", "4","Electric", "Sedan"),

			new CarInfo(300, 850,4,"yes","Manual", "4", "Diesel", "Suv"),
			new CarInfo(275, 1250,4,"yes","Automatic", "4", "Petrol", "Suv"),
			new CarInfo(500, 1000,4,"yes","Automatic", "4", "Electric", "Suv"),

			new CarInfo(300, 750,4,"yes","Manual", "4", "Petrol", "Kombi"),
			new CarInfo(300, 750,4,"yes","Manual", "4", "Petrol", "Kombi"),
			new CarInfo(325, 1000,4,"yes","Automatic", "4", "Electric", "Kombi"),

			new CarInfo(400, 0,2,"no","Automatic", "4","Petrol", "Sport"),
			new CarInfo(600, 0,2,"no","manual", "4","Petrol", "Sport"),
			new CarInfo(430, 0,2,"no","Automatic", "4","Electric", "Sport"),

		};

		public List<CarInfo> MethodOfElimination(string inputCarType, string inputGearbox, string inputFueltype, string inputDrivetrain) {
			List<CarInfo> AvailableCars = new List<CarInfo>();
			for (int i = 0; i <= ListOfAvaiableCars.Count; i++) {
				if (ListOfAvaiableCars[i].VehicleType == inputCarType && ListOfAvaiableCars[i]._gearBox == inputGearbox && ListOfAvaiableCars[i].FuelInfo == inputFueltype) {
					AvailableCars.Add(ListOfAvaiableCars[i]);
				}
			}
			return AvailableCars;

		}
	}
}
