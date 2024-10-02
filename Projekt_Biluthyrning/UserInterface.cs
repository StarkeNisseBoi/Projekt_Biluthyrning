using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class UserInterface {
		public void StarPage() {
            Console.WriteLine("----------------------------" );
            Console.WriteLine("Welcome! Bestrent.com");
            Console.WriteLine("----------------------------");
            Console.WriteLine("[PRESS ANY KEY TO CONTINUE]");
			Console.ReadKey();
			Console.Clear();
			
		}

		public void MainPage() {
            Console.WriteLine("please, Choose vehicle selection");
            Console.WriteLine("------------------------------------");
			Console.WriteLine("1. Suv" );
            Console.WriteLine("2. Sedan");
            Console.WriteLine("3. Kombi");
			Console.WriteLine("4. Sport");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("5. Exit");
			string ChoosenVehicle = Console.ReadLine();

			if (ChoosenVehicle == "1") {

			} else if (ChoosenVehicle == "2") {

			} else if (ChoosenVehicle == "3") {

			} else if (ChoosenVehicle == "4"){

			} else if (ChoosenVehicle == "5") {
				Environment.Exit(1);
			}

		}
	}
}
