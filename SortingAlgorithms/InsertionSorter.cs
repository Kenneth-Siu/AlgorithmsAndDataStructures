namespace SortingAlgorithms
{
    internal class InsertionSorter
    {
        public void Sort(int[] input)
        {
            for (var i = 1; i < input.Length; i++)
            {
                Insert(i, input);
            }
        }

        private void Insert(int frontIndex, int[] input)
        {
            // Swap backwards until in right place
        }
    }
}