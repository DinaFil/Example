double Fibonacci(int n)
{
if (n == 2 || n == 1) return 1;
else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)
Console.WriteLine($"{Fibonacci(i)} = {i}");