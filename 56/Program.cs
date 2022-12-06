// 56. Написать программу копирования массива

int[] a = { 1, 2, 3, 4, 5, 56, 9 };
int[] copy = new int[a.Length];
for (int i = 0; i < a.Length; i++)
    copy[i] = a[i];
System.Console.WriteLine(string.Join(" ", copy));


