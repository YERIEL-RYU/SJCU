Console.Write("몇 월인가요? ");
int input = int.Parse(Console.ReadLine());

switch (input)
{
  case 12:
  case 1:
  case 2:
    Console.WriteLine("겨울입니다.");
    break;
  case 3:
  case 4:
  case 5:
    Console.WriteLine("봄입니다.");
    break;
  case 6:
  case 7:
  case 8:
    Console.WriteLine("여름입니다.");
    break;
  case 9:
  case 10:
  case 11:
    Console.WriteLine("가을입니다.");
    break;
  default:
    Console.WriteLine("잘못 입력하였습니다.");
    break;
}