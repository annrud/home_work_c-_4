Console.Clear();
Console.WriteLine("Программ принимает на вход два числа (А и В)" +
              " и возводмт число А в натуральную степень В.");
Console.Write("Введите число А: ");
int numb = int.Parse(Console.ReadLine()!);
Console.Write("Введите число В: ");
int pow = int.Parse(Console.ReadLine()!);

int result = Power(numb, pow);
Console.WriteLine(result);

int Power(int number, int power)
{
    int pownumb = number;
    for (int i = 2; i <= power; i++)
    {
        pownumb *= number;
    }

    return pownumb;
}
