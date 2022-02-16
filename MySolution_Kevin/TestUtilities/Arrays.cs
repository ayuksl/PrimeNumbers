using Utilities;

public class Arrays
{
    public static void Main(string[] args)
    {
        string[] names = { "hamit", "ahmet", "lucy" };
        //    string[] cities = new string[3] 
        //        { "berlin", "hamburg", "erfurt" };
        //    Console.WriteLine("Anzahl Namen: {0}", names.Length);
        //    Console.WriteLine(names[1]);
        //    Console.WriteLine(names[2]);
        //    Console.WriteLine(names[0]);

        //    GreetPeople(names);
        //    GreetPeople(cities);

        //Ex08(new string[] { "otto", "johannes", "karl", "micha" });
        //Ex08(names);
        //Ex09();

        //WriteTable(Ex11());
        //WriteTable(new int[2, 3]
        //{
        //    { 5, 6, 7 },
        //    { 8, 9, 10 }
        //});

        //int[,,] table = new int[3, 3, 4]
        //{
        //    {
        //        {1,2,3,4},
        //        {5,6,7,8},
        //        {1,2,3,4},
        //    },
        //    {
        //        {9,8,7,6},
        //        {5,4,3,2},
        //        {1,0,0,1},
        //    },
        //    {
        //        {1,0,1,0},
        //        {0,1,0,1},
        //        {1,0,1,0},
        //    },
        //};

        //Write3DData(table);

        //Console.WriteLine(IsIdentityMatrix(new int[1, 1] { { 1 } }));
        //Console.WriteLine(IsIdentityMatrix(new int[2, 2] { { 1, 0 }, { 0, 1 } }));
        //Console.WriteLine(IsIdentityMatrix(new int[2, 2] { { 1, 1 }, { 0, 1 } }));
        //Console.WriteLine(IsIdentityMatrix(new int[2, 2] { { 2, 0 }, { 0, 1 } }));
        //Console.WriteLine(IsIdentityMatrix(new int[3, 2] { { 1, 0 }, { 0, 1 }, { 0, 1 } }));

        SumTable(5, 3);
    }

    public static void GreetPeople(string[] people)
    {
        foreach (string name in people)
        {
            Console.WriteLine($"Hallo {name}");
        }
    }

    public static void Ex08(string[] names)
    {
        foreach (string name in names)
        {
            string suffix = string.Empty;
            if (StringUtils.IsPalindrome(name))
            {
                suffix = "(Palindrom)";
            }

            Console.WriteLine(
                "{0} -> {1} {2}",
                name, StringUtils.Reverse(name), suffix);
        }
    }

    public static void Ex09()
    {
        Console.Write("Bitte Zahl eingeben: ");
        string line = Console.ReadLine();
        int n = int.Parse(line);

        int[] numbers = null;
        numbers = new int[n];

        for (int i = 0; i < n; ++i)
        {
            numbers[i] = i * i;
            Console.WriteLine(
                "zahlen[{0}] hat den Wert {1}",
                i, numbers[i]);
        }
    }

    public static void Ex10()
    {
        for (int zeile = 1; zeile <= 10; ++zeile)
        {
            for (int spalte = 1; spalte <= 10; ++spalte)
            {
                Console.Write("{0,-4:D2}", zeile * spalte);
            }
            Console.WriteLine();
        }
    }

    public static int[,] Ex11()
    {
        int[,] table = new int[10, 10];

        for (int row = 1; row <= 10; ++row)
        {
            for (int column = 1; column <= 10; column++)
            {
                table[row - 1, column - 1] = row * column;
            }
        }

        return table;
    }

    public static void WriteTable(int[,] table)
    {
        int rowCount = table.GetLength(0);
        int columnCount = table.GetLength(1);

        foreach (int row in Enumerable.Range(0, rowCount))
        {
            foreach (int column in Enumerable.Range(0, columnCount))
            {
                Console.Write("{0,4}", table[row, column]);
            }

            Console.WriteLine();
        }
    }

    public static void Write3DData(int[,,] table)
    {
        foreach (int tableNumber in Enumerable.Range(0, table.GetLength(0)))
        {
            Console.WriteLine($"\nTable {tableNumber}\n");
            foreach (int row in Enumerable.Range(0, table.GetLength(1)))
            {
                foreach (int column in Enumerable.Range(0, table.GetLength(2)))
                {
                    Console.Write("{0, 4}", table[tableNumber, row, column]);
                }
                Console.WriteLine();
            }
        }
    }

    // Ex14
    public static bool IsIdentityMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        if (rows != columns)
        {
            return false;
        }

        for (int row = 0; row < rows; ++row)
        {
            for (int column = 0; column < columns; ++column)
            {
                int cell = matrix[row, column];

                if (row == column && cell != 1)
                {
                    return false;
                }
                else if (row != column && cell != 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static int[,] Ex13()
    {
        return new int[4, 2]
        {
            { 1, 2, },
            { 3, 4, },
            { 5, 6, },
            { 7, 8, },
        };
    }

    // Ex15
    public static void SumTable(int rows, int columns)
    {
        int[][] table = new int[rows][];
        const int numberWidth = 10;
        string numberFormat = $"{{0,{numberWidth}}}"; // {0,-5}

        // Header
        Console.Write(new String(' ', Math.Abs(numberWidth)));
        foreach (int column in Enumerable.Range(1, columns))
        {
            Console.Write(numberFormat, column);
        }
        Console.WriteLine();

        // Table
        foreach (int rowIndex in Enumerable.Range(0, table.Length))
        {
            table[rowIndex] = new int[columns];
            Console.Write(numberFormat, rowIndex + 1);
            
            foreach (int columnIndex in Enumerable.Range(0, table[rowIndex].Length))
            {
                int sum = table[rowIndex][columnIndex] = rowIndex + 1 + columnIndex + 1;
                Console.Write(numberFormat, sum);
            }

            Console.WriteLine();
        }
    }
}