Console.Clear();
Console.WriteLine("Программа принимает на вход число и " +
                  "выдаёт сумму цифр в числе.");
Console.Write("Введите число: ");
int numb = int.Parse(Console.ReadLine()!);

int result = SumDigit(numb);
Console.WriteLine(result);

int SumDigit(int number)
{
    int digit = number % 10;
    while (number > 9)
    {
        number /= 10;
        digit += number % 10;
    }

    return digit;
}                