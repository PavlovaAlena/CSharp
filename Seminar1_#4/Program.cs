Console.Write("Введите 1-ое число для сравнения: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-ое число для сравнения: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3-е число для сравнения: ");
int num3 = Convert.ToInt32(Console.ReadLine());

//Первый вариант решения
int maxN = num1;

if (num2 > num1)
{
    maxN = num2;
}    
if (num3 > maxN)
{
    maxN = num3;
}
Console.WriteLine($"Максимальное число {maxN}");

//Второй вариант решения
/* int maxN = Math.Max(Math.Max(num1, num2), num3);
Console.WriteLine($"Максимальное число {maxN}"); */

//Третий вариант решения
/* if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"Максимальное число {num1}");
}
else if (num2 > num3)
{
    Console.WriteLine($"Максимальное число {num2}");
}
else
{
    Console.WriteLine($"Максимальное число {num3}");
}
 */

//Четвертый вариант решения
/* int maxN = num2 > num1 ? num2 : num1;
maxN = maxN > num3 ? maxN : num3;
Console.WriteLine($"Максимальное число {maxN}"); */