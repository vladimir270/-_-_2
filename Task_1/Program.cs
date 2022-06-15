// Программа принимает на вход трехзначное число и на выходе показывает 2 цифру этого числа 
Console.WriteLine("Введите трехназчное число  ");
int Namber = Convert.ToInt32(Console.ReadLine());

int result = Namber / 10;
int result2 = result % 10;

Console.WriteLine(result2);