namespace QueueProject
{
    class QueNode
    {
        public int info;
        public QueNode link;

        public QueNode(int i)
        {
            info = i; 
            link = null;
        }
    }
}
