// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());
x = Math.Abs(x); //Возвращает абсолютное значение числа
if(99 < x & x < 1000)
{
    int thirdDigit = x % 10;
    Console.WriteLine($"Третья цифра числа {x} -> {thirdDigit}");
}
else if(x < 100)
{
   Console.WriteLine("Третьей цифры нет");
}
else if(x > 999)
{
    int k = x;
    while(k >999)
    {
        k = k / 10;
    }
    int thirdDigit = k % 10;
    Console.WriteLine($"Третья цифра числа {x} -> {thirdDigit}");
}
