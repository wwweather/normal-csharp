/* Условие задачи:

Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1,7 -> такого числа в массиве нет */

double[,] GenerateTDArray(int RowsNum, int ColumnsNum, double minValue, double maxValue)
{
   for (int i = 0; i < RowsNum; i++)
   for (int j = 0; j < ColumnsNum; j++)
    
   { WorkArray[i,j] = Convert.ToDouble(random.Next(minValue, maxValue)/10.0)}
   
   return WorkArray;

}

double EMinValue = -1000;
double EMaxValue = 1000;

Console.WriteLine("Введите количество строк двумерного массива для решения задачи:");
int ERowsNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива для решения задачи:");
int EColumnsNum = Convert.ToInt32(Console.ReadLine());

int EWorkArray = GenerateTDArray(ERowsNum, EColumnsNum, EMinValue, EMaxValue);

int attempts=0;

while (attempts < 21) // Требуется дополнительное условие завершения программы.
{
    Console.WriteLine("Введите позицию элемента этого двумерного массива в формате (поочередно номер строки и столбца):");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
 
    if (x>ERowsNum && y>EColumnsNum)
 
    Console.WriteLine("В данном двумерном массиве нет элемента на такой позиции!");
    else
 
    {

    object a = EWorkArray.GetValue(x,y);
    Console.WriteLine("На этой позиции находится следующий элемент массива:" + a);
    attempts++
    }
} 

break

