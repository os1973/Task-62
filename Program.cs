/*
Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
*/

private static int[,] GetSpire(int n)
{
    var result = new int[n, n];
    for (int currentChar = 1, padding = 0; padding < n/2; padding++)
    {
        for (int j = padding; j < n - padding; j++)
            result[padding, j] = currentChar;
        for (int j = padding; j < n - padding; j++)
            result[n - padding - 1, j] = currentChar;
        for (int i = padding + 2; i < n - padding - 1; i++)
            result[i, padding] = currentChar;
        for (int i = padding + 1; i < n - padding - 1; i++)
            result[i, n - padding - 1] = currentChar;
            currentChar = 1 - currentChar;
            result[padding + 1, padding] = currentChar;
    }
    if (n%2 != 0 && result[0, 0] == 1)
    {
        result[n/2, n/2] = 1;
    }
            return result;
}
