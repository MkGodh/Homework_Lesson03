// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

using System;

class Program
{
  static void Main()
  {
        Random rnd = new Random();
        double[] array = Enumerable.Range(0, 10).Select(x => rnd.NextDouble() * 10 - 5).ToArray();
        
        double minValue = array.Min();
        double maxValue = array.Max();

        double difference = maxValue - minValue;

        Console.WriteLine("Мин. элемент: " + minValue);
        Console.WriteLine("Макс. элемент: " + maxValue);
        Console.WriteLine("Разница: " + difference);
  }
}