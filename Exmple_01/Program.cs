//  Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

using System;
class IntArray
{
    static void Main()
{

  int[] array = new int[10];
  Random nums = new Random();
  for (int i = 0; i < array.Length; i++)
{
 array[i] = nums.Next(20, 90);
 Console.Write("* " + array[i] + " ");
}
Console.Write("! ");
}

}