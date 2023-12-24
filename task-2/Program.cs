// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Enter Numbers");
int intM = Convert.ToInt32(Console.ReadLine());
int intN = Convert.ToInt32(Console.ReadLine());

double akkermanFun(double M, double N){
    if(M == 0){
        return N + 1;
    } else if(M != 0 && N == 0){
        return akkermanFun(M - 1, 1);
    } else return akkermanFun(M - 1, akkermanFun(M, N -1));
}

Console.WriteLine(akkermanFun(intM, intN));