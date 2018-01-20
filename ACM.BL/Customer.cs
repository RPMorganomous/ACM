using System;

namespace ACM.BL
{
    public class Customer
    {
		private string _lastname;
		public string LastName
		{
			get
			{
				return _lastname;
			}
			set
			{
				_lastname = value;
			}
		}

		public string FirstName { get; set; }

		public string EmailAddress { get; set; }

		public int CustomerId { get; private set; }

		public string FullName
		{
			get
			{
				return LastName + "," + FirstName;
			}
		}
    }


}
