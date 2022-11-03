int[] numbers = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
  Console.Write("숫자를 입력하세요 : ");
  numbers[i] = int.Parse(Console.ReadLine());
}

foreach (var number in numbers)
{
  if (number % 2 != 1)
    continue;
  Console.WriteLine(number);
}