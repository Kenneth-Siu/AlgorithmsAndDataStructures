namespace SortingAlgorithms
{
    internal class SelectionSorter
    {
        public void Sort(int[] input)
        {
            for (var frontIndex = 0; frontIndex < input.Length; frontIndex++)
            {
                var indexOfSmallestNumber = FindIndexOfSmallestNumber(input, frontIndex);
                SwapNumbersAtIndexes(input, frontIndex, indexOfSmallestNumber);
            }
        }

        private void SwapNumbersAtIndexes(int[] input, int a, int b)
        {
            (input[b], input[a]) = (input[a], input[b]);
        }

        private int FindIndexOfSmallestNumber(int[] input, int startingAt)
        {
            var indexOfSmallestNumber = startingAt;
            for (var i = indexOfSmallestNumber + 1; i < input.Length; i++)
            {
                if (input[i] < input[indexOfSmallestNumber])
                {
                    indexOfSmallestNumber = i;
                }
            }
            return indexOfSmallestNumber;
        }
    }
}