// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int RezSum(int[] mass) // Сумма элементов, стоящих на нечётных позициях
{
    int summ = 0;
    for (int i=0; i<mass.Length; i=i+2)
    {
        summ =summ + mass[i] ;
    }
    return summ;
}

int size = ReadFromConsole("Введите размер массива");
int [] mass = FillMass(size);
PrintMass(mass);

int summ = RezSum(mass);

WriteLine("");
WriteLine ($"Сумма элементов, стоящих на нечётных позициях - {summ}");
