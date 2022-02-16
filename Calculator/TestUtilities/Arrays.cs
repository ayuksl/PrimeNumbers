using Utilities;
using System;




public class Arrays
{
    public static void Main(string[] args)
    {
        string[] names = { "hamit", "ahmet", "lucy" };
        string[] cities = new string[]
            {"berlin", "hamburg", "erfurt"};
        Console.WriteLine("Anzahl Namen: {0}", names.Length);
        //System.Arrays.
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
        Console.WriteLine(names[0]);
        //GreetPeople(names);
        //GreetPeople(cities);
        //Ex08(names);
        //Ex09();
        //Ex10();
        //WriteTable(Ex11());
        //WriteTable(new int[2, 3]
        //{
        //   {5,6,7 },
        //   {8,9,10}
        //});
        //WriteTable(Ex12());
        //WriteTable(new int[4, 2]
        //{
        //{1,2},
        //{3,4},
        //{5,6},
        //{7,8},
        //});

        //Ex14
        //IsIdentityMatrix(int[,] matrix);

        //Ex15
        WriteTable(Ex15());
        //WriteTable(new int[4, 2]
        //{
        //{1,2},
        //{3,4},
        //{5,6},
        //{7,8},
        //});

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
            Console.Write(name + " -> " + StringUtils.Reverse(name));
            if (StringUtils.IsPalindrome(name) == true)
            {
                Console.WriteLine(" (Palindrom)");
            }
            else
            {
                Console.WriteLine();
            }
        }

    }

    public static void Ex09()
    {
        Console.WriteLine("Bitte geben Sie eine nummer ein:");
        string eingabe = Console.ReadLine();
        int z = int.Parse(eingabe);
        int[] arrayz = new int[z];
        for (int i = 0; i < z; i++)
        {
            //int[] arrayz[i] = i * i;
            Console.WriteLine("Zahlen[{0}] = {1}", i, i * i);
            //arrayz[i] = i*i;
        }

    }

    public static void Ex10()
    {
        Console.WriteLine("Bitte geben Sie eine nummer  für Multiplikationtabelle ein:");
        string eingabe = Console.ReadLine();
        int z = int.Parse(eingabe);
        //int[] arrayz = new int[z];
        for (int i = 1; i < z + 1; i++)
        {
            for (int y = 1; y < z + 1; y++)
            {
                //int[] arrayz[i] = i * i;
                Console.Write("{0,4} * {1,4} = {2,4}, ", i, y, i * y);


                //arrayz[i] = i * i;
            }
            Console.WriteLine();
        }


    }
    //public static int[,] Ex11()
    //{
    //    //Console.WriteLine("Bitte geben Sie eine nummer  für Multiplikationtabelle ein:");
    //    //string eingabe = Console.ReadLine();
    //    //int z = int.Parse(eingabe);
    //    int[,] table = new int[10, 10];
    //    for (int i = 1; i < 10 + 1; ++i)
    //    {
    //        for (int y = 1; y < 11; y++)
    //        {
    //            //arrayz[i, y] = i * y;
    //            table[i - 1, y - 1] = i * y;


    //            //arrayz[i] = i * i;
    //        }


    //    }
    //    return table;





    //}

    //public static void WriteTable(int[,] table)
    //{
    //    int rowCount = table.GetLength(0);
    //    int columnCount = table.GetLength(1);
    //    foreach (int row in Enumerable.Range(0, rowCount))
    //    {
    //        foreach (int column in Enumerable.Range(0, columnCount))
    //        {
    //            Console.Write("{0,4}", table[row, column]);

    //        }
    //        Console.WriteLine();
    //    }
    //}

    //public static int[,] Ex12()
    //{
    ////Console.WriteLine("Bitte geben Sie eine nummer  für Multiplikationtabelle ein:");
    ////string eingabe = Console.ReadLine();
    ////int z = int.Parse(eingabe);
    //int[,] table = new int[10, 10];
    //for (int i = 1; i < 10 + 1; ++i)
    //{
    //for (int y = 1; y < 11; y++)
    //{
    ////arrayz[i, y] = i * y;
    //table[i - 1, y - 1] = i * y;


    ////arrayz[i] = i * i;
    //}


    //}
    //return table;





    //}

    //public static void WriteTable(int[,] table)
    //{
    //int rowCount = table.GetLength(0);
    //int columnCount = table.GetLength(1);
    //int arrayCount = table.GetLength(2);
    //foreach (int row in Enumerable.Range(0, rowCount))
    //{
    //foreach (int column in Enumerable.Range(0, columnCount))
    //{
    //foreach (int arrayc in Enumerable.Range(0, arrayCount))
    //{
    //Console.Write("{0,4}", table[row, column]);

    //}
    //Console.WriteLine();
    //}
    //}
    //}

    //Ex13
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

    //Ex14

    //public static bool IsIdentityMatrix(int[,] matrix)
    //{
    //Console.WriteLine("Bitte geben Sie eine Matrixgröße ein: ");
    //string eingabe = Console.ReadLine();
    //int z = int.Parse(eingabe);
    //int rowCount = z;
    //int columnCount = z;

    //foreach (int row in Enumerable.Range(0, rowCount))
    //{
    //foreach (int column in Enumerable.Range(0, columnCount))
    //{

    //Console.Equals("{0,4}", matrix[row, column]);


    //}
    //Console.WriteLine();
    //}



    //}


    //public static bool IsIdentityMatrix(int[,] matrix)
    //{
    //int rows = matrix.GetLength(0);
    //int columns = matrix.GetLength(1);
    //if (rows != columns)
    //{
    //return false;
    //}
    //for (int row = 0; row < rows; ++row)
    //{
    //for (int column = 0; column < columns; ++column)
    //{
    //int cell = matrix[row, column];
    //if (row == column && cell != 1)
    //{
    //return false;
    //}
    //else if (row != column && cell != 0)
    //{
    //return false;
    //}
    //}
    //}
    //return true;
    //}

    public static int  Ex15();
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

}