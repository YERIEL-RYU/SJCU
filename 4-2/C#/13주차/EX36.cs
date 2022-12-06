class EX36
{
  class Student
  {
    public string Name { get; set; }
    public int Score { get; set; }

    public Student(string name, int score) 
    {
      Name = name;
      Score = score;
    }

    public override string ToString()
    {
      return Name + "(" + Score + "점)";
    }
  }

  static void Main(string[] args)
  {
    List<Student> input = new List<Student>();
    while (true)
    {
      Console.Write("이름? ");
      string name = Console.ReadLine();
      Console.Write("점수? ");
      int score = int.Parse(Console.ReadLine());

      Student student = new Student(name, score);
      input.Add(student);

      Console.Write("계속 입력할까요(y/n)");
      if(Console.ReadLine() != "y") break;
    }
    
    Console.Write("커트라인? ");
    int cutline = int.Parse(Console.ReadLine());

    var output =  from item in input
                  where item.Score >= cutline
                  orderby item.Score descending
                  select item;

    Console.WriteLine("합격자 명단은 다음과 같습니다.");
    foreach (var item in output)
    {
      Console.WriteLine(item);
    }
  }
}