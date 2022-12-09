string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля";

string Replace(string text, char oldValue, char newValue)
{
string result = String.Empty;
int length = text.Length;
for (int i = 0; i < length; i++)
{
if (text[i] == oldValue) result = result + $"{newValue}";
else result = result + $"{text[i]}";
}
return result;
}

string newtext = Replace(text, ' ', '|');
Console.WriteLine(newtext);

string newtext1 = Replace(text, 'к', 'К');
Console.WriteLine(newtext1);
