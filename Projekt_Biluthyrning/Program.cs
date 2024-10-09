using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class Program {
		static void Main(string[] args) {

			UserInterface userInterface = new UserInterface();
			userInterface.StarPage();
			Console.Clear();
			userInterface.BookingDetail();
			Console.Clear();
			userInterface.MainPage();
			userInterface.TrailerType();
			userInterface.TrailerTypeinfo();
			userInterface.FuelType();
			userInterface.Gearbox();
			userInterface.TowHitch();

		}
	}
}
