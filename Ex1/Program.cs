int a = 4;
int b = 4;

int max = a;
int min = b;

if (a > b) max = a; min = b;
if (b > a) max = b; min = a;


Console.Write("Максимальное число = ");
Console.WriteLine(max);
Console.Write("Минимальное число = ");
Console.WriteLine(min);

if (a == b) Console.WriteLine("Данные числа равны между собой"); // Импровизация, чтобы выдавался результат и в этом случае.
