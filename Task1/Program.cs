// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Degree(int A, int B){
    int a = A;
    for (int i = 1; i < B; i++)
    {
         a = a * A;
       // System.Console.WriteLine(a + " B циклe");
    }
       
    return a;
}

System.Console.WriteLine(Degree(2, 5));