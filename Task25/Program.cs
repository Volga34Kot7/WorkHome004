// Задача 25: Напишите цикл, который принимает на вход два числа (А и В) и возводит число А 
// в натуральную степень В
// 3,5 -> 243(3)
//2,4 -> 16

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = 1;
int SumNumbers(int numA, int numB)
{
    for(int i=1; i <= numB; i++)
    {
        result = result * numA;
    }

    return result;
}

int sumNumbers = SumNumbers(numA, numB);
Console.WriteLine($"{numA} ^ {numB} = " + sumNumbers);

