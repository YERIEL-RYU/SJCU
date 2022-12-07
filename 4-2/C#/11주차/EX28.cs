class EX28
{
  class Box
  {
    private int size;
    public int Size
    {
      get { return size; }
      set {
        if(value > 0){ size = value; }
        else { throw new Exception("크기는 자연수를 입력해주세요"); }
      }
    }
    public Box(int size) { Size = size; }
    public int Area() { return this.size * this.size; }
  }
  static void Main(string[] args)
  {
    try
    {
      Box box = new Box(-10);
    }
    catch (Exception exception)
    {
      Console.WriteLine(exception.Message);
    }
    finally
    {
      Console.WriteLine("프로그램 실행을 종료합니다.");
    }
  }
}