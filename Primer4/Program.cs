/*
## Primer4
Сформировать трехмерный массив не повторяющимися двузначными числами 
показать его построчно на экран выводя индексы соответствующего элемента
*/
// 4*4*4 = 64
int rows = new Random().Next(1,4);    // количество строк
int cols = new Random().Next(1,4);    // количество столбцов
int deph = new Random().Next(1,4);    // количество массивов
int[,,] numbers = new int [rows,cols,deph];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        for (int o = 0; o < deph; o++)
        {
            int num_post = new Random().Next(10,99);
            while (find_num(numbers,num_post))
            {
                num_post = new Random().Next(10,99);
            }
            numbers[i,j,o] = num_post;
        }
    }
}
            Console.WriteLine($" Сформирован массив {rows},{cols},{deph}");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        for (int o = 0; o < deph; o++)
        {
            Console.WriteLine($" значение {numbers[i,j,o]} находится в ячейке {i},{j},{o}");
        }
    }
            Console.WriteLine();
}

Boolean find_num(int[,,] arr, int numm)
{
int rows = arr.GetLength(0);    // количество строк
int columns = arr.GetLength(1);        // количество столбцов
int depth = arr.GetLength(2);        // количество столбцов
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int o = 0; o < depth; o++)
        {
        if(numm ==  arr[i, j, o]) return true;
        }
    } 
}
return false;   
}