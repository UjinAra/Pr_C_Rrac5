// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
using static System.Console;
Clear(); 

int ReadFromConsole(string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return Convert.ToInt32(ReadLine());
}

int[] FillMass(int size)
{ 
    int []  mass = new int[size];
    int n1 = ReadFromConsole("Начальное число диапазона"); // Начало диапазона случайных чисел
    int n2 = ReadFromConsole("Конечное число диапазона"); // Конец диапазона случайных чисел
    for (int i=0 ; i < mass.Length ; i++)
        mass[i]= new Random().Next (n1,n2);
    return mass;
}

void PrintMass(int[] mass)
{
    for (int i=0 ; i < mass.Length; i++)
    Write($" {mass[i]} ");
}

int size = ReadFromConsole("Введите размер массива");
int [] mass = FillMass(size);
PrintMass(mass);

int j = 0;
for (int i=0; i<mass.Length; i++)
{
   if (mass[i]%2 == 0)
    {
        j=j+1;
    }
}
WriteLine ("");
if ( j == 0 )
{
 WriteLine ($"Нет четных чисел");
}
 else 
 {
 WriteLine ($"Количество четных чисел - {j}");
 }
