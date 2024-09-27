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
	}
}
