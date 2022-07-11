Console.Write("Введите число, для вывода четных чисел от 1 до указанного: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 1)
{
    for (int i = 2; i <= num1; i += 2)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine($"- четныe числа от 1 до {num1}");
}
else
{
    Console.WriteLine($"Число {num1} меньше первого четного числа 2");
}