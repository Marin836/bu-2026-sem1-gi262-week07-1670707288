using System;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public int[] LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == target)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }

                if (row != -1)
                    break;
            }

            return new[] { row, col };
        }

        public int LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;

                if (array[middle] == target)
                {
                    index = middle;
                    break;
                }
                else if (array[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return index;
        }

        #endregion

        #region Assignment

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int first = -1;
            int last = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (first == -1)
                    {
                        first = i;
                    }

                    last = i;
                }
            }

            if (first == -1)
            {
                return new[] { -1 };
            }

            return new[] { first, last };
        }

        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            int max = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < target)
                {
                    if (max == -1 || array[i] > max)
                    {
                        max = array[i];
                    }
                }
            }

            return max;
        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
            System.Collections.Generic.List<int> result =
                new System.Collections.Generic.List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min && array[i] <= max)
                {
                    result.Add(array[i]);
                }
            }

            return result.ToArray();
        }

        #endregion

        #region Extra

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            System.Collections.Generic.List<int> result =
                new System.Collections.Generic.List<int>();

            for (int i = 0; i < enemyHPs.Length; i++)
            {
                if (enemyHPs[i] <= mana)
                {
                    result.Add(enemyHPs[i]);
                    mana -= enemyHPs[i];
                }
            }

            return result.ToArray();
        }

        #endregion
    }
}