// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
using static System.Console;
Clear(); 

int ReadFromConsole(string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return Convert.ToInt32(ReadLine());
}

int[] FillMass(int size) // Ввод массива
{ 
    int []  mass = new int[size];
    int n1 = ReadFromConsole("Начальное число диапазона"); // Начало диапазона случайных чисел
    int n2 = ReadFromConsole("Конечное число диапазона"); // Конец диапазона случайных чисел
    for (int i=0 ; i < mass.Length ; i++)
        mass[i]= new Random().Next (n1,n2);
    return mass;
}
void PrintMass(int[] mass) // Вывод массива
{
    for (int i=0 ; i < mass.Length; i++)
    Write($" {mass[i]} ");
}
int [] MinMax(int[] mass) // Находим min max
{
    int [] RezMinMax = new int [2];
    RezMinMax [0]= mass[0]; // min
    RezMinMax [1]= mass [0]; // max
    for (int i=0; i<mass.Length; i++)
    {
        if (RezMinMax[0]>mass[i])
        {
            RezMinMax[0]=mass[i];
        }
        if (RezMinMax[1]<mass[i])
        {
            RezMinMax[1]=mass[i];
        }
    }
    return RezMinMax;
}

int size = ReadFromConsole("Введите размер массива");
int [] mass = FillMass(size);
PrintMass(mass);

int[] RezMinMax = MinMax(mass);

WriteLine("");
WriteLine ($"Минимальное число - {RezMinMax[0]}  Максимальное число - {RezMinMax[1]}");
WriteLine ($"Min Max - {RezMinMax[1] - RezMinMax[0]}");