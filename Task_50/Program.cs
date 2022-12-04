// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console. WriteLine ("Введите размеры массива");
Console.Write("Количество строк: ");
int m = Convert. ToInt32(Console. ReadLine ());
Console.Write("Количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n]; 

Console.WriteLine("Массив:");

Random random = new Random(); 
for (int i = 0; i < array.GetLength(0); i++) 
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
{
     array[i, j] = random.Next(0, 20); 
     Console.Write("{0} ", array[i, j]); 
}
    Console.WriteLine(); 
} 

Console.Write("Введите номер строки: "); 
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1; 
Console.Write("Введите номер столбца: "); 
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1; 

    if (pos1 < 0 | pos1 > array.GetLength(0) - 1 | pos2 < 0 | pos2 > array.GetLength(1) - 1) 
{ 
    Console.WriteLine("Данного элемента не существует"); 
}
    else 
{ 
    Console.WriteLine("Значение элемента массива = " + array[pos1, pos2]); 
} 