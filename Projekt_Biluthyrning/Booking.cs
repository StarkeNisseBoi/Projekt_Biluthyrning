using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Biluthyrning {
	internal class Booking {
		protected string _bookingName;
		protected int _age;
		protected string _address;
		protected string _mail;
		protected string _phoneNumber;
		protected string _pickUpLocation;
		protected string _startDate;
		protected string _endDate;

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
