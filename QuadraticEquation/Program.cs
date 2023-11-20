Console.Write("Write quadratic equation coefs: ");
float a = float.Parse(Console.ReadLine()), b = float.Parse(Console.ReadLine()), c = float.Parse(Console.ReadLine()), d = b*b - 4*a*c;
Console.WriteLine($"Det is: {d}");
if (d < 0)
    Console.WriteLine("Eqution has none real number root");
else if (d == 0) {
    float x = -b / 2 / a;
    Console.WriteLine($"Equation has only 1 root: {x}");
}
else{
    float x1 = (-b + (float)(Math.Sqrt(d))) / 2 / a, x2 = (-b - (float)(Math.Sqrt(d))) / 2 / a;
    Console.WriteLine($"First root is {x1}, Second root is {x2}");
}
Console.WriteLine("Hello, World!");
