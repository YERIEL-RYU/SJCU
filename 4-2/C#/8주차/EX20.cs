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

class EX20
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        List<Animal> animals = new List<Animal>();

        for ( int i = 0; i < 10; i++ )
        {
            if (rand.NextDouble() >= 0.5) 
                animals.Add(new Dog());
            else 
                animals.Add(new Cat());
        }

        foreach (var animal in animals)
        {
            if (animal is Dog) {
                Dog dog = animal as Dog;
                dog.Bark();
            }

            if (animal is Cat) {
                Cat cat = animal as Cat;
                cat.Meow();
            }
        }
    }
}