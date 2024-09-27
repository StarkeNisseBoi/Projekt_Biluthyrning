using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class VehicleInfo {
		public string GearBox;
		public string FuelInfo;
		public string CarType;

		public VehicleInfo(string inputGearBox, string inputFuelInfo, string inputCarType) {
			GearBox = inputGearBox;
			FuelInfo = inputFuelInfo;
			CarType = inputCarType;
		}
	}
}
