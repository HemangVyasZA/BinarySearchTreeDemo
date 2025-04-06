namespace BinarySearchTreeDemo;

class Program
{
    static void Main(string[] args)
    {
      
        // int[] values = [10, 5, 15, 3, 7, 12, 18];
        int[] values = [10, 2, 5, 8, 1, 4, 15, 11];
        BinarySearchTreeTraverser binarySearchTreeTraverser = new BinarySearchTreeTraverser();
        foreach (int value in values)
        {
            binarySearchTreeTraverser.Insert(value);
        }

        // Perform BFS traversal
        Console.WriteLine("BFS Traversal of the BST:");
        var result = binarySearchTreeTraverser.BreadthFirstSearch();
        Console.WriteLine($"Traversing Binary search tree level by level: {result}");
        Console.ReadLine();
    }
}