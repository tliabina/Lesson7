//Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет


Console.Write("Введите кол-во столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());


int [,] matrix = new int[rows,columns];

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i,j]= new Random().Next(1,10);
    Console.Write(matrix[i,j]+" ");
  }
  Console.WriteLine();
}
Console.WriteLine("____________");


//bool found = false;
int count = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    if(matrix[i,j] == n)
    {
      Console.WriteLine("Заданное значение находится в ячейке " + i + ',' + j);
      //found = true;
      count++;  
    }
  }  
}

//if (!found)
if(count > 0)
{
  Console.WriteLine("Найдено значений " + count);
}
else
{
  Console.WriteLine("Такого числа в массиве нет");
}

