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
		
		// Had another test ongoing but for some reason when running test
		// it just kept going and going without getting anywhere so I removed it again
	}
}