string[] names = new string[3];

for (int i = 0; i < names.Length; i++)
{
  Console.Write("이름을 입력하세요 : ");
  names[i] = Console.ReadLine();
}

Console.WriteLine("당신의 친구들은 다음과 같습니다 : ");
foreach (string name in names) 
{
  Console.WriteLine(name);
}