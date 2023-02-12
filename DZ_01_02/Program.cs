/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2 && number2 < number3)
{
    System.Console.WriteLine("Max = " + number3);
}
else if (number1 > number2 && number1 > number3)
{
    System.Console.WriteLine("Max = " + number1);
}
else if (number1 == number2 && number2 < number3)
{
    System.Console.WriteLine("Max = " + number3);
}
else if (number2 == number3 && number2 < number1)
{
    System.Console.WriteLine("Max = " + number1);
}
else
{
    System.Console.WriteLine("Max = " + number2);
}