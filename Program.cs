// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.Write("Введите длину массива = ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[size];
// for (int i = 0; i < nums.Length; i++)
//     nums[i] = new Random().Next(100, 1000);

// void FillArrayRandomNumbers(int[] nums)
// {
//     for(int i = 0; i < nums.Length; i++)
//     {
//         nums[i] = new Random().Next(100,1000);
//     }
// }

// void PrintArray(int[] nums)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < nums.Length; i++)
//     {
//         Console.Write(nums[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// FillArrayRandomNumbers(nums);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(nums);
// int count = 0;

// for (int j = 0; z < nums.Length; j++)
// if (nums[j] % 2 == 0)
// count++;

// Console.WriteLine($"дано {nums.Length} чисел, {count} из них чётные");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.Write("Введите длину массива = ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[size];
// int summa = 0;

// int RandomNumbers(int size, int min, int max)
// {
//     int summa = 0;
//     Console.Write("Получившийся массив: ");

//     for (int i = 0; i < nums.Length; i++)
//     {
//         nums[i] = new Random().Next(min, max);

//         Console.Write(nums[i] + " ");

//         if (i % 2 != 1)
//         {
//             summa = summa + nums[i];
//         }
//     }
//     return summa;
// }
// int randomNum = RandomNumbers(summa, 1, 10);
// Console.WriteLine($"сумма элементов на нечетных позициях равна {randomNum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.Write("Введите длину массива = ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] nums = new double[size];
// FillArrayRandomNumbers(nums);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(nums);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int i = 0; i < nums.Length; i++)
// {
//     if (nums[i] > max)
//         {
//             max = nums[i];
//         }
//     if (nums[i] < min)
//         {
//             min = nums[i];
//         }
// }

// Console.WriteLine($"всего {nums.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] nums)
// {
//     for(int i = 0; i < nums.Length; i++)
//     {
//         nums[i] = new Random().Next(100,1000) / 100;
//     }
// }

// void PrintArray(double[] nums)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < nums.Length; i++)
//     {
//         Console.Write(nums[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
