int number = 0;
while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    else
        Console.WriteLine("Неверное число.");
}

int CheckingPalindromeNumber(int oldValue)
{
    oldValue = number;
    int newValue = 0;
    while (number > 0)
    {
        int dig = number % 10;
        newValue = newValue * 10 + dig;
        number = number / 10;
    }
    int yes = 0;
    if (newValue == oldValue)
    {
         yes = 1;
    }
    else
    {
        yes = 0;
    }
    return yes;
}
int result = CheckingPalindromeNumber(number);
if (result == 1)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}
