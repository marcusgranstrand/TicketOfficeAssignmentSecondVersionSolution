using TicketOfficeAssignmentSecondVersion.Classes;

while (true)
{
	Console.Clear();

	Console.WriteLine("Welcome to the Ticket Office!");

	var age = Methods.GetCustomerAge();
	var place = Methods.GetCustomerPlacePreference();

	Methods.PriceSetter(age, place);
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