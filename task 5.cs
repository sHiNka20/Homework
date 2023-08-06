Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.Write("Третья цифра :");
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
