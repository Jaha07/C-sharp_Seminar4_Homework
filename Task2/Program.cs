// Задача 27: Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Dellet(string[] args)
{
    Console.Write("Enter your number: ");
    int n = int.Parse(Console.ReadLine()!);
    int sum = 0;
    int temp = 0;
    {
        while (n > 0)
        {
            temp = n % 10;
            sum = sum + temp;
            n = n / 10;
        }
        Console.WriteLine($"The sum = {sum}");
    }
}
Dellet(args);
