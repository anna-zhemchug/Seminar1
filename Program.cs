Console.Write("Введите число a: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число с: ");
int numberC = int.Parse(Console.ReadLine());
int max = numberA;
if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.WriteLine($"Максимальное число = {max}");