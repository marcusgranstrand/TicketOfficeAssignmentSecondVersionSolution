using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicketOfficeAssignmentSecondVersion.Classes
{
	public class Ticket
	{
		public decimal tax;
		public int price;

		public int Age {  get; set; }
		public EnumClass Place {  get; set; }
		public int Number { get; set; }

		public Ticket(int age, EnumClass place)
		{
			this.Age = age;
			this.Place = place;
			Number = Methods.TicketNumberGenerator();
		}

		public int Price()
		{
			if (Age <= 11)
			{
				switch (Place)
				{
					case EnumClass.Seated: return price = 50;
					case EnumClass.Standing: return price = 25;
				}
			}

			if (Age >= 12 && Age <= 64)
			{
				switch(Place)
				{
					case EnumClass.Seated: return price = 170;
					case EnumClass.Standing: return price = 110;
				}

			}

			if(Age >= 65)
			{
				switch(Place)
				{
					case EnumClass.Seated: return price = 100;
					case EnumClass.Standing: return price = 60;
				}
			}

			return price;
			
		}

		public decimal Tax()
		{
			tax = (decimal)(1-1/1.06)*Price();
			return tax;
		}
	}
}
