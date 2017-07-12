namespace _1.Bunker_Buster
{
    using System.Linq;
    using System;
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var row = dimensions[0];
            var col = dimensions[1];
            var matrix = new int[row][];
            
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[col];
                var matrixNumbers = Console.ReadLine().Split(new char[]{ ' ', '\t', '\n' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[i] = matrixNumbers;
            }
            var input = Console.ReadLine();
            while (input!= "cease fire!")
            {
                
                var cellsAndDamage = input.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var impactRow = int.Parse(cellsAndDamage[0]);
                var impactCol = int.Parse(cellsAndDamage[1]);
                var damage = (int)cellsAndDamage[2].FirstOrDefault();
                double damageToSides2 = Math.Ceiling((double)damage / 2);
                int damageToSides = int.Parse(damageToSides2.ToString());
                
                if (IsInMatrix(row, impactRow, impactCol, col))
                {
                    matrix[impactRow][impactCol] -= damage;
                }

                if (IsInMatrix(row, impactRow-1, impactCol-1 , col))
                {
                    matrix[impactRow-1][impactCol - 1] -= damageToSides;
                }

                if (IsInMatrix(row, impactRow -1, impactCol , col))
                {
                    matrix[impactRow-1][impactCol ] -= damageToSides;
                }

                if (IsInMatrix(row, impactRow -1, impactCol + 1, col))
                {
                    matrix[impactRow-1][impactCol+1] -= damageToSides;                    
                }

                if (IsInMatrix(row, impactRow, impactCol-1, col))
                {
                    matrix[impactRow][impactCol -1] -= damageToSides;
                }

                if (IsInMatrix(row, impactRow, impactCol+1, col))
                {
                    matrix[impactRow][impactCol +1] -= damageToSides;
                }

                if (IsInMatrix(row, impactRow+1, impactCol-1, col))
                {
                    matrix[impactRow+1][impactCol -1] -= damageToSides;
                }

                if (IsInMatrix(row, impactRow+1, impactCol, col))
                {
                    matrix[impactRow+1][impactCol ] -= damageToSides;
                }

                if (IsInMatrix(row, impactRow+1, impactCol+1, col))                
                {
                    matrix[impactRow + 1][impactCol + 1] -=  damageToSides;
                }

                input = Console.ReadLine();
            }
            double destructed = 0;
            double size = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    size++;
                    if (matrix[i][j] <= 0)
                    {
                        destructed++;
                    }
                }
            }
            var damageDone = destructed / size * 100;
            Console.WriteLine($"Destroyed bunkers: {destructed}");
            Console.WriteLine($"Damage done: {damageDone:F1} %");
         
        }

        public static bool IsInMatrix(int row, int testRow, int testCol, int columns)
        {
            if (testRow >= 0 && testRow < row && testCol >= 0 && testCol < columns)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
