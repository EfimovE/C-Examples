// Console.WriteLine("Введите число.");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int square = num1*num1;
// Console.Write($"Квадрат числа {num1} равен {square}.");


// Console.WriteLine("Введите 1-ое число и нажмите Enter.");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2-ое число и нажмите Enter.");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 == num1*num1)
//    {
//        Console.Write($"Число {num2} является квадратом числа {num1}.");
//    }
// else
//    {
//        Console.Write($"Число {num2} НЕ является квадратом числа {num1}."); 
//    }

Console.WriteLine("Введите номер (от 1 до 7) дня недели и нажмите Enter.");
int numday = Convert.ToInt32(Console.ReadLine());
if (numday == 1)
{
    Console.Write($"Выбранный день недели номер {numday} - Понедельник.");
}
else if (numday == 2)
{
    Console.Write($"Выбранный день недели номер {numday} - Вторник.");
}
else if (numday == 3)
{
    Console.Write($"Выбранный день недели номер {numday} - Среда.");
}
else if (numday == 4)
{
    Console.Write($"Выбранный день недели номер {numday} - Четверг.");
}
else if (numday == 5)
{
    Console.Write($"Выбранный день недели номер {numday} - Пятница.");
}
else if (numday == 6)
{
    Console.Write($"Выбранный день недели номер {numday} - Суббота.");
}
else if (numday == 7)
{
    Console.Write($"Выбранный день недели номер {numday} - Воскресенье.");
}
else
{
    Console.Write($"Выбранный день недели номер {numday} - не подпадает в диапазон.");
}
