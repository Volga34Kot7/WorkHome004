// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


Console.WriteLine("Введите массив чисел: ");
int[] array = new int [8];
int count = array.Length;
int MultNumbers = 0;
while(MultNumbers < count)
{
    array[MultNumbers] = Convert.ToInt32(Console.ReadLine());
    MultNumbers++;
}
for (int i=0; i<count; i++)
{
    Console.Write(array[i]);
}
Console.WriteLine();