/* Условие задачи:
...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

using System.Linq;

int[,,] GenerateXYZArray(int FirstDim, int SecDim, int ThirdDim, int minValue, int maxValue)
{
    for (int i = 0; i < FirstDim; i++)
        for (int j = 0; j < SecDim; j++)
            for (int k = 0; k < ThirdDim; k++)

        WorkArray[i,j,k] = random.Next(minValue, maxValue)

   return WorkArray;
}

int x = InputNumbers("Введите первое измерение трёхмерного массива: ");
int y = InputNumbers("Введите второе измерение трёхмерного массива: ");
int z = InputNumbers("Введите третье измерение трёхмерного массива: ");

int EMinValue = 10;
int EMaxValue = 99;

int EWorkArray = GenerateXYZArray(x, y, z, EMinValue, EMaxValue);

Console.WriteLine("Имеется трёхмерный массив, состоящий из следующих элементов (в скобках указано положение элементов):");

    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
            Console.Write(EWorkArray[i,j,k]+({i},{j},{k}));

break
