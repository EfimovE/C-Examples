// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = -num;
// while (count <= num)
// {
//     Console.Write($"{count}, ");
//     count++;
// }

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 100 && a < 999)
{
    Console.Write($"Последняя цифра числа {a} = {a % 10} ");
}
else
{
    Console.Write($"Вы ввели НЕ трехзначное число!");
}