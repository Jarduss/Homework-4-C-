/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sum(int num)
{
    int count = Convert.ToString(num).Length;
    int last_num = 0;
    int result = 0;
    for (int i = 0; i< count; i++)
    {
        last_num = num - num % 10;
        result = result + (num - last_num);
        num = num/10;
    }
     return result;
}
int summ = sum(num);
Console.WriteLine("Сумма цифр в числе: " + summ);