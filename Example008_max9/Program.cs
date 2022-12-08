int Max(int arg1, int arg2, int arg3)

{
int result = arg1;
if (arg2> result) result = arg2;
if (arg3> result) result = arg3;
 return result;
}
    
int a1 = 10;
int b1 = 11;
int c1 = 244;

int a2 = 12;
int b2 = 773;
int c2 = 33;

int a3 = 2333;
int b3 = 23;
int c3 = 33;

// int max1 = ;
// int max2 = Max(a2, b2, c2);
// int max3 = ;
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);



