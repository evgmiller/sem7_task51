// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int [,] GetArray1( int m, int n, int minValue, int maxValue)
{
    int[,] result=new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j]= new Random().Next(minValue,maxValue);
        }
    }
    return result;
}

void GetArray2( int [,]array)
{
    int SumNum=0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            if(i==j)
            {
            SumNum=SumNum+array[i,j];
            }
        }
    }
    Console.WriteLine(SumNum);
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}  ");
            
        }
        Console.WriteLine();
    }
}

int[,] array1= GetArray1(3,4,0,10);
PrintArray(array1);
Console.WriteLine();
GetArray2(array1);
