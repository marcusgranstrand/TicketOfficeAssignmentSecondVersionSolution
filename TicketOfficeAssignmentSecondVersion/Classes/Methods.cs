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

		public static string? Age {  get; set; }

		//public static EnumClass seating = GetCustomerPlacePreference();	Comment since no seating entered by user

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
						
			string[] splitted = placeList.Split(',', StringSplitOptions.RemoveEmptyEntries);

			foreach (string s in splitted)
			{				
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
			
			while (!check)
			{
				Console.WriteLine("Please enter your age: ");
				Age = Console.ReadLine();
				if (Age.Length <= 3)
				{
					for (int i = 0; i < Age.Length; i++)
					{
						if (Age[i] > '0' && Age[i] <= '9')
						{
							check = true;
						}
					}
				}
				else
					continue;
			}

			Console.WriteLine(check);
			Console.WriteLine(Age);
			int ageEntered = Convert.ToInt32(Age);

			return ageEntered;
		}

		public static EnumClass GetCustomerPlacePreference()
		{
			string? temp;
			do
			{
				Console.WriteLine("Please enter if you want seated or standing placing: ");
				temp = Console.ReadLine();
				seatingString = $"{temp[0].ToString().ToUpper()}" + $"{temp.ToString().ToLower().Substring(1)}";

			} while (seatingString != "Seated" && seatingString != "Standing");

			Console.WriteLine(seatingString);

			Console.ReadKey();

			if(seatingString == "Seated")
				return (EnumClass)0;
			else
				return (EnumClass)1;
		}
	}
}
