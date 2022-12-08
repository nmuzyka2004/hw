/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()??"");
number = Math.Abs(number);

if (number < 100)
{
    Console.WriteLine($"В этом числе третьей цифры нет"); 
}    
else
{
    string numberStr = Convert.ToString(number);
    Console.WriteLine($"Третьей цифрой этого числа является"+
        $" цифра {numberStr[2]}"); 
}