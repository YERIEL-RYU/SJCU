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
              orderby item ascending
              select new
              {
                A = item,
                B = multi,
                C = item * multi
              };

foreach (var item in output)
{
  Console.WriteLine(item.A + "와 " + item.B + "를 곱하면" + item.C + " 입니다."); 
}