Console.Write("Введите число a: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Ведите число b: ");
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
}
else
{
    Console.WriteLine($"max = {numberB}");
}