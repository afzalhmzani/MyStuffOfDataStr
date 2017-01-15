namespace MyStuffOfDataStr
{
    public class Node
    {
        private object data;
        private int dataInt;
        private Node next;

        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public Node(int dataInt, Node next)
        {
            this.dataInt = dataInt;
            this.next = next;
        }
        public Node(object data)
        {
            this.data = data;
        }
        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public int DataInt
        {
            get { return this.dataInt; }
            set { this.dataInt = value; }
        }
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
