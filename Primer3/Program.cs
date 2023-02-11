/*
## Primer3
В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении 
которых расположен 
наименьший элемент.
*/

int rows = new Random().Next(5,10);    // количество строк
int cols = new Random().Next(5,10);    // количество столбцов

int[,] numbers_1 = new int [rows,cols];
fillmas(numbers_1);
int min_elem = numbers_1[0,0];
int min_row=0;
int min_col=0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (min_elem > numbers_1[i,j])
        {
            min_elem = numbers_1[i,j];
            min_row = i;
            min_col = j;
        }
        
    }
}
Console.WriteLine("Начальный массив ");
printmas(numbers_1);
Console.WriteLine($"Минимальное значение {min_elem} находится в ячейке {min_row},{min_col}");
int[,] numbers_2 = new int [rows-1,cols-1];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if (i == min_row || j == min_col) {}
        else
        {
            int newcol = j;
            int newrow = i;
            if (i > min_row) newrow = i-1;
            if (j > min_col) newcol = j-1;
//            Console.WriteLine($"значение {i} новое {newrow}");            
//            Console.WriteLine($"значение {j} новое {newcol}");            
            numbers_2[newrow,newcol] = numbers_1[i,j];
        }
        
    }
} 
printmas(numbers_2);
/*
while (find_num(numbers_1,min_elem))
{
    
}
*/



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
        arr[i, j] = new Random().Next(0,+100);
    }
   }
}
Boolean find_num(int[,] arr, int numm)
{
int rows = arr.GetLength(0);    // количество строк
int columns = arr.GetLength(1);        // количество столбцов
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if(numm ==  arr[i, j]) return true;
    } 
}
return false;   
}

