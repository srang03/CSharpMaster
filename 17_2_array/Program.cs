namespace _17_2_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1차원 배열
            int[] _1DimensionalNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // 2차원 배열
            int[,] _2DimensionalNumbers = { { 0, 1 }, { 2, 3 }, { 4, 5 }, { 6, 6 }, { 8, 9 } };

            for (int i = 0; i < _2DimensionalNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < _2DimensionalNumbers.GetLength(1); j++)
                {
                    Console.WriteLine(_2DimensionalNumbers[i, j]);
                }
            }

            // 가변 배열
            //int[][] tempNumbers = new int[5][2]; 
            int[][] tempNumbers = new int[5][];

            tempNumbers[0] = new int[] { 0, 1 };
            tempNumbers[1] = new int[] { 2, 3, 4 };
            tempNumbers[2] = new int[] { 5 };
            tempNumbers[3] = new int[] { 6, 7 };
            tempNumbers[4] = new int[] { 8, 9 };

            for (int i = 0; i < tempNumbers.Length; i++)
            {
                for (int j = 0; j < tempNumbers[i].Length; i++)
                {
                    Console.WriteLine(tempNumbers[i][j]);
                }
            }

            int[][,] superNumbers = new int[3][,];
            superNumbers[0] = new int[2, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 }
               };
            superNumbers[1] = new int[3, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
               };
            superNumbers[2] = new int[3, 3] {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 }
               };

            for (int i = 0; i < superNumbers.Length; i++)
            {
                for (int j = 0; j < superNumbers[i].GetLength(0); i++)
                {
                    for(int k = 0; k < superNumbers[i].GetLength(1); k++)
                    {
                        Console.WriteLine(superNumbers[i][j,k]);
                    }
                }
            }

            Staff[] staff = new Staff[5];
            for(int i = 0; i < staff.Length; i++)
            {
                staff[i] = new Staff($"Staff {i}");
            }
              
        }
    }
    class Staff
    {
        string name;
        public Staff(string name)
        {
            this.name = name;
        }
    }
}