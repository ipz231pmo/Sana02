Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());

int a = 0;
for (int i = 1, fact = 1; i <= n; a += fact, i++, fact *= i) ;
Console.WriteLine($"Result of C expression is {a}");