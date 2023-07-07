// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int dayOfWeek = int.Parse(Console.ReadLine());
int n = dayOfWeek;
if (n >= 1 && n <= 7)
    {
    if (n == 6 | n == 7) Console.WriteLine($"Сегодня выходной");
        else Console.WriteLine($"Сегодня рабочий день");
    }
else Console.WriteLine("Неверное число");
