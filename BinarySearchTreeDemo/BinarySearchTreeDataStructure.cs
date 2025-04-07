namespace BinarySearchTreeDemo;


public class BinarySearchTreeDataStructure
{
    private BinarySearchTreeNode? Root { get; set; }

    public BinarySearchTreeDataStructure()
    {
        Root = null;
    }

    public BinarySearchTreeDataStructure(int value)
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

    public int FindMin()
    {
        if (Root == null)
        {
            throw new Exception("Tree is empty");
        }

        var root = Root;

        while (root.LeftNode != null)
        {
            root = root.LeftNode;
        }

        return root.Value;
    }
    
    public int FindMax()
    {
        if (Root == null)
        {
            throw new Exception("Tree is empty");
        }

        var root = Root;

        while (root.RightNode != null)
        {
            root = root.RightNode;
        }

        return root.Value;
    }

    public bool Contains(int value)
    {
        return Contains(Root, value);
    }
    private bool Contains(BinarySearchTreeNode? node, int value)
    {
        if (node == null)
        {
            return false;
        }

        return node.Value == value || Contains(value < node.Value ? node.LeftNode : node.RightNode, value);
    }
}