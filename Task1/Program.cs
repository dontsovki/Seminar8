// Задача 53: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку
// массива.


void PrintArray(int[,] matr) // Создание матрицы
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,100);
        }
    }
}

void ChangeRow(int [,] array){ // Функция меняет местами первую и последнюю строку
// массива

  int temp = 0;

  for(int i=0; i < array.GetLength(0); i++){
    temp = array[0, i];
    array[0, i] = array[array.GetLength(0)-1, i];
    array[array.GetLength(0)-1, i] = temp;
  }

}


int [, ] array = new int [5, 5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

ChangeRow(array);
PrintArray(array);