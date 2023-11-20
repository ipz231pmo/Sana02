Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());

double a = 0;
for (int i = 1; i <= n; i++)
    a += Math.Pow(-1, i) / (2 * i + 1);
Console.WriteLine($"Result of A expression is {a}");