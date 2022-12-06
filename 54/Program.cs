// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
// Принять первые числа равными 0 и 1

System.Console.WriteLine("Введите число :");
int N = int.Parse(Console.ReadLine());
int next = 1;
Console.Write("0 ");

for (int i = 1; i <= N; i += next)
{
    next = i - next;
    Console.Write("{0} ", i);
}


// Посмотрел у Вас 


System.Console.WriteLine("Введите число :");
int N = int.Parse(Console.ReadLine());
int[] a = new int[N];
a[0] = 0;
a[1] = 1;
for (int i = 2; i < a.Length; i++)
{
    a[i] = a[i - 1] + a[i - 2];
}
System.Console.WriteLine(string.Join(" ", a));