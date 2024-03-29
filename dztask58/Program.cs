﻿// метод для заполне­ния двумерного масси­ва
int[,] FillTwoDimArray(int countRow, int countColumn)
{
      System.Random numberSyntezator = new System.Random();
      int i = 0;
      int j = 0;
      int[,] outArray = new int[countRow, countColumn];
      while (i < countRow)
      {
            j = 0;
            while (j < countColumn)
            {
                  outArray[i, j] = numberSyntezator.Next(0, 101);
                  j++;
            }
            i++;
      } 
      return outArray;
}
ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkCyan, ConsoleColor.DarkRed, ConsoleColor.Gray, ConsoleColor.Blue, ConsoleColor.Green };

  
void PrintColorTwoDimArray(int[,] inputArray)
{
      int i = 0; int j = 0;
  
      while (i < inputArray.GetLength(0))
      {
            j = 0;
            while (j < inputArray.GetLength(1))
            {
                  Console.ForegroundColor = col[new System.Random().Next(0, 7)];
                  Console.Write(inputArray[i, j] + "\t");
                  Console.ResetColor();
                  j++;
            }
            Console.Write("\n");
         
            i++;
      }
}

int[,] Multi(int[,] oneArray, int[,] secondArray) // метод перемножает матрицы. При этом, сразу проверяет условие умножения.
{
            if (oneArray.GetLength(1) != secondArray.GetLength(0)) throw new Exception("Матрицы нельзя перемножить"); //проверяет условие для умножения, в противном случае выдает инфу, что матрицы нельзя премножить
            int[,] r = new int[oneArray.GetLength(0), secondArray.GetLength(1)];
            for (int i = 0; i < oneArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    for (int k = 0; k < secondArray.GetLength(0); k++)
                    {
                        r[i,j] += oneArray[i,k] * secondArray[k,j];
                    }
                }
            }
            return r;
        }

void Print(int[,] a)  //печатает массив, где хранится результат умножения (специально не цветной)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    
//вызывваем методы. 
int[,] arrayA = FillTwoDimArray(2,4);
PrintColorTwoDimArray(arrayA);  // заполняет и печатает первую матрицу
int[,] arrayB = FillTwoDimArray(4,2);
PrintColorTwoDimArray(arrayB);// заполняет и печатает вторую матрицу
int[,] x = Multi(arrayA, arrayB); // перемножаем матрицы
Print(x); //печатаем массив с результатом

