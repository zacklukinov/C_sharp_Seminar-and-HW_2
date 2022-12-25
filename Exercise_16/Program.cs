//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7, соответствующее дню недели: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine ("Неправильный ввод");
} 
if (number/6 == 1)
{
    Console.WriteLine("Выходной!");
}
else
{
Console.WriteLine("Рабочий день");
} 
