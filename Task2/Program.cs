// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int GetSum(int number){
    int a = 0;
    int b = 0;
    int num = number;

    while(num / 10 > 0){
        a = a + (num % 10);
        num = num / 10;
    }
    b = a + num;

    return b;
}
System.Console.WriteLine(GetSum(9012));