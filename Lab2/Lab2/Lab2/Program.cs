using System.Drawing;

Console.Write("Task: ");
int task = int.Parse(Console.ReadLine());

if (task == 1)
{
    Console.WriteLine("1 - One-dimensional array");
    Console.WriteLine("2 - Two-dimensional array");
    Console.Write("Which one variation: ");
    int x = int.Parse(Console.ReadLine());

    if (x == 1)
    {
        Console.Write("Send arr size: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"[{i}]: ");
            int element = int.Parse(Console.ReadLine());
            array[i] = element;
        }

        Console.Write("Send a: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("a: " + a);
        for (int i = 0; i < size; i++)
        {
            if (a < array[i])
            {
                Console.WriteLine($"[{i}] " + array[i]);
            }
        }
    }
    else if (x == 2)
    {
        Console.Write("Rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"[{i}, {j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.Write("Send a: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("a: " + a);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (a < array[i, j])
                {
                    Console.WriteLine($"[{i},{j}]: " + array[i, j]);
                }
            }
        }
    }
}

///

else if (task == 2)
{
    Console.Write("Send arr size: ");
    int size = int.Parse(Console.ReadLine());

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"[{i}]: ");
        int element = int.Parse(Console.ReadLine());
        array[i] = element;
    }

    int min = array[0];
    int max = array[0];
    int minindex = 0;
    int maxindex = 0;

    for (int i = 0; i < size; ++i)
    {
        if (array[i] < min)
        {
            min = array[i];
            minindex = i;
        }
        if (array[i] > max)
        {
            max = array[i];
            maxindex = i;
        }
    }

    Console.WriteLine("-------------");
    Console.WriteLine("Min: " + $"[{minindex}]: {array[minindex]}");
    Console.WriteLine("Max: " + $"[{maxindex}]: {array[maxindex]}");

    array[minindex] = max;
    array[maxindex] = min;

    for (int i = 0; i < size; ++i)
    {
        Console.WriteLine($"[{i}]: " + array[i]);
    }
}

///

else if (task == 3)
{
    Console.Write("Введiть n: ");
    int n = int.Parse(Console.ReadLine());

    int[,] array = new int[n, n];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"[{i}, {j}]: ");
            array[i, j] = int.Parse(Console.ReadLine());
        }
    }

    int norm = CalculateMatrixNorm(array);

    Console.WriteLine($"Норма матрицi: {norm}");
}

///

else if (task  == 4)
{
    int first, second;
    Console.Write("Interval from: ");
    first = int.Parse(Console.ReadLine());
    Console.Write("Interval to: ");
    second = int.Parse(Console.ReadLine());

    int n;
    Console.Write("Введіть кількість рядків масиву: ");
    n = int.Parse(Console.ReadLine());

    int[][] sumsArray = new int[n][];

    // Перебираємо кожен рядок східчастого масиву
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
        int m = int.Parse(Console.ReadLine());

        // Ініціалізуємо рядок зубчастого масиву для зберігання суми
        sumsArray[i] = new int[m];

        Console.WriteLine($"Введіть елементи для рядка {i + 1}: ");
        for (int j = 0; j < m; j++)
        {
            Console.Write($"Елемент {j + 1}: ");
            int element = int.Parse(Console.ReadLine());
            sumsArray[i][j] = element;
        }
    }

    // Виводимо суми елементів, що не потрапляють в заданий інтервал, для кожного рядка
    for (int i = 0; i < n; i++)
    {
        int sum = 0;
        foreach (int element in sumsArray[i])
        {
            
            if (element < first || element > second)
            {
                sum += element;
            }
        }
        Console.WriteLine($"Сума елементів, що не потрапляють в інтервал для рядка {i + 1}: {sum}");
    }
}

static int CalculateMatrixNorm(int[,] matrix)
{
    int rows = matrix.GetLength(0); // Кількість рядків матриці
    int columns = matrix.GetLength(1); // Кількість стовпців матриці

    int maxColumnSum = int.MinValue;


    for (int j = 0; j < columns; j++)
    {
        int columnSum = 0;
        for (int i = 0; i < rows; i++)
        {
            columnSum += matrix[i, j];
        }
        if (columnSum > maxColumnSum)
        {
            maxColumnSum = columnSum;
        }
    }

    return maxColumnSum;
}