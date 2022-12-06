// // 51. С клавиатуры вводится число N. Затем вводятся N чисел.
// // Определить сколько чисел больше 0 введено с клавиатуры


// // Без подпрограмм 

System.Console.WriteLine("Введите кол-во чисел : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
System.Console.WriteLine("Введите числа :");
int f = 0;

for (int i = 0; i < a.Length; i++)
{
    a[i] = int.Parse(Console.ReadLine());
    if (a[i] > 0) f++;
}

System.Console.Write("[{0}]", String.Join(", ", a));
System.Console.WriteLine();
System.Console.WriteLine(f);


// С подпрограммами  Подскажите, как можно (нужно-ли) этот код упростить? 

System.Console.WriteLine("Введите кол-во чисел : ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите числа :");
int f = 0;

int[] ArrayFilling(int n)
{
    int[] a = new int[n];
    for (int i = 0; i < a.Length; i++)
        a[i] = int.Parse(Console.ReadLine());
    return a;
}

void Print(int[] a)
{
    System.Console.Write("[{0}]", String.Join(", ", a));
}


int[] a = ArrayFilling(n);
foreach (int el in a)
    if (el > 0) f++;

Print(a);
System.Console.WriteLine();
System.Console.WriteLine(f);

