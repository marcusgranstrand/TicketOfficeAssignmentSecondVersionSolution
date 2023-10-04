using TicketOfficeAssignmentSecondVersion.Classes;

while (true)
{
	Console.Clear();

	Console.WriteLine("Welcome to the Ticket Office!");

	Ticket ticket = new Ticket(24, EnumClass.Seated);	// Loop is unnecessary since fixed parameters

	var objecta = ticket.Age;
	var objectb = ticket.Place;
	var objectc = ticket.Price();
	var objectd = ticket.Tax();

	// 3 lines directly below so I see something when running it
	Methods.Confirmation(objectc, objectd, Methods.ticketNumber);
	Methods.CheckPlaceAvailability(Methods.placeList, Methods.ticketNumber);
	Methods.AddPlace(Methods.ticketNumber);

	Console.WriteLine("Do you want to keep booking tickets: \nYes = Enter, Quit = Z");
	if (Console.ReadKey().Key == ConsoleKey.Z)
	{
		break;
	}
}
Console.ReadKey();