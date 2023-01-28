// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

// void ChangeRow(int [,] array){

//   int temp = 0;

//   for(int i=0; i < array.GetLength(0); i++){
//     temp = array[0, i];
//     array[0, i] = array[array.GetLength(0)-1, i];
//     array[array.GetLength(0)-1, i] = temp;
//   }

// }

int [,] Transposition (int [,] array){  //Функция счетчик, которая проходит по столбцам и меняет их строки

  int [,] newArray = new int [array.GetLength(1), array.GetLength(0)];

  // Производим транспонирование
  for(int i=0; i<newArray.GetLength(0); i++)
    for(int j=0; j<newArray.GetLength(1); j++)
      newArray[i,j] = array[j,i];

  return newArray;
}

int [,] array = new int [7, 5];
FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine();

int [, ] newArray = Transposition(array);
PrintArray(newArray);