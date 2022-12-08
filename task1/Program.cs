/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1n
*/
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()??"");
int DigitTwoOfNumber = number / 10 - (number / 100) * 10;
Console.WriteLine($"Второй цифрой числа {number}"+
    $" является {DigitTwoOfNumber}");   