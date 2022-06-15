// Программа которая принимает на вход число и показывает 3 цирфу этого числа, еслии ее нет, то выводит "Третьей цифры нет"
Console.WriteLine("Введите число  ");
int Namber = Convert.ToInt32(Console.ReadLine());

if (Namber > 99 & Namber <= 999)
{
    int result = Namber % 10;
    Console.WriteLine(result);
}
if (Namber > 999)
{
    int result2 = Namber % 100;
    int result3 = result2 / 10;
    Console.WriteLine(result3);
}

if (Namber <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}