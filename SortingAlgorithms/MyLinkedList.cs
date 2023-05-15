namespace SortingAlgorithms
{
    class MyLinkedList
    {
        private MyNode? firstNode = null;

        public void Add(int value)
        {
            var newNode = new MyNode(value);

            if (firstNode == null)
            {
                firstNode = newNode;
            }
            else
            {
                firstNode.Add(newNode);
            }
        }

        public int Find(int value)
        {
            if (firstNode == null)
            {
                return -1;
            }
            return firstNode.Find(value);
        }

        public void Insert(int index, int value)
        {
            var newNode = new MyNode(value);

            if (index == 0)
            {
                if (firstNode != null)
                {
                    newNode.nextNode = firstNode;
                }
                firstNode = newNode;
            }
            else
            {
                if (firstNode == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                firstNode.Insert(index, newNode);
            }
        }

        public int Length()
        {
            if (firstNode == null)
            {
                return 0;
            }
            return firstNode.Length();
        }

        public void RemoveAt(int index)
        {
            if (firstNode == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == 0)
            {
                firstNode = firstNode.nextNode;
            }
            else
            {
                firstNode.RemoveAt(index);
            }
        }
    }
}