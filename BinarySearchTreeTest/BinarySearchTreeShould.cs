using BinarySearchTreeDemo;

namespace BinarySearchTreeTest;

public class BinarySearchTreeShould
{
    [Fact]
    public void ReturnTrueIfItContainsValue()
    {
        
        BinarySearchTreeDataStructure bst = new BinarySearchTreeDataStructure();
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(7);
        bst.Insert(12);
        bst.Insert(15);
        bst.Insert(15);
        bool doesContain = bst.Contains(5);
        Assert.True(doesContain);
    }
}