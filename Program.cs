// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int Method(int num)
{
    int detachFirstAndThirdFigure = num % 100 / 10;
    return detachFirstAndThirdFigure;
}

Console.WriteLine("Input a three-digit number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = Method(number);
    Console.WriteLine("The second figure of this number is:");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("It is a wrong number! Input a three-digit number.");
}
*/


// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int determineThirdNumber(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    return num;
}
Console.WriteLine("Input a number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99) 
{
    int result = determineThirdNumber(number);
    Console.WriteLine("The third figure of this number is:");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("It is a wrong number! This number have not a third figure. Enter a number greater than 99.");
}
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool identifyWeekendOrNot(int day)
{
    bool a = true;

    if (day > 0 && day < 6) 
    {
        a = false;
    }
    else
    {
        a = true;
    }
    return a;
}

Console.WriteLine("Input a day of week as a number:");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());
if (dayOfWeek < 7 && dayOfWeek > 1)
{
    bool weekendOrNot = Convert.ToBoolean(identifyWeekendOrNot(dayOfWeek));
    if (weekendOrNot == true) 
        {
            Console.WriteLine("It is a weekend!");
        }
    else
        {
            Console.WriteLine("It is a working day.");
        }
}
else
{
    Console.WriteLine("It is a wrong number! Enter the number from 1 to 7.");
}
*/