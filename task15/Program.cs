Console.WriteLine(" Task 15 ");
string Weekend(int dayNumber)
{
if ((dayNumber == 6) | (dayNumber == 7))
{
    return dayNumber + "   Yes   ";
}
if ((dayNumber >= 1) & (dayNumber <= 5))
{
    return dayNumber + "   No   ";
}
else
{
    return "       Дня недели с таким номером не существует       ";
}
}
try
{
Console.Write("     Введите номер дня недели     ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Weekend(dayNumber));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}