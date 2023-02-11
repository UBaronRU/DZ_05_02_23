/*
## Primer1
Составить частотный словарь элементов двумерного массива
*/
int rows = new Random().Next(5,10);    // количество строк
int cols = new Random().Next(5,10);    // количество столбцов
Console.WriteLine(rows);
Console.WriteLine(cols);
int[] numbers_full = new int [rows*cols];
int[,] numbers = new int [rows,cols];
fillmas(numbers);
Console.WriteLine("Начальный массив");
printmas(numbers);
Convert_to_string_mass(numbers, numbers_full);
printmas_line(numbers_full);
Sort_string_mass(numbers_full);
Console.WriteLine("Сортированный массив");
printmas_line(numbers_full);
int coun_1 = 1;
int temp_1 = 1;
Console.WriteLine();
for (int i = 0; i < numbers_full.Length; i=i+temp_1)
{
    temp_1 = 1;
    for (int j = i+1; j < numbers_full.Length; j++)
    {
        if (numbers_full[i] == numbers_full[j])
        {
        coun_1++;
        temp_1 = coun_1;
        }
        else break;
    }
    Console.WriteLine($"{numbers_full[i]} встречается {coun_1} раз");
    coun_1 = 1;
}

Console.WriteLine("Введите строку символов");
string stroka;
stroka = Console.ReadLine();
int[] simvol = new int[stroka.Length]; 
for (int i = 0; i < stroka.Length; i++) 
        { 
            simvol[i] = (int)stroka[i]; 
        } 
printmas_line(simvol);
Sort_string_mass(simvol); 
Console.WriteLine();
for (int i = 0; i < simvol.Length; i=i+temp_1)
{
    temp_1 = 1;
    for (int j = i+1; j < simvol.Length; j++)
    {
        if (simvol[i] == simvol[j])
        {
        coun_1++;
        temp_1 = coun_1;
        }
        else break;
    }
    Console.WriteLine($"{(char)simvol[i]} встречается {coun_1} раз");
    coun_1 = 1;
}


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
void printmas_line(int[] arr)
{
int rows = arr.GetLength(0);    // количество строк
for (int i = 0; i < rows; i++)
{
        Console.Write($"{arr[i]} \t");
}
}
void Convert_to_string_mass(int[,] arr, int[] arr_s)
{
int rows = arr.GetLength(0);    // количество строк
int columns = arr.GetLength(1);        // количество столбцов
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr_s[i*columns+j] = arr[i,j];
    }
   }
}
void Sort_string_mass(int[] arr)
{
int rows = arr.GetLength(0);    // количество строк
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows-1; j++)
    {
        if(arr[j] > arr[j+1])
        {
            int temp = arr[j];
            arr[j] = arr[j+1];
            arr[j+1] = temp;
        } 
    }
   }
}