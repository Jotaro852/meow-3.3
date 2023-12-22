
using System;
using System.IO; 

class work_3_3
{
    static void Main()
    {
        string line = File.ReadAllText("input.txt"); // чтение данных из файла
        string[] lineArray = line.Split(' '); // разбираем строку на числа
        int[] arrayNumbers = Array.ConvertAll(lineArray, int.Parse); // преобразуем в числа массива

        int max = 0; // max S
        int left = 0; // Индекс левой линии
        int right = arrayNumbers.Length - 1; // Индекс правой линии

        // S контейнера
        while (left < right)
        {
            int area = Math.Min(arrayNumbers[left], arrayNumbers[right]) * (right - left); // вычисляем площадь

            if (area > max) // S = max?
            {
                max = area; // присваиваем
            }

            if (arrayNumbers[left] < arrayNumbers[right])
            {
                left++; // добавляем
            }
            else
            {
                right--; // отнимаем
            }
        }
        Console.WriteLine($"Площадь контейнера: {max}"); // вывод
    }
}