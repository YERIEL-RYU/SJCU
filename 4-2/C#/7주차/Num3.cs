Console.Write("숫자1를 입력하세요 : " );
int num1 = int.Parse(Console.ReadLine()); 

Console.Write("숫자2를 입력하세요 : " );
int num2 = int.Parse(Console.ReadLine()); 

Console.Write("연산 종류를 입력하세요 : ");
string type = Console.ReadLine(); 

int result;

if (type == "+")
{
  result = num1 + num2;
  Console.WriteLine(num1 + type + num2 + "=" + result + "입니다.");
}
else if (type == "-")
{
  result = num1 - num2;
  Console.WriteLine(num1 + type + num2 + "=" + result + "입니다.");
}
else if (type == "*")
{
  result = num1 * num2;
  Console.WriteLine(num1 + type + num2 + "=" + result + "입니다.");
}
else if (type == "/")
{
  result = num1 / num2;
  Console.WriteLine(num1 + type + num2 + "=" + result + "입니다.");
}
else {
  Console.WriteLine("덧셈, 뺄셈, 곱셈, 나눗셈만 가능합니다.");
}