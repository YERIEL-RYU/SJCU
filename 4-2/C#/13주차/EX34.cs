List<int> input = new List<int>() ;

while (true)
{
  Console.Write("숫자? (-1은 종료)");
  int num = int.Parse(Console.ReadLine());
  if (num == -1) { break; }
  input.Add(num);
}

Console.Write("배수? ");
int multi = int.Parse(Console.ReadLine());

var output =  from item in input
              where item % multi == 0
              orderby item ascending
              select item;

Console.WriteLine(multi + "의 배수만 출력하면 다음과 같습니다 :");
foreach (var item in output)
{
  Console.WriteLine(item); 
}