Console.Clear();
Console.WriteLine("Программа принимает на вход 8 чисел " +
                  "и выводит их на экран в виде массива.");
Console.Write("Введите числа через запятую (,): ");
string[] input = Console.ReadLine()!.Split(',');
while (input.Length < 8)
{
    Console.WriteLine("Вы ввели менее 8 цифр или не поставили " +
                      "разделительный знак - запятую.");
    Console.Write("Введите числа через запятую (,): ");
    input = Console.ReadLine()!.Split(',');
}
PrintArray(CreateArray(input));

void PrintArray(int[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length-1)
            Console.Write(", ");
    }

    Console.WriteLine("}");
}


int[] CreateArray(string[] numbers)
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = int.Parse(numbers[i]);
    }

        return array;
}  
                 