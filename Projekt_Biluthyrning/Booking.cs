using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class Booking {
		public string _bookingName;
		public int _age;
		public string _address;
		public string _mail;
		public string _phoneNumber;
		public string _pickUpLocation;
		public string _startDate;
		public string _endDate;

		/// <summary>
		/// Konstruktor som skickar med värden
		/// </summary>
		/// <param name="inputBookingName">Gör en möjlig input för _bookingName, skickar med värden.</param>
		/// <param name="inputAge">Gör en möjlig input för _age, skickar med värden.</param>
		/// <param name="inputAddress">Gör en möjlig input för _address, skickar med värden.</param>
		/// <param name="inputMail">Gör en möjlig input för _mail, skickar med värden.</param>
		/// <param name="inputPhoneNumber">Gör en möjlig input för _phoneNumber, skickar med värden.</param>
		/// <param name="inputPickUpLocation">Gör en möjlig input för _pickUpLocation, skickar med värden.</param>
		/// <param name="inputStartDate">Gör en möjlig input för _startDate, skickar med värden.</param>
		/// <param name="inputEndDate">Gör en möjlig input för _endDate, skickar med värden.</param>
		public Booking(string inputBookingName, int inputAge, string inputAddress, string inputMail, string inputPhoneNumber, string inputPickUpLocation,string inputStartDate, string inputEndDate ) {
			_bookingName = inputBookingName;
			_age = inputAge;
			_address = inputAddress;
			_mail = inputMail;
			_phoneNumber = inputPhoneNumber;
			_pickUpLocation = inputPickUpLocation;
			_startDate = inputStartDate;
			_endDate = inputEndDate;
		}
	}
}
