/*
## Primer5
Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

 Треугольник Паскаля — это числовая бесконечная таблица, в которой по краям стоят единицы, 
 а каждое число внутри равно двум стоящим над ним в ближайшей строке сверху
*/
int i;
int j;
int storona =new Random().Next(2,10);
for (i = 0; i < storona; i++)
            {
                for (j = 0; j <= (storona - i); j++) 
                {
                    Console.Write(" "); 
                }
                for (j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                    Console.Write(factorial(i) / (factorial(j) * factorial(i - j))); 
                }
                Console.WriteLine();
                Console.WriteLine(); 
            }
float factorial(int n)
{
    float i, x = 1;
    for (i = 1; i <= n; i++)
        {
        x *= i;
        }
    return x;
}