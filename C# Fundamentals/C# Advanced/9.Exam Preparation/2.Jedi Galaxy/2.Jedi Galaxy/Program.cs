namespace _2.Jedi_Galaxy
{
    using System;
    using System.Linq;
    class Program
    {       
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrixRows = dimensions[0];
            var matrixCols = dimensions[1];
            var galaxy = new int[matrixRows][];
            int stars = 0;
            for (int i = 0; i < galaxy.Length; i++)
            {
                galaxy[i]= new int[matrixCols];
                for (int j = 0; j < galaxy[i].Length; j++)
                {
                    galaxy[i][j] = stars;
                    stars++;
                }
            }
            var ivoCordinates = Console.ReadLine();
            var ivoTokens = ivoCordinates.Split().Select(int.Parse).ToArray();
            int ivoRow = ivoTokens[0];
            int ivoCol = ivoTokens[1];
            int starsCollected = 0;
            var evilForces = Console.ReadLine();
            while (true)
            {
                
                ivoTokens = ivoCordinates.Split().Select(int.Parse).ToArray();
                ivoRow = ivoTokens[0];
                ivoCol = ivoTokens[1];

                var evilForcesCord = evilForces.Split().Select(int.Parse).ToArray();
                var evilForcesRow = evilForcesCord[0];
                var evilForcesCol = evilForcesCord[1];

                EvilForcesContributeToGalaxy(galaxy,evilForcesRow,evilForcesCol,matrixRows,matrixCols);
                starsCollected += IvoCollectingStars(galaxy, ivoRow, ivoCol, matrixRows, matrixCols, evilForcesRow,evilForcesCol);
                RisingStars(galaxy, evilForcesRow, evilForcesCol, matrixRows, matrixCols);
                ivoCordinates = Console.ReadLine();
                if (ivoCordinates == "Let the Force be with you")
                {
                    break;                    
                }
                evilForces = Console.ReadLine();
            }
            
            Console.WriteLine(starsCollected);
        }

        private static void RisingStars(int[][] galaxy, int evilForcesRow, int evilForcesCol, int matrixRows, int matrixCols)
        {
            while (evilForcesRow >= 0 && evilForcesCol >= 0)
            {
                if (IsInMatrix(matrixRows, evilForcesRow, evilForcesCol, matrixRows))
                {
                    galaxy[evilForcesRow][evilForcesCol] = (matrixRows+1) * (matrixCols+1)-1;
                }
                evilForcesRow--;
                evilForcesCol--;
            }
        }

        private static int IvoCollectingStars(int[][] galaxy, int ivoRow, int ivoCol, int matrixRows, int matrixCols,int evilRow,int evilCol)
        {
            int starsCollected = 0;
            while (ivoRow >= 0 && ivoCol < matrixCols)
            {
                if (IsInMatrix(matrixRows, ivoRow, ivoCol, matrixCols) && (evilRow-ivoRow)!=(evilCol-ivoCol))
                {
                    starsCollected += galaxy[ivoRow][ivoCol];
                }
                ivoRow--;
                ivoCol++;
            }
            return starsCollected;
        }
        private static void EvilForcesContributeToGalaxy(int[][] galaxy, int evilForcesRow, int evilForcesCol, int rows, int cols)
        {

            while (evilForcesRow >= 0 && evilForcesCol >= 0)
            {
                if (IsInMatrix(rows, evilForcesRow, evilForcesCol, cols))
                {
                    galaxy[evilForcesRow][evilForcesCol] = 0;
                }
                evilForcesRow--;
                evilForcesCol--;
            }
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
