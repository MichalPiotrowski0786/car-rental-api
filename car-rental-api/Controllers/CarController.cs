using Microsoft.AspNetCore.Mvc;
using car_rental_api.Models;
using car_rental_api.Services;

namespace car_rental_api.Controllers {
	[Route("api")]
	[ApiController]
	public class CarController : ControllerBase {

		DbService db = new DbService();

		[HttpGet]
		public IEnumerable<Car> Get() {
			return db.Get();
		}

		[HttpGet("{id}")]
		public Car Get(Guid id) {
			return db.Get(id);
		}

		[HttpPost]
		public void Post([FromBody] Car body) {
			var car = new Car(
					body.Name,
					body.Range,
					body.Away,
					body.IsAvailable
				);

			db.Insert(car);
		}

		//[HttpPut("{id}")]
		//public void Put(int id, [FromBody] string value) {
		//}

		[HttpDelete("{id}")]
		public void Delete(Guid id) {
			db.Delete(id);
		}
	}
}
