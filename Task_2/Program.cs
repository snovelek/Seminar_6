// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите число");
int n= Convert.ToInt32(Console.ReadLine());

void FI (int N){
    if (N>=1){
        
        FI(N/2);
        Console.Write(N%2);
    }
    else
    return;
}
FI(n);