// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
//m=1, n=5
Console.WriteLine("Enter Numbers");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

void GetNumbers (int num1, int num2){
    if(num1 <= num2){
        Console.Write(num1 + " ");
        GetNumbers(num1 + 1, num2);
    }

    
}
GetNumbers(M,N);