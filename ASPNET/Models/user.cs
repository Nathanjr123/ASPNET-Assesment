using System;
namespace ASPNET.Models
{
	public class user
	{
		public int ID_Number
        {
			get;
			set;
		}
		public string First_Name
		{
			get;
			set;
		}
		public string Last_Name
		{
			get;
			set;
		}
		public string Password
		{
			get;

			set;
		}
		public string Email
		{
			get;
			set;
		}
        //First_Name Last_Name ID_Number   Password   Email
        public user()
		{
		}
	}
}

