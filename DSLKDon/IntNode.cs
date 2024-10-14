namespace DSLKDon
{
    internal class IntNode
    {
        private int data;
        private IntNode next;

        public int Data { get => data; set => data = value; }
        internal IntNode Next { get => next; set => next = value; }
        public IntNode(int x = 0)
        {
            data = x;
            next = null;
        }
    }
}
