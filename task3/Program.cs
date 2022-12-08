/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine()??"");
if (number < 1 || number > 7)
{
    Console.WriteLine($"Не существует дня недели с номером {number}");
}
else
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да, это выходной");
    }
    else 
    {
        Console.WriteLine("Нет, это не выходной");
    }    