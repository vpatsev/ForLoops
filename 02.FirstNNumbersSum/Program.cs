int num = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 1; i <= num; i++)
{

    result += i;
    if (i < num)
    {
        Console.Write(i + "+");
    } else { Console.Write(i); }
} 
Console.WriteLine($"={result}");
