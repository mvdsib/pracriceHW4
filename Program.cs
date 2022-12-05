// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string s_N = Console.ReadLine();
int N = Convert.ToInt32(s_N);

int i = 0;
for(i = 1; i <= N; i++)
{
if(i % 2 == 0)
{
    System.Console.WriteLine($"i = {i} ");
}
else
{
    Console.WriteLine("Нет подходящих значений");  
}
}

