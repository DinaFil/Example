string Method4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i < count)
{
result = result + text;
i++;    
}
return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

// void Method1()
// {
//     Console.WriteLine("Это моя программа!");
// }

// Method1();

// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method2(count: 4, msg: "Новый текс");

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);
