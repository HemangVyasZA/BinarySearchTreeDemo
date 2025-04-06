namespace BinarySearchTreeDemo;

public class BinarySearchTreeNode
{
    public int Value { get; private set; }

    public BinarySearchTreeNode(int value)
    {
        Value = value;
        LeftNode = null;
        RightNode = null;
    }

    public BinarySearchTreeNode? LeftNode { get; set; } = null;
    public BinarySearchTreeNode? RightNode { get; set; } = null;
}

public class BinarySearchTreeTraverser
{
    private BinarySearchTreeNode? Root { get; set; }

    public BinarySearchTreeTraverser()
    {
        Root = null;
    }

    public BinarySearchTreeTraverser(int value)
    {
        Root = new BinarySearchTreeNode(value);
    }

    public void Insert(int value)
    {
        if (Root == null)
        {
            Root = new BinarySearchTreeNode(value);
            return;
        }

        Insert(Root, value);
    }

    private void Insert(BinarySearchTreeNode node, int value)
    {
        if (value < node.Value)
        {
            if (node.LeftNode == null)
            {
                node.LeftNode = new BinarySearchTreeNode(value);
            }
            else
            {
                Insert(node.LeftNode, value);
            }
        }
        else
        {
            if (node.RightNode == null)
            {
                node.RightNode = new BinarySearchTreeNode(value);
            }
            else
            {
                Insert(node.RightNode, value);
            }
        }
    }

    public string BreadthFirstSearch()
    {
        List<int> nodesValue = [];
        if (Root == null)
        {
            throw new Exception("Root node can't be null");
        }

        Queue<BinarySearchTreeNode> queue = new Queue<BinarySearchTreeNode>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            nodesValue.Add(currentNode.Value);

            if (currentNode.LeftNode != null)
            {
                queue.Enqueue(currentNode.LeftNode);
            }

            if (currentNode.RightNode != null)
            {
                queue.Enqueue(currentNode.RightNode);
            }
        }

        return string.Join(",", nodesValue.Select(item => item.ToString()));
    }
}