using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class Trailer : VehicleInfo {
		protected string _trailerType;
		protected int _maxLoad;
		protected int _volume;
		protected string _braked;
		protected string _unbraked;

		public Trailer(string inputTrailerType, int inputMaxLoad, int inputVolume, string inputBraked, string inputUnbraked, string inputGearBox, string inputFuelInfo, string inputCarType)  : base(inputGearBox, inputFuelInfo, inputCarType) {
			_trailerType = inputTrailerType;
			_maxLoad = inputMaxLoad;
			_volume = inputVolume;
			_braked = inputBraked;
			_unbraked = inputUnbraked;
		}

	}
}
