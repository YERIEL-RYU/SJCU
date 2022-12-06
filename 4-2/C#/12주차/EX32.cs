class EX32
{
  public delegate void SendString(string message);

  static void Main(string[] args)
  {
    SendString sayHello, sayGoodBye, multiDelegate;

    sayHello = Hello;
    sayGoodBye = GoodBye;
    
    multiDelegate = sayHello + sayGoodBye;
    multiDelegate("김세종");

    multiDelegate -= sayGoodBye;
    multiDelegate("김세종");
  }

  public static void Hello(string message)
  { Console.WriteLine("안녕하세요, " + message + "씨..!"); }

  public static void GoodBye(string message)
  { Console.WriteLine("안녕히 가세요, " + message + "씨...."); }
}