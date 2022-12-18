/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/* 
class Program
{
  public static void Main(string[] args)
  {
     Console.WriteLine("Введите количество строк: ");
     int rowCount= Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите количество столбцов: ");
     int columnCount = Convert.ToInt32(Console.ReadLine());
     int[,] array= new int[rowCount,columnCount];
     ArrayOfNumbers(array);
     Console.WriteLine("Исходный массив элементов: ");  
     PrintArray(array);
   
 
  void ArrayOfNumbers (int [,] array)
   {
        for (int i=0; i< array.GetLength(0); i++)
          {
            for(int j=0; j< array.GetLength(1);j++)
             {
               array[i,j]=new Random().Next(0,10);
             }
          }
    }


 void SortArrayOfNumber(int [,] array)
   { 
     for (int i = 0; i < array.GetLength(0); i++)
        {
          for (int j = 0; j < array.GetLength(1); j++)
           {
             for (int q = 0; q < array.GetLength(1) - 1; q++)
               {
                 if (array[i, q] < array[i, q + 1]) 
                  {
                    int temp = 0;
                    temp = array[i, q];
                    array[i, q] = array[i, q + 1];
                    array[i, q + 1] = temp;
                  }
               }
            }
         }
   }  

Console.WriteLine("Массив после сортировки: ");
SortArrayOfNumber(array); 


void PrintArray(int[,]array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}");
        }
        Console.WriteLine(" ");

    }
}

PrintArray(array);

     }
 } 

 */


/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

/*  
class Program
{
   public static void Main( string[] args)
   {
      Console.WriteLine("Введите количество строк: ");
       int rowCount =Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите количество столбцов: ");
       int columnCount = Convert.ToInt32(Console.ReadLine());
       int[,] array =ArrayOfNumber(rowCount,columnCount,0,10);
       Console.WriteLine($"Строка с наименьшей суммой элементов = {GetSumRow(array)} строка");

       int[,] ArrayOfNumber (int row, int column, int min,int max)
       {
        int[,] result = new int[row,column];
        for (int i=0; i<column; i++)
        {
            for(int j=0; j<row;j++)
            {
                result[i,j]=new Random().Next(min,max+1);
            }
        }
       return result;
   }

void PrintArray(int[,]array)
{
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();

    }
}

int GetSumRow(int[,] array)
{
    int minSum = 0;
    int row =0;
    for( int i =0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0,i];
    }
    for (int i=1; i<array.GetLength(0);i++)
    {
        int sum= 0;
        for (int j = 0; j< array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        while ( minSum > sum)
        {
            minSum = sum;
            row = i;
        }
    }
    return row;
}

PrintArray(array);

    }
}
  */



/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

/* 
class Program
{
    public static void Main (string[] args)
    {
        Console.Write("Введите количество строк массива 1: ");
        int row1 =Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива 1: ");
        int column1 =Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество строк массива 2: ");
        int row2 =Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов массива 2: ");
        int column2 =Convert.ToInt32(Console.ReadLine());

        int[,] array1 = ArrayOfNumber(row1,column1,0,10);
        int[,] array2 = ArrayOfNumber(row2,column2,0,10);

        int[,] ArrayOfNumber(int row,int column, int min, int max)
        {
            int[,]result = new int[row, column];
            for(int i=0; i < row; i++)
            {
                for( int j =0; j < column; j++)
                {
                    result[i,j]= new Random().Next(min, max+1);
                }
            }
            return result;
        }

  void PrintArray(int[,] Array)
  {
     for(int i=0; i< Array.GetLength(0); i++)
     {
        for( int j =0; j< Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}  ");
        }
        Console.WriteLine();
     }
  }

     int [,] GetMatrix(int[,] array1, int[,] array2)
     {
         int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
         for (int i=0; i < array1.GetLength(0); i++ )
         {
             for (int j=0; j < array1.GetLength(1); j++ )
             {
                 for (int q =0;  q < array1.GetLength(1); q++ )
                 {
                    array3[i,j]+=  array1[i,q] * array2[q,j];
                 }
             }
         }
         return array3;
     }


PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
PrintArray(GetMatrix(array1,array2));

    }


}  
 */




/* 
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/* 
class Program
 {
  public static void Main (string[] args)
   {
        Console.WriteLine("Введите размеры массива: ");
        string[] number = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[,,] array = ArrayOfNumbers(new int[] { int.Parse(number[0]), int.Parse(number[1]), int.Parse(number[2]), }, 10, 99);
      

        int[,,] ArrayOfNumbers(int[] size, int min, int max)
        {
            int[,,] result = new int[size[0], size[1], size[2]];
            for (int i = 0; i < result.GetLength(0); i++)
             {
                 for (int j = 0; j < result.GetLength(1); j++)
                 {
                   int q = 0;
                 if (q < result.GetLength(2))
                   {
                     int element = new Random().Next(min, max + 1);
                     if (GetElement(result, element)) continue;
                     {result[i, j, q] = element;
                     q++;
                     }
                   }
                 }
             }
            return result;
        }


        bool GetElement(int[,,] array, int element)
         {
            for (int i = 0; i < array.GetLength(0); i++)
              {
                 for (int j = 0; j < array.GetLength(1); j++)
                  {
                    for (int q = 0; q < array.GetLength(2); q++)
                      {
                         if (array[i, j, q] == element) return true;
                      }
                  }
              }
           return false;
         }


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int q = 0; q < array.GetLength(2); q++)
            {
                Console.Write($"{array[i, j, q]} ({i},{j},{q}) ");
            }
            Console.WriteLine();

         }
    }
}

PrintArray(array);

  }
} 

 */


/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

/* 
class Program 
{
  public static void Main (string[] args) 
  {
      Console.WriteLine("Введите размер массива: ");
      int size = Convert.ToInt32(Console.ReadLine());
      int[,] array = GetSpiralArray(size);
      PrintArray(array);


    int[,] GetSpiralArray(int size)
    {
      int [,] result = new int[size, size];
         int temp = 1;
         int i = 0;
         int j = 0;          
        while (temp <= size * size)
         {
            result[i,j]=temp;
            if (i <= j + 1 && i + j < size - 1)
             {
                 ++j;
             }
            else if (i < j && i + j >= size - 1)
             {
                 ++i;
             }
            else if (i >= j && i + j > size - 1)
              {
                 --j;
              }
            else
            {  --i;
            ++temp;
            }
         }
         return result;
    }


    void PrintArray(int[,] array)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
      }
    }
     PrintArray(array);
  }
} */