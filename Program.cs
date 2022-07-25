// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Домашняя работа 2
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1


int DigitThreeNum(int num)
{
    int num2 = num / 10;
    int num3 = num2 % 10;

    return num3;

}

Console.WriteLine("Input three-digit number ");
int digit = Convert.ToInt32(Console.ReadLine());

int number = DigitThreeNum(digit);
Console.WriteLine($"The second digit of {digit} is {number}");

*/


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

/*
int ThirdDigit (int digit)

{
    while (digit >= 1000) digit = digit / 10;
    digit = digit % 10;

return digit;
}


Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());

int number1 = ThirdDigit(number);
    
    if (number < 100) Console.WriteLine("There's no third digit");
    else Console.WriteLine($"The third digit is {number1}");


*/



/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*
bool Weekend(int num)
{
if (num == 6 || num == 7) return true;
else return false;
}

Console.WriteLine("Input number from 1 to 7 ");
int day = Convert.ToInt32(Console.ReadLine());

bool SomeDay = Weekend(day);
Console.WriteLine(SomeDay);
*/
