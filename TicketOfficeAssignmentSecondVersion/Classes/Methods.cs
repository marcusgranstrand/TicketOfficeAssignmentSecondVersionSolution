using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketOfficeAssignmentSecondVersion.Classes
{
	public static class Methods
	{
		public static int ageEntered = 0;
		public static string seatingString = "";
		public static string placeList = ",";
		public static int price = 0;
		public static int ticketNumber = 0;
		public static decimal tax = 0;

		public static int PriceSetter(int ageEntered)
		{
			//int price = 0;
			if (ageEntered <= 11)
			{
				switch (seatingString)
				{
					case "Seated": return price = 50;
					case "Standing": return price = 25;
				}
			}

			if (ageEntered >= 12 && ageEntered <= 64)
			{
				switch (seatingString)
				{
					case "Seated": return price = 170;
					case "Standing": return price = 110;
				}
			}

			if (ageEntered >= 65)
			{
				switch (seatingString)
				{
					case "Seated": return price = 100;
					case "Standing": return price = 60;
				}
			}

			return price;
		}

		public static decimal TaxCalculator(int price)
		{
			tax = (decimal)(1 - 1 / 1.06) * price;
			return tax;
		}

		public static int TicketNumberGenerator()
		{
			Random random = new Random();
			ticketNumber = random.Next(1, 8000);

			return ticketNumber;
		}

		public static void Confirmation(int price, decimal tax, int ticketNumber)
		{
			Console.WriteLine("Here is you booked ticket\n");
			Console.WriteLine($"Ticket Number: \t{ticketNumber}");
			Console.WriteLine($"Ticket Price: \t{price:C}");
			Console.WriteLine($"Tax: \t{tax:C}");
		}

		public static bool CheckPlaceAvailability(string placeList, int ticketNumber)
		{
			bool availability = true;

			string myText1 = Convert.ToString(ticketNumber);

			//First dabbled a bit with checking character by character, but got into exception problems (indexing)
			// so managed to solve it with splitting the placeList into seperate strings and comparing them to the
			// converted ticketNumberwith a foreach instead

			string[] splitted = placeList.Split(',', StringSplitOptions.RemoveEmptyEntries);

			foreach (string s in splitted)
			{
				//Console.WriteLine($"Substring: {s}");
				if (s.Equals(myText1))
					availability = false;
			}

			if (availability)
			{
				Console.WriteLine($"{availability} , That is vacant");
			}
			else
			{
				Console.WriteLine($"{availability} , That is already taken");
			}

			return availability;
		}

		public static string AddPlace(int ticketNumber) // Placelist is handled "locally" in the method since field
		{
			string temp = placeList.Insert(placeList.Length, $"{ticketNumber},").ToString();
			placeList = temp;

			Console.WriteLine($"This is whats in the list: {placeList}\n");

			return placeList;
		}

		public static int GetCustomerAge()
		{
			bool check = false;
			string age = "";

			while (!check)
			{
				Console.WriteLine("Please enter your age: ");
				age = Console.ReadLine();
				if (age.Length <= 3)
				{
					for (int i = 0; i < age.Length; i++)
					{
						if (age[i] > '0' && age[i] <= '9')
						{
							check = true;
						}
					}
				}
				else
					continue;
			}

			Console.WriteLine(check);
			Console.WriteLine(age);
			int ageEntered = Convert.ToInt32(age);

			return ageEntered;
		}

		public static string GetCustomerPlacePreference()
		{
			string temp;
			do
			{
				Console.WriteLine("Please enter if you want seated or standing placing: ");
				temp = Console.ReadLine();
				seatingString = $"{temp[0].ToString().ToUpper()}" + $"{temp.ToString().ToLower().Substring(1)}";

			} while (seatingString != "Seated" && seatingString != "Standing");

			Console.WriteLine(seatingString);

			Console.ReadKey();

			return seatingString;
		}









	}
}
