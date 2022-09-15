//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.Clear();

Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 == num2*num2)
{
    Console.WriteLine("ДА");
}
else
    Console.WriteLine("НЕТ");




//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

    Console.Clear();

    Console.WriteLine("Введите число: ");
    int week = int.Parse(Console.ReadLine());
        if (week == 1)
        Console.WriteLine("Понедельник");
        else if (week == 2)
        Console.WriteLine("Вторник");
        else  if (week == 3)
        Console.WriteLine("Среда");
        else  if (week == 4)
        Console.WriteLine("четверг");
        else  if (week == 5)
        Console.WriteLine("Пятница");
        else if (week == 6)
        Console.WriteLine("суббота");
        else if (week == 7)
        Console.WriteLine("Воскресенье");
    else {
            Console.WriteLine("Неверный ввод");
        }

/* switch (num)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("Нет такого дня недели.");
        break ;
}
 */