namespace car_rental_api.Models {
	public class Car {
		public Car(string? name, int range, float away, bool isAvailable) {
			Id = Guid.NewGuid();
			Name = name;
			Range = range;
			Away = away;
			IsAvailable = isAvailable;
		}

		public Guid Id { get; private set; }
		public string? Name { get; set; }
		public int Range { get; set; }
		public float Away { get; set; }
		public bool IsAvailable { get; set; }
	}
}
