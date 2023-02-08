// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B. Реализовать функцию возведения в степень
// самостоятельно!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Extent(int a, int b)
{
    int result = 1;
    for (int count = 1; count <= b; count++)
    {
        result = result * a;
    }
    return result;
}
int ReadConsole(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine()!);
}
Console.Clear();
int a = ReadConsole("Enter number A: ");
int b = ReadConsole("Enter number B: ");
int pow = Extent(a, b);
Console.Write(pow);
