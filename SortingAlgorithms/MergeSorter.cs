namespace SortingAlgorithms
{
    internal class MergeSorter
    {
        public int[] Sort(int[] input)
        {
            if (input.Length == 1)
            {
                return input;
            }

            var firstHalfLength = input.Length / 2;
            var firstHalf = input.Take(firstHalfLength);
            var secondHalf = input.Skip(firstHalfLength);

            var sortedFirstHalf = Sort(firstHalf.ToArray());
            var sortedSecondHalf = Sort(secondHalf.ToArray());

            return Merge(sortedFirstHalf, sortedSecondHalf);
        }

        private int[] Merge(int[] array1, int[] array2)
        {
            var mergedList = new List<int>();
            var list1 = new List<int>(array1);
            var list2 = new List<int>(array2);
            while (list1.Any() && list2.Any())
            {
                if (list1.First() < list2.First())
                {
                    mergedList.Add(list1.First());
                    list1.RemoveAt(0);
                }
                else
                {
                    mergedList.Add(list2.First());
                    list2.RemoveAt(0);
                }
            }
            return mergedList.Concat(list1).Concat(list2).ToArray();
        }
    }
}