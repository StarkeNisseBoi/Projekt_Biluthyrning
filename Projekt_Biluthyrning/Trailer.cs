using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class Trailer : VehicleInfo {
		public string _trailerType;
		public int _maxLoad;
		public int _volume;
		public string _braked;
		public string _unbraked;

		/// <summary>
		/// Konstruktor
		/// </summary>
		/// <param name="inputTrailerType">Gör en möjlig input för _trailerType, skickar med värden.</param>
		/// <param name="inputMaxLoad">Gör en möjlig input för _maxload, skickar med värden.</param>
		/// <param name="inputVolume">Gör en möjlig input för _volume, skickar med värden.</param>
		/// <param name="inputBraked">Gör en möjlig input för _braked, skickar med värden.</param>
		/// <param name="inputUnbraked">Gör en möjlig input för _unbraked, skickar med värden.</param>
		/// <param name="inputTotalTyres">Gör en möjlig input för TotalTyres, skickar med värden.</param>
		/// <param name="inputFuelInfo">Gör en möjlig input för FuelInfo, skickar med värden.</param>
		/// <param name="inputVehicleType">Gör en möjlig input för VehicleType, skickar med värden.</param>
		public Trailer(string inputTrailerType, int inputMaxLoad, int inputVolume, string inputBraked, string inputUnbraked, string inputTotalTyres, string inputFuelInfo, string inputVehicleType)  : base(inputTotalTyres, inputFuelInfo, inputVehicleType) {
			_trailerType = inputTrailerType;
			_maxLoad = inputMaxLoad;
			_volume = inputVolume;
			_braked = inputBraked;
			_unbraked = inputUnbraked;
		}


		List<Trailer> ListOfTrailers = new List<Trailer> {
			new Trailer("Enclosed trailer", 1000, 5, "Braked", "", "4", "None", "Trailer" ),
			new Trailer("Grating trailer", 500, 2, "", "Unbraked", "2", "None", "Trailer")
		};


	}
}
