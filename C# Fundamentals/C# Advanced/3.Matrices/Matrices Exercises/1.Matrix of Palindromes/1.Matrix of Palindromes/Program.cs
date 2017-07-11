﻿using System;
using System.Linq;

public class MatrixOfPalindromes
{
    public static void Main()
    {
        var inputParams = Console.ReadLine()
            .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var r = inputParams[0];
        var c = inputParams[1];

        var stringMatrix = new string[inputParams[0]][];

        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        for (int row = 0; row < stringMatrix.Length; row++)
        {
            for (int col = row; col <r; col++)
            {
                stringMatrix[col] = new string[c];

                for (int rowcol = 0; rowcol < stringMatrix[row].Length; rowcol++)
                {
                    stringMatrix[col][rowcol] = $"{alphabet[row]}" + $"{alphabet[rowcol + row]}" + $"{alphabet[row]}";
                }
            }
        }

        for (int row = 0; row < stringMatrix.Length; row++)
        {
            for (int col = 0; col < stringMatrix[row].Length; col++)
            {
                Console.Write($"{stringMatrix[row][col]} ");
            }
            Console.WriteLine();
        }
    }
}