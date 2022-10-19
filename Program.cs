/*
// Задача 0. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindBiggestDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec) return ed;
    else return dec;
}
int RandomNumber = new Random().Next(10, 100);

int result = FindBiggestDigit(RandomNumber);
Console.WriteLine($"Biggest digit of {RandomNumber} is {result} ");
*/


/*
//Задача 1. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int CutNumber(int num)
{
    int ed = num % 10;
    int sot = num / 100;
    int result = sot * 10 + ed;
    return result;
}
int RandomNumber = new Random().Next(100, 1000);
int result = CutNumber(RandomNumber);
Console.WriteLine($"Случайное число {RandomNumber}");
Console.WriteLine($"Искомое число {result}");
*/


/*
//Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратно первому. Если не кратно - выводит остаток от деления.

void IsDivisionable(int num1, int num2)
{
    if (num2 % num1 == 0) Console.WriteLine("Второе число кратно первому");
    else Console.WriteLine($"Остаток от деления второго числа на первое = {num2 % num1}");
}

Console.Write("Input first number -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number -> ");
int num2 = Convert.ToInt32(Console.ReadLine());

IsDivisionable(num1, num2);
*/

/*
//Задача 3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно и 7, и 23.

bool TrueOrFalse(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    return true;
    else return false;
}
Console.Write("Input number -> ");
int num = Convert.ToInt32(Console.ReadLine());

bool IsDivisionable = TrueOrFalse(num);
Console.WriteLine(IsDivisionable);
*/



//Задача 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

void QuadNumber(int num1, int num2)
{
    if (num2 == num1 * num1) Console.WriteLine("Второе число есть квадрат первого");
    else Console.WriteLine("Квадратом не является");
}
Console.Write("Input first number -> ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number -> ");
int num2 = Convert.ToInt32(Console.ReadLine());

QuadNumber(num1, num2);
