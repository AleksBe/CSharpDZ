int N = 15;
int a = -N;

while(a <= N-1) // чтобы после последнего числа запятую не ставить
{
    Console.Write(a);
    Console.Write(", "); // После каждого числа будем ставить запятую
    a = a + 1;
}
Console.Write(N);