// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] FillArray(int count = 5, int leftRange = 100, int rightRange = 1000)
// {
//     Random rand = new Random();
//     int[] tempArray = new int[count];
//     for (int i = 0; i < tempArray.Length; i++)
//         tempArray[i] = rand.Next(leftRange, rightRange);
//     return tempArray;
// }

// void PrintArray(int[] tempArray)
// {
//     Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
// }

// int FindCountPositivNumber(int[] tempArray)
// {
//     int count = 0;
//     for (int i = 0; i < tempArray.Length; i++)
//         if (tempArray[i] % 2 == 0)
//             count++;
//     return count;
// }

// int[] array = FillArray(5);
// PrintArray(array);

// System.Console.WriteLine($"Четных чисел в массиве: {FindCountPositivNumber(array)}");







// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] FillArray(int count = 5, int leftRange = 0, int rightRange = 10)
// {
//     Random rand = new Random();
//     int[] tempArray = new int[count];
//     for (int i = 0; i < tempArray.Length; i++)
//         tempArray[i] = rand.Next(leftRange, rightRange);
//     return tempArray;
// }

// void PrintArray(int[] tempArray)
// {
//     Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
// }

// int SumElemets (int[] tempArray)
// {
//     int sum = 0;
//     for (int i = 1; i < tempArray.Length; i+=2)
//          sum += tempArray[i];
//     return sum;
// }

// int[] array = FillArray(5);
// PrintArray(array);

// System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumElemets(array)}");





// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] FillArray(int count = 5, int leftRange = 0, int rightRange = 100)
// {
//     Random rand = new Random();
//     double[] tempArray = new double[count];
//     for (int i = 0; i < count; i++)
//         tempArray[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 3);
//     return tempArray;
// }

// void PrintArray(double[] tempArray)
// {
//     Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
// }

// void PrintResult(double tempArray)
// {
//     Console.WriteLine("[" + string.Join(", ", tempArray) + "]");
// }

// double Difference(double[] randomArray)
// {
//     double min = randomArray[0];
//     double max = randomArray[0];
//     int i = 0;
//     while (i < randomArray.Length)
//     {
//         if (max < randomArray[i])
//         {
//             max = randomArray[i];
//         }
//         if (min > randomArray[i])
//         {
//             min = randomArray[i];
//         }
//         i = i + 1;
//     }
//     return max - min;
// }

// double[] array = FillArray(5);
// PrintArray(array);
// PrintResult(Difference(array));
