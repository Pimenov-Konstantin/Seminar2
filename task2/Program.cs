// Даны два числа. Показать большее и меньшее число.
Console.WriteLine("Введите число 1: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    Console.WriteLine("Меньшее число " + number1);
    Console.WriteLine("Большее число " + number2);
}
else
{
    Console.WriteLine("Меньшее число " + number2);
    Console.WriteLine("Большее число " + number1);
}

