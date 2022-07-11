Console.Write("Введите 1-ое число для сравнения: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-ое число для сравнения: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 )
{
    Console.WriteLine($"Первое число {num1} больше второго {num2}");
}
else if (num1 < num2 )
{
    Console.WriteLine($"Второе число {num2} больше первого {num1}" );
}
else
{
    Console.WriteLine($"Числа {num1} и {num2} равны" );
}

