using System;
using Microsoft.AspNetCore.Mvc;
using Xunit;
namespace PingContext.Application.Controllers.UnitTests
{
	public partial class PingControllerTest
	{
		[Fact]
		public void When_GetPing_Should_ReturnAnOkObjectResult()
		{
			//Arrange

			// Act
			IActionResult result = systemUnderTests.GetPing();

			// Assert
			Assert.IsType<OkObjectResult>(result);

		}
	}
}

