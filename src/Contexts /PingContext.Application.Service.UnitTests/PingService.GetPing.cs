using System;
using Xunit;

namespace PingContext.Application.Service.UnitTests
{
	public partial class PingServiceTests
	{
		[Fact]
		public void When_GetPing_Should_ReturnPong()
		{
			//Arrange
			string expected = "Pong!";

			//Act
			var result = this.systemUnderTest.GetPing();

			//Assert
			Assert.NotNull(result);
			Assert.Equal(result, expected);

		}
	}
}

