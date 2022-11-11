class Program
{
  class Test 
  {
    public static int Sum(int x, int y) { return x + y; }
    public static int Sum(int x, int y, int z) { return x + y + z; }
  }
  static void Main(string[] args) 
  {
    Console.WriteLine(Test.Sum(10, 20));
    Console.WriteLine(Test.Sum(10, 20, 30));
  }
}