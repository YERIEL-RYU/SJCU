List<string> names = new List<string>();

for (int i = 0; i < 3; i++) 
{
  Console.Write("이름을 입력하세요 : ");
  names.Add(Console.ReadLine());
}

Console.WriteLine("입력한 이름은 다음과 같습니다 : ");
foreach(var name in names)
  Console.WriteLine(name);