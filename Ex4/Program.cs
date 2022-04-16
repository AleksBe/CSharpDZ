int N = 10;
int a = 1;
int count = 0;

while(a <= N) // будем считать, что до N включительно
{
    if(a % 2 == 0)
    {
        count = count +1;
    }
    a = a + 1;
} 

Console.Write("В указанном интервале количество четных чисел= ");
Console.WriteLine(count);