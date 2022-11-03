string myStr = Console.ReadLine(); 
Console.WriteLine("입력내용: " + myStr);

long myNumA = 2147483647L + 2147483647L;
int myNumB = (int)myNumA;
Console.WriteLine(myNumB);

Console.WriteLine((52).ToString()); 
Console.WriteLine((52.273).ToString()); 
Console.WriteLine((true).ToString());

Console.WriteLine(bool.Parse("True")); 
Console.WriteLine(bool.Parse("true"));