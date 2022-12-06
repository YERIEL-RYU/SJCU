class EX25
{
  interface Animal
  {
    public int Weight { get; set; } 
    public void Speak();
  }

  class Dog : Animal, IComparable
  {
    public int Weight { get; set; }

    public Dog(int weight) { this.Weight = weight; }

    public override string ToString() { 
      return "강아지(" + Weight + "kg)";
    }

    public int CompareTo(object obj) {
      return this.Weight.CompareTo((obj as Animal).Weight);
    }

    public void Speak() { Console.WriteLine("멍멍!"); }
  }

  class Cat : Animal, IComparable
  {
    public int Weight { get; set; }

    public Cat(int weight) { this.Weight = weight; }

    public override string ToString() { 
      return "고양이(" + Weight + "kg)";
    }

    public int CompareTo(object obj) {
      return this.Weight.CompareTo((obj as Animal).Weight);
    }
    
    public void Speak() { Console.WriteLine("야옹야옹!"); }
  }

  static void Main(string[] args)
  {
    Random rand = new Random(); List<Animal> list = new List<Animal>();
    Console.WriteLine("동물을 10마리 랜덤하게 생성합니다.");
    for (int i = 0; i < 10; i++) {
      if (rand.NextDouble() >= 0.5) 
        list.Add(new Dog(rand.Next(19) + 1));
      else
        list.Add(new Cat(rand.Next(9) + 1));
    }
    list.Sort();

    foreach (var item in list)
    {
      Console.Write(item);
      item.Speak();
    }
  }
}