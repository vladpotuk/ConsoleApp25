using System;

public class MyModel
{
    public static int GetProductInRange(int start, int end)
    {
        int product = 1;
        for (int i = start; i <= end; i++)
        {
            product *= i;
        }
        return product;
    }

    public static bool IsPerfectSquare(int x)
    {
        int s = (int)Math.Sqrt(x);
        return (s * s == x);
    }

    public static bool IsFibonacci(int n)
    {
        return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
    }

    public static void SortArray(int[] array, string sortOrder)
    {
        int temp;
        for (int write = 0; write < array.Length; write++)
        {
            for (int sort = 0; sort < array.Length - 1; sort++)
            {
                if (sortOrder == "asc")
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
                else if (sortOrder == "desc")
                {
                    if (array[sort] < array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
        }
    }
}
