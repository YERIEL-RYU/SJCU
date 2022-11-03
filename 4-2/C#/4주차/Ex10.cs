int[] myNumber = new int[3];
int mySum = 0;

Console.Write("숫자1? ");
myNumber[0] = int.Parse(Console.ReadLine());
Console.Write("숫자2? ");
myNumber[1] = int.Parse(Console.ReadLine());
Console.Write("숫자3? ");
myNumber[2] = int.Parse(Console.ReadLine());

mySum = myNumber[0] + myNumber[1] + myNumber[2];

Console.WriteLine("합계는 " + mySum + "입니다.");