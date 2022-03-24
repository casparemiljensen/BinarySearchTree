using System;
using System.Diagnostics;

public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static int TreeDepth { get; set; }

    public static bool Contains(Node root, int value)
    {
        TreeDepth++;
        if (root == null)
            return false;
        if (root.Value == value)
            return true;
        if (value > root.Value)
            return Contains(root.Right, value);
        if (value < root.Value)
            return Contains(root.Left, value);
        else
            return false;
    }

    public static void Main(string[] args)
    {
        //Node n1 = new Node(1, null, null);
        //Node n3 = new Node(3, null, null);
        //Node n2 = new Node(2, n1, n3);

        //Leaves of n60

        Node n77 = new Node(77, null, null);
        Node n72 = new Node(72, null, null);
        Node n75 = new Node(75, n72, n77);

        Node n68 = new Node(68, null, null);
        Node n62 = new Node(62, null, null);
        Node n65 = new Node(65, n62, n68);

        Node n70 = new Node(70, n65, n75);
        Node n80 = new Node(80, n70, null);

        Node n50 = new Node(50, null, null);
        Node n60 = new Node(60, n50, n80);

        //Leaves of n28

        Node n30 = new Node(30, null, null);
        Node n29 = new Node(29, null, n30);

        Node n26 = new Node(26, null, null);

        Node n28 = new Node(28, n26, n29);

        // Leaves of n10
        Node n15 = new Node(15, null, null);
        Node n13 = new Node(13, null, null);

        Node n14 = new Node(14, n13, n15);
        Node n11 = new Node(11, null, null);

        Node n12 = new Node(12, n11, n14);

        Node n9 = new Node(9, null, null);
        Node n6 = new Node(6, null, null);
        Node n8 = new Node(8, n6, n9);

        Node n10 = new Node(10, n8, n12);

        // leaves of n22
        Node n23 = new Node(23, null, null);
        Node n17 = new Node(17, null, null);
        Node n22 = new Node(22, n17, n23);

        // leaves of n25
        Node n40 = new Node(40, n28, n60);
        Node n16 = new Node(16, n10, n22);
        Node n25 = new Node(25, n16, n40);

        TreeDepth = 0;

        Stopwatch sw = new Stopwatch();
        sw.Start();
        Console.WriteLine("Value found?: " + Contains(n25, 77));
        sw.Stop();
        Console.WriteLine("Elapsed ticks: " + sw.ElapsedTicks);
        Console.WriteLine("Value found at tree depth: " + TreeDepth);
    }
}