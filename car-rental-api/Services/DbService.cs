using car_rental_api.Models;
using LiteDB;

namespace car_rental_api.Services {
	public class DbService {
		private string dbConnectionString =
				@$"Filename={Environment.CurrentDirectory}\Db\CarsDb.db;Connection=Shared";
		private readonly LiteDatabase db;

		public DbService() {
			db = new LiteDatabase(dbConnectionString);
		}

		private ILiteCollection<Car> getCarCollection() => db.GetCollection<Car>("cars");

		public IEnumerable<Car> Get() {
			var col = getCarCollection();

			return col.FindAll().ToList();
		}

		public Car Get(Guid id) {
			var col = getCarCollection();

			return col.FindById(id);
		}

		public void Insert(Car car) {
			var col = getCarCollection();

			col.Insert(car);
		}

		public void Delete(Guid id) {
			var col = getCarCollection();

			if(col.Exists(_car => _car.Id == id)) col.Delete(id);
		}
	}	
}
