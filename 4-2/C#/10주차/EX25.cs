class EX24 
{
  class Product : IComparable
  {
    public string Name { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
      return Name + " : " + Price + '원';
    }

    public int CompareTo(object obj)
    {
      return this.Price.CompareTo((obj as Product).Price); }
    }

  static void Main(string[] args)
  {
    List<Product> list = new List<Product>();
    for(int i = 0; i < 5; i++) 
    {
      Product product = new Product();
      Console.Write("이름을 입력하세요: ");
      product.Name = Console.ReadLine();
      Console.Write("가격을 입력하세요: ");
      product.Price = int.Parse(Console.ReadLine());
      list.Add(product);
    }
    list.Sort();

    foreach (var item in list)
    {
      Console.WriteLine(item);
    }
  }
}