//int[] points = { 12, 7, 15, 4, 9 };

//int sum = 0;

//foreach (int point in points)
//{
//    sum += point;
//}

//Console.WriteLine($"Общая сумма баллов: {sum}");

//int[] points = { 10, 20, 5, 15, 30, 8 };
//int sum = 0;
//foreach (int point in points) ;
//sum += point;

//int[] points = { 60, 80, 90, 70, 100  };

//int sum = 0;

//foreach (int point in points)
//{
//    sum += point;
//}

//double average = (double)sum / points.Length;

//Console.WriteLine($"Сумма: {sum}");
//Console.WriteLine($"Количество: {points.Length}");
//Console.WriteLine($"Среднее значение: {average:F2}");

// int[] points = { 60, 80, 90, 70, 100 };
// double average = sum / points.Length;

//int[] temperatures = { 18, 7, 23, 4, 15, 9 };

// int min = temperatures[0];
// int max = temperatures[0];

// for (int i = 1; i < temperatures.Length; i++)
// {
//     if (temperatures[i] < min)
//    {
//        min = temperatures[i];
//     }

//     if (temperatures[i] > max)
//    {
//        max = temperatures[i];
//     }
// }

// Console.WriteLine($"Минимум: {min}");
// Console.WriteLine($"Максимум: {max}");


int[] numbers = { 7, 12, 4, 9, 18, 21, 6, 15 };

int sum = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum += number;
    }
}

Console.WriteLine($"Сумма чётных чисел: {sum}");


