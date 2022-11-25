class Animal
{
    public int Age { get; set; }
    public string Color { get; set; }

    public Animal() { this.Age = 0; }

    public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
    public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
}

class Dog:Animal
{
    public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
}

class Cat : Animal
{
    public void Meow() { Console.WriteLine("야옹야옹 웁니다."); }
}

class EX19 
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.Eat();
        cat.Eat();

        dog.Sleep();
        cat.Sleep();

        dog.Bark();
        cat.Meow();
    }
}