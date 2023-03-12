// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int n1;
int n2;
int n3;

Console.WriteLine("Введите первое число: ");
string vvod1 = Console.ReadLine()!;
n1 = int.Parse(vvod1);

Console.WriteLine("Введите второе число: ");
string vvod2 = Console.ReadLine()!;
n2 = int.Parse(vvod2);

Console.WriteLine("Введите третье число: ");
string vvod3 = Console.ReadLine()!;
n3 = int.Parse(vvod3);

int max = n1;

if (n2 > max)
  {
  max = n2;
  }
if (n3 > max)
  {
  max = n3;
  }

Console.WriteLine($"максимальное число из введенных:  {max} ");