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
