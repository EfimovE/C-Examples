// Console.WriteLine("Введите число.");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int square = num1*num1;
// Console.Write($"Квадрат числа {num1} равен {square}.");


Console.WriteLine("Введите 1-ое число и нажмите Enter.");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число и нажмите Enter.");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == num1*num1)
    {
        Console.Write($"Число {num2} является квадратом числа {num1}.");
    }
else
    {
       Console.Write($"Число {num2} НЕ является квадратом числа {num1}."); 
    }
