//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
//Решается через  цикл + надо учесть отрицательные значения

int num_3lgt = 0;
while (num_3lgt.ToString().Length < 3)
{
    Console.WriteLine("Введите трёхзначное число: ");
    try
    {
        num_3lgt = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Конец программы!");
        break;
    }
    if (num_3lgt.ToString().Length < 3)
    {
        Console.WriteLine("Число не трёхзначное!");
    }
    else
    {
        int num_3 = 0;
        while (num_3lgt.ToString().Length >= 3)
        {
            num_3 = num_3lgt % 10;
            num_3lgt = num_3lgt / 10;
        }
        Console.WriteLine($"Третья цифра в числе ==> {num_3}");
        break;
    }
}