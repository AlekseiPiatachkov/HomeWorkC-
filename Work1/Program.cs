// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

Console.WriteLine("Напиши первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Напиши второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);

if (a > b)
  {
   Console.Write("max =");
   Console.WriteLine(a);
  }
else 
  {
   Console.Write("max =");
   Console.WriteLine(b);
  }