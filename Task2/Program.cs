// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Введите строку элемента:  ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец элемента: ");
int columns = Convert.ToInt32(Console.ReadLine());

int n = 4;
int m = 4;

int[,] array = new int[n,m];

for (int i = 0; i < array.GetLength(0); i++)
{
  for (int j = 0; j < array.GetLength(1); j++)
  {
    array[i,j] = new Random().Next(1,10);
    Console.Write(array[i,j] + " ");
  }
  Console.WriteLine();
}

if(rows < 0 | rows > array.GetLength(0)-1 | columns < 0 | columns > array.GetLength(1)-1)
{
  Console.WriteLine("Такого элемента не существует");
}
else
{
  Console.WriteLine("Значение элемента массива = {0}", array[rows,columns]);
}
