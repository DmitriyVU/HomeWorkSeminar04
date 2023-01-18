/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

void Procedura(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($" {a}  в степени {b}  = {result}");
}
int ReadAndWrite(string question)
{
    Console.WriteLine(question);
    return Convert.ToInt32(Console.ReadLine());
}
int numberA = ReadAndWrite("Введите число: ");
int numberB = ReadAndWrite("Введите степень: ");
Procedura(numberA, numberB);
