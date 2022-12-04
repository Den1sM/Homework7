// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console. WriteLine ("Введите размеры массива");
Console.Write("Количество строк: ");
int m = Convert. ToInt32(Console. ReadLine ());
Console.Write("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double[m, n]; 

Console.WriteLine("Массив:");

Random random = new Random(); 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
{
     array[i, j] = Math.Round(random.NextDouble()*100,2); 
     Console.Write("{0} ", array[i, j]); 
}
    Console.WriteLine(); 
} 