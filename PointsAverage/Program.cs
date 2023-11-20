Console.WriteLine("Write 5 student marks:");
float average = 0.0f;
for(int i = 0; i < 5; i++)
    average += float.Parse(Console.ReadLine());
average /= 5;
if (average < 50)
    Console.WriteLine($"{average} average mark isnt enough. Try again.");
else
    Console.WriteLine($"{average} average mark is enough. Good job.");