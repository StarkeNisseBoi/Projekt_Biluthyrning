using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class VehicleInfo {
		public string TotalTyres;
		public string FuelInfo;
		public string VehicleType;

		public VehicleInfo(string inputTotalTyres, string inputFuelInfo, string inputVehicleType) {
			TotalTyres = inputTotalTyres;
			FuelInfo = inputFuelInfo;
			VehicleType = inputVehicleType;
		}

		/// <summary>
		/// 
		/// </summary>
		public void PrintVehicle() {
            Console.WriteLine("Your vehicle type: " + VehicleType + " FuelInfo: " + FuelInfo + " Tires: " + TotalTyres);
		}
	}
}
