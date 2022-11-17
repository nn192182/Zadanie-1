//  Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Дорогой пользователь напишите число N ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num /2 ;

while (current < 1);
{
    Console.Write(current +" ");
    current++;
}