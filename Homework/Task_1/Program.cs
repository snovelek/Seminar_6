﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


int[] numbers = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();
//У меня вопрос, получается введя массив таким образом, он получился динамическим?

int c (int [] arr){
    int cc=0;
    for (int i=0;i<arr.Length;i++)
        if(arr[i]>0)
            cc=cc+1;
    return cc;
}
System.Console.WriteLine(c(numbers));
