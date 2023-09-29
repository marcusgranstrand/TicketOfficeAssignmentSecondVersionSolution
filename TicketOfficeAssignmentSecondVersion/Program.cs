using TicketOfficeAssignmentSecondVersion.Classes;

while (true)
{
	Console.Clear();

	Console.WriteLine("Welcome to the Ticket Office!");

	Methods.GetCustomerAge();
	Methods.GetCustomerPlacePreference();

	/*
	 *	First tried to set the GetCustomerAge() and GetCustomerPlacePreference() 
	 *	as parameters of PriceSetter but it didn´t want to and suggested to go back to "old-main" style 
	 *	and still required more stuff so I accepted my limitations in programming so far 
	 */

	Methods.PriceSetter(Methods.ageEntered);
	Methods.TaxCalculator(Methods.price);
	Methods.TicketNumberGenerator();
	Methods.Confirmation(Methods.price, Methods.tax, Methods.ticketNumber);

	Methods.CheckPlaceAvailability(Methods.placeList, Methods.ticketNumber);
	Methods.AddPlace(Methods.ticketNumber);

	Console.WriteLine("Do you want to keep booking tickets: \nYes = Enter, Quit = Z");

	if (Console.ReadKey().Key == ConsoleKey.Z)
	{
		break;
	}
}
Console.ReadKey();