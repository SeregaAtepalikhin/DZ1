// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8 


int n = 0;

Console.WriteLine("Введите число: ");
string vvod = Console.ReadLine()!;
n = int.Parse(vvod);

int delenie = 2;


while (delenie <=n)
{
  if (delenie+1>=n)
    Console.Write($"{delenie}");
  else
    Console.Write($"{delenie}, ");
  delenie +=2;
  
}


