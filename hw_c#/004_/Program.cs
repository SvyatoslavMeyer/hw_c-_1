// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

int a, b, c;
Console.WriteLine("Введите три числа : ");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("{0} наибольшее число ", max);