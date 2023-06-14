// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    System.Console.WriteLine("Большее число: " + numberA);
    System.Console.WriteLine("Меньшее число: " + numberB);
}
else if (numberA < numberB)
{
    System.Console.WriteLine("Большее число: " + numberB);
    System.Console.WriteLine("Меньшее число: " + numberA);
}
else
{
    System.Console.WriteLine("Числа равны");
}