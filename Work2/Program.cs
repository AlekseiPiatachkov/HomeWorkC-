// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

Console.Write("  " + number1);
Console.Write("  " + number2);
Console.WriteLine("  " + number3);

int max = number1; 

if (number1 > max ) number1 = max;
if (number2 > max ) number2 = max;
if (number3 > max ) number3 = max;

Console.Write("max = ");
Console.Write(max);


