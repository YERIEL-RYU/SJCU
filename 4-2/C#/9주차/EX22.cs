class EX22
{
  abstract class Animal
  {
    public void Eat() {Console.WriteLine("냠냠");}
    abstract public void Speak();
  }

  class Dog : Animal
  {
    public override void Speak()
    {
      Console.WriteLine("왈왈... 아니, 강아지가 말을 하다니!");
    }
  }

  class Cat : Animal 
  {
    public override void Speak()
    {
      Console.WriteLine("왈왈... 아니, 고양이가 말을 하다니!");
    }
  }

  static void Main(string[] arg) 
  {
    Cat cat = new Cat();
    Dog dog = new Dog();

    cat.Eat();
    dog.Eat();
    cat.Speak();
    dog.Speak();
  }
}