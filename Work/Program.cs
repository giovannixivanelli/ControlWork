Console.WriteLine("Введите элементы массива через пробел:");
string[] input = Console.ReadLine().Split(' ');

Console.WriteLine("Первоначальный массив:");
for (int i = 0; i < input.Length; i++)
{
    Console.Write(input[i] + " ");
}

Console.WriteLine();

int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= 3)
    {
        count++;
    }
}

if (count > 0)
{
    string[] output = new string[count];
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            output[index] = input[i];
            index++;
        }
    }

    Console.WriteLine("Новый массив:");
    for (int i = 0; i < output.Length; i++)
    {
        Console.Write(output[i] + ' ');
    }
}

else
{
    Console.WriteLine("Массив не получился. Все элементы содержат больше 3-х символов.");
}