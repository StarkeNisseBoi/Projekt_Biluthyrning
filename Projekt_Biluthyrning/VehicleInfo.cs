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

		/// <summary>
		/// Konstruktor som skickar med värden 
		/// </summary>
		/// <param name="inputTotalTyres">Gör en möjlig input för TotalTyres, skickar med värden.</param>
		/// <param name="inputFuelInfo">Gör en möjlig input för FuelInfo, skickar med värden.</param>
		/// <param name="inputVehicleType">Gör en möjlig input för VehicleType, skickar med värden.</param>
		public VehicleInfo(string inputTotalTyres, string inputFuelInfo, string inputVehicleType) {
			TotalTyres = inputTotalTyres;
			FuelInfo = inputFuelInfo;
			VehicleType = inputVehicleType;
		}
	}
}
