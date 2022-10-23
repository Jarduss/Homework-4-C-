/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число 'a', которое будет возводиться в степень b");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое будет возводить число 'а' в степень 'b' ");
int b = Convert.ToInt32(Console.ReadLine());
int Res(int a, int b)
{
    int result = 1;
for ( int i = 1; i <= b; i++)
    {
    result = result * a;
    }
    return result;
}
int resul = Res(a, b);
Console.WriteLine("Ответ: " + resul);