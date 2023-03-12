// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8 


int n = 0;

Console.WriteLine("Введите число: ");
string vyvod = Console.ReadLine()!;
n = int.Parse(vyvod);

int num = 2;


while (num <=n)
{
  if (num+1>=n)
    Console.Write($"{num}");
  else
    Console.Write($"{num}, ");
  num +=2;
  
}


