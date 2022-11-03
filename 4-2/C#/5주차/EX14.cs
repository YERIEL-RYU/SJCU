class Program
{    
  class Product
  {
    pubic string name;
    pubic int price;
  }

  static void Main(string[] args)
  {
    List<Product> list = new List<Product>();

    for (int i = 0; i < 3; i++)
    {
      Product product = new Product();
      Console.Write("제품명? ");
      product.name = Console.ReadLine();
      Console.Write("가격? ");
      product.price = int.Parse(Console.ReadLine());
      list.Add(product);
    }

    Console.WriteLine("제품명과 가격은 다음과 같습니다."); foreach(var product in list)
    {
      Console.Write("제품명: " + product.name);
      Console.WriteLine(", 가격: " + product.price); 
    }
  }
}