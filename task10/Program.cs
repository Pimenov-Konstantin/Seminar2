Console.WriteLine("Task 10: ");
int number = 123;
Reverce(number); //Вызов метода

void Reverce( int currentNumber) //Создание метода
{
int a = currentNumber/100;
int b = currentNumber%100/10;
int c = currentNumber%10;
Console.WriteLine(c * 100 + b * 10 + a);
}