Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());

int temp = 2;

while(temp <= num - 2)
{
    Console.Write(temp);
    Console.Write(", ");
    temp = temp + 2;
}
Console.Write(temp);
Console.WriteLine(".");