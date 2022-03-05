using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace routing_tut.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestingController : ControllerBase
	{

		[HttpGet("/{age:int:minlength(2)}")]
		public async Task<string> getHello(int age, [FromQuery] String name)
		{
			return $"Passed name is : {name ?? "Not Provided"}.Passed age is : {age}";
		}

		[HttpGet("/includes-anik/{value:anik}")]
		public async Task<string> getTestingCustom(string? value)
		{
			return $"Passed name is : {value ?? "Not Provided"}";
		}
	}
}
