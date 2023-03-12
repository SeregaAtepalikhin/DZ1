// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет


int n;

Console.WriteLine("Введите число: ");
string vvod = Console.ReadLine()!;
n = int.Parse(vvod);
 
if (n % 2 == 0)
{
 Console.Write($"число \n {n} \n четное");
 Console.Read();
 }
 else
 {
 Console.Write($"число {n} нечетное");
 Console.Read();
}