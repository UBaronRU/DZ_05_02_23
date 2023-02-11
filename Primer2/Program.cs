/*
## Primer2
Найти произведение двух матриц
*/

int rows = new Random().Next(5,10);    // количество строк
int cols = new Random().Next(5,10);    // количество столбцов

int[,] numbers_1 = new int [rows,cols];
int[,] numbers_2 = new int [rows,cols];
int[,] numbers_3 = new int [rows,cols];

fillmas(numbers_1);
fillmas(numbers_2);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        numbers_3[i,j] = numbers_1[i,j]*numbers_2[i,j];
    }
}
Console.WriteLine("Начальные массивы ");
Console.WriteLine("Массив 1 ");
printmas(numbers_1);
Console.WriteLine("Массив 1 ");
printmas(numbers_2);
Console.WriteLine("Произведение");
printmas(numbers_3);



void printmas(int[,] arr)
{
int rows = arr.GetLength(0);    // количество строк
int columns = arr.GetLength(1);        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{arr[i, j]} \t");
    }
    Console.WriteLine();
}
}
void fillmas(int[,] arr)
{
int rows = arr.GetLength(0);    // количество строк
int columns = arr.GetLength(1);        // количество столбцов
 
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = new Random().Next(-10,+10);
    }
   }
}