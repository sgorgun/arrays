using System;

namespace WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {
            return array[..];
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            return array[1..];
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            return array[2..];
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            return array[3..];
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            return array[..^1];
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            return array[..^2];
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            return array[..^3];
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            return array[1..^1];
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            return array[2..^2];
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            return array[3..^3];
        }
    }
}
