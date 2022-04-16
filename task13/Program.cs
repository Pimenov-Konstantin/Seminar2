// Введите число
Console.WriteLine("Введите число: ");
// В пепеменную а сохраняется число из консоли
string a = Console.ReadLine();
Third(a);
// Вызов метода

void Third(string number)
    {
        if (number.Length < 3)
        {
            Console.WriteLine("Повторите попытку. Введите трехзначное или более число ");
        }
        else
        {
            Console.WriteLine(number[2]);
        }
    }
