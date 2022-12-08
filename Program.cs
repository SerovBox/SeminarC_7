// //Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] Create2dArray(int row, int column, int minVal, int maxVal) //создание 2х мерного массива
{
    int[,] Created2dArray = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            Created2dArray[i,j] = new Random().Next(minVal, maxVal + 1);
    return Created2dArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");   //вывод значений
        }
        Console.WriteLine();    // переход на новую строку
    }
    Console.WriteLine();       // отступ от массива
}

Console.Write("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray(rows, columns, min, max);
Show2dArray(newArray);
*/

//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/*
int[,] Create2dArray(int row, int column)
{
    int[,] Created2dArray = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            Created2dArray[i,j] = i+j;
    return Created2dArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");  
        }
        Console.WriteLine();    
    }
    Console.WriteLine();       
}
Show2dArray(Create2dArray(5, 6));
*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//и замените эти элементы на их квадраты.
/*
int[,] Create2dArray(int row, int column, int minVal, int maxVal) 
{
    int[,] Created2dArray = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            Created2dArray[i,j] = new Random().Next(minVal, maxVal + 1);
    return Created2dArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");   
        }
        Console.WriteLine();   
    }
    Console.WriteLine();    
}

int[,] EvenNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}

int[,] Created2dArray = Create2dArray(5,6,-5,10);
Show2dArray(Created2dArray);
EvenNumbers(Created2dArray);
Show2dArray(Created2dArray);
*/

//Найти сумму элементов главной диагонали
/*
int[,] Create2dArray(int row, int column, int minVal, int maxVal) 
{
    int[,] Created2dArray = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            Created2dArray[i,j] = new Random().Next(minVal, maxVal + 1);
    return Created2dArray;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {    
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");   
        }
        Console.WriteLine();   
    }
    Console.WriteLine();    
}

int SumNumber(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                sum = sum + array[i, j];
            }
        }
    }
    return sum;
}

int[,] newArray = Create2dArray(5, 7, 5, 10);
Show2dArray(newArray);
int sum = SumNumber(newArray);
Console.Write($"The sum of elements {sum}");
*/

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
void ArrayRandomRealNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + ": ");
        }
        Console.WriteLine("");
    }
}
Console.WriteLine("Input number of rows:  ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
ArrayRandomRealNumbers(numbers);
ShowArray(numbers);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив: 
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17 -> такого числа в массиве нет
/*
void Create2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 100);
            }   
        }
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + ": ");
        }   
        Console.WriteLine(" "); 
    }
}
Console.WriteLine("Input line: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column: ");
int c = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5, 5];
Create2dArray(numbers);

if (l > numbers.GetLength(0) || c > numbers.GetLength(1))
{
    Console.WriteLine("There is no such element -> -");
}
else
{
    Console.WriteLine($"element value {l} Line & {c} Column = {numbers[l-1, c-1]}");
}
ShowArray(numbers);
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
void Create2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 100);
            }   
        }
}
Console.WriteLine("Input line: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input column: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[line, column];
Create2dArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / line;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
*/

