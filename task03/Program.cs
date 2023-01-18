/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/
int ReadAndWrite(string question)
{
    Console.WriteLine(question);
    return Convert.ToInt32(Console.ReadLine());
}
int N = ReadAndWrite("Введите длину массива:");
int[] RandomArray = new int[N];
for(int i =0; i < RandomArray.Length; i++)
{
    RandomArray[i] = new Random().Next(1, 10);
     Console.Write(RandomArray[i] + " ");
}
