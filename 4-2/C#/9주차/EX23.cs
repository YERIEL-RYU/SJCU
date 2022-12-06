class EX23
{
  struct Point
  {
    public int x;
    public int y;
    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    public void Print()
    {
      Console.WriteLine("x=" + x + ", y=" + y);
    }
  }
  class MyClass
  {
    Point p1, p2;

    public MyClass(int x1, int y1, int x2, int y2)
    {
      p1.x = x1;
      p1.y = y1;
      p2.x = x2;
      p2.y = y2;
    }

    public Point Add() {
      return new Point(p1.x + p2.x, p1.y + p2.y);
    }

    public Point Sub() {
      return new Point(p1.x - p2.x, p1.y - p2.y);
    }
  }
  static void Main(string[] args)
  {
    MyClass myclass = new MyClass(2, 3, 5, 7);
    myclass.Add().Print();
    myclass.Sub().Print();
  }
}