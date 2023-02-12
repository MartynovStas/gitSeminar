/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

System.Console.Write("Ведите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int zeloe = 1;
for(int i = zeloe; i<=number1; i++){
    if(i %2 == 0){
        zeloe = i;
        System.Console.Write(zeloe + " ");
    }
}
