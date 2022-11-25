using System;
namespace ASPNET.Models
{
	public class vehicle
    {//VIN License_Number Registration_Plate License_Expiry Model Colour  ID_Number

		public string VIN
		{
			get;
			set;
		}
		public string License_Number
		{
			get;
			set;
		}
		public string Registration_Plate
		{
			get;
			set;
		}
		public string License_Expiry
		{
			get;
			set;
		}
		public string Model
		{
			get;
			set;
		}
		public string Colour
		{
			get;
			set;
		}
        public vehicle()
		{
		}
		public int ID_Number
		{
			get;
			set;
		}

    }
}

