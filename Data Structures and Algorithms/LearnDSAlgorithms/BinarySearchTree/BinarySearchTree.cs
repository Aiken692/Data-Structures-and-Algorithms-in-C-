namespace Data_Structures_and_Algorithms.LearnDSAlgorithms.BinarySearchTree;

public class BinarySearchTree
{
    public TreeNode Root { get; set; } = null;

    public void Insert(int key, string value)
    {
        Root = InserItem(Root, key, value);
    }

    private TreeNode InserItem(TreeNode node, int key, string value)
    {
        TreeNode newNode = new TreeNode(key, value);

        //If This is the first time you insert , create the Root
        if (node == null)
        {
            node = newNode;
            return node;
        }
        
        //If this isn't the first insert, Traverse, Find null, Insert 
        if (key < node.Key)
        {
            node.LeftChild = InserItem(node.LeftChild, key, value);
        }
        else
        {
            node.RightChild = InserItem(node.RightChild, key, value);
        }

        return node;
    }

    public string Find(int key)
    {
        TreeNode node = Find(Root, key);
        return node == null ? null : node.Value;
    }

    private TreeNode? Find(TreeNode node, int key)
    {
        if (node == null || node.Key == key)
        {
            return node;
        }else if (key < node.Key)
        {
            return Find(node.LeftChild, key);
        }else if (key > node.Key)
        {
            return Find(node.RightChild, key);
        }

        return null;
    }
}