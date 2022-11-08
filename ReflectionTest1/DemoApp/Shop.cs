
record Item(string Name, string Brand);

readonly record struct Customer(string Id, decimal Payment, int Rating, string City="Mumbai");

class Shop
{

	public static Item[] GetItems() {
		return new Item[] {
			new Item("cpu", "intel"),
			new Item("ddr", "samsung"),
			new Item("mouse", "logitech"),
			new Item("motherboard", "intel"),
			new Item("cpu", "amd"),
			new Item("ssd", "samsung"),
			new Item("keyboard", "logitech"),
			new Item("display", "samsung")
		};
	}
	
	public static ICollection<Customer> GetCustomers() {
		var customers = new List<Customer>();
		customers.Add(new Customer("Ranjeet", 35000, 3));
		customers.Add(new Customer("Vishal", 20000, 2));
		customers.Add(new Customer("Abhishek", 85000, 5));
		customers.Add(new Customer("Manish", 40000, 4));
		customers.Add(new Customer("Saeed", 55000, 1));
		customers.Add(new Customer("Nisha", 25000, 2));
		customers.Add(new Customer("Ketaki", 90000, 5));
		customers.Add(new Customer("Pooja", 15000, 1));
		customers.Add(new Customer("Darshan", 80000, 4));
		customers.Add(new Customer("Harshal", 30000, 3));
		return customers;
	}

}