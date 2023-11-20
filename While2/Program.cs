Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());

double a = 0;
for (int i = 1; i <= n; i++)
    a += 1 + 1.0/(i*i);
Console.WriteLine($"Result of B expression is {a}");