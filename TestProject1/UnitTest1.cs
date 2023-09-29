namespace TestProject1
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			string someText = ",734,23,";
			int someInt = 152;

			string expected = "True";
			string actual = TicketOfficeAssignmentSecondVersion.Classes.Methods.CheckPlaceAvailability(someText, someInt).ToString();

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void Test2()
		{
			int someInt = 134;

			decimal expected = 7.58m;
			decimal actual = TicketOfficeAssignmentSecondVersion.Classes.Methods.TaxCalculator(someInt);

			Assert.Equal(expected, actual, precision: 2);
		
		}
	}
}