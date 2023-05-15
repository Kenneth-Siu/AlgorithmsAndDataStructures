namespace SortingAlgorithms
{
    class MyNode
    {
        public MyNode? nextNode = null;
        public int value;

        public MyNode(int value)
        {
            this.value = value;
        }

        public void Add(MyNode newNode)
        {
            if (nextNode == null)
            {
                nextNode = newNode;
            }
            else
            {
                nextNode.Add(newNode);
            }
        }

        public int Find(int value)
        {
            if (this.value == value)
            {
                return 0;
            }
            if (nextNode == null)
            {
                return -1;
            }

            var returnValue = nextNode.Find(value);
            if (returnValue == -1)
            {
                return -1;
            }
            return returnValue + 1;
        }

        public void Insert(int index, MyNode newNode)
        {
            if (index == 1)
            {
                newNode.nextNode = nextNode;
                nextNode = newNode;
            }
            else
            {
                if (nextNode == null)
                {
                    throw new ArgumentOutOfRangeException();
                }
                nextNode.Insert(index - 1, newNode);
            }
        }

        public int Length()
        {
            if (nextNode == null)
            {
                return 1;
            }
            return nextNode.Length() + 1;
        }

        public void RemoveAt(int index)
        {
            if (nextNode == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == 1)
            {
                nextNode = nextNode.nextNode;
            }
            else
            {
                nextNode.RemoveAt(index - 1);
            }
        }
    }
}