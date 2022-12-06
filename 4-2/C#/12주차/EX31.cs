class EX31
{
  class Product
  {
    public string Name { get; set; }
    public int Price { get; set; }
  }

  static void Main(string[] args)
  {
    List<Product> products = new List<Product>()
    {
      new Product() { Name = "감자", Price = 400 },
      new Product() { Name = "사과", Price = 1000 },
      new Product() { Name = "고구마", Price = 700 },
    };

    products.Sort((a, b) => {
      return a.Price.CompareTo(b.Price);
    });

    foreach (var item in products)
    {
      Console.WriteLine(item.Name + " : " + item.Price);
    }
  }
}