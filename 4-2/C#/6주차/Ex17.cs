class MyProgram
{
  class Student
  {
    private string name;
    public string Name { get; set; }

    private int score;
    public int Score
    {
      get { return score; }
      set
      {
        score = (value >= 0 && value <= 100) ? value : 0;
      }
    }
    public Student(string name, int score)
    {
      Name = name;
      Score = score;
    }
  }

  static void Main(string[] args)
  {
    Student student = new Student("홍길동", 80);
    Console.WriteLine(student.Name + " 학생 점수 : " + student.Score);

    student.Name = "김세종";
    student.Score = 100;

    Console.WriteLine(student.Name + " 학생 점수 : "+ student.Score);
    Console.WriteLine("이름을 바꾸니 100점이 되었네요!");
  }
}