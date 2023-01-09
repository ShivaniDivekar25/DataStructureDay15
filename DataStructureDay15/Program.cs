using System.Xml.Linq;

namespace DataStructureDay15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hashtable and BinarySearchTree of Data structure");
            Console.WriteLine("Enter the option given below");      //Taking user input
            Console.WriteLine("1:Find frequency of words\n2:Find frequency of words in large paraghraph\n3:Remove avoidable word from phrase\n4:Create binary search tree\n5:Create binary tree using Size method\n6:Search in a binary search tree");
            int option = Convert.ToInt32(Console.ReadLine());

            static void CountNumbOfOccurence(string paragraph)          //Method to get final frequency
            {
                MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

                string[] words = paragraph.Split(' ');

                foreach (string word in words)
                {
                    if (hashTabe.Exists(word.ToLower()))
                        hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                    else
                        hashTabe.Add(word.ToLower(), 1);
                }
                Console.WriteLine("Displaying after add operation");
                hashTabe.Display();
                string s = "avoidable";
                hashTabe.Remove(s);
                Console.WriteLine("After removed an item {0}", s);
                hashTabe.Display();
            }
            switch (option)
            {
                case 1:
                    CountNumbOfOccurence("To be or not to be");
                    break;
                case 2:
                    CountNumbOfOccurence("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");
                    break;
                case 3:
                    CountNumbOfOccurence("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");
                    break;
                case 4:
                    {
                        INode root = new INode(56);
                        INode n1 = new INode(30);
                        INode n2 = new INode(70);

                        root.left = n1;
                        root.right = n2;

                        INode nodeToFind = MyBinaryNode.Search(root, 40);
                        Console.WriteLine("The node to find is:" + nodeToFind.value);
                    }
                    break;
                case 5:
                    MyBinaryNode tree = new MyBinaryNode();
                    tree.root = new INode(56);
                    tree.root.left = new INode(30);
                    tree.root.right = new INode(70);
                    tree.root.left.left = new INode(22);
                    tree.root.left.right = new INode(40);
                    tree.root.left.left.left = new INode(11);
                    tree.root.left.left.left.left = new INode(3);
                    tree.root.left.left.left.right = new INode(16);
                    tree.root.right.right = new INode(95);
                    tree.root.right.left = new INode(60);
                    tree.root.right.right.right = new INode(65);
                    tree.root.right.right.right.left = new INode(63);
                    tree.root.right.right.right.right = new INode(67);
                    Console.WriteLine("The size of binary tree is :" + tree.size());
                    break;
                case 6:
                    {
                        INode root = new INode(56);
                        INode n1 = new INode(30);
                        INode n2 = new INode(70);
                        INode n3 = new INode(22);
                        INode n4 = new INode(40);
                        INode n5 = new INode(11);
                        INode n6 = new INode(3);
                        INode n7 = new INode(16);
                        INode n8 = new INode(95);
                        INode n9 = new INode(60);
                        INode n10 = new INode(65);
                        INode n11 = new INode(63);
                        INode n12 = new INode(67);
                        root.left = n1;
                        root.right = n2;
                        n1.left = n3;
                        n1.right = n4;
                        n3.left = n5;
                        n3.left = n6;
                        n3.right = n7;
                        n2.right = n8;
                        n2.left = n9;
                        n9.right = n10;
                        n10.left = n11;
                        n10.right = n12;

                        INode nodeToFind = MyBinaryNode.Search(n10.left, 63);
                        Console.WriteLine("The number to be search in Binary tree is : " + nodeToFind.value);
                    }
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;

            }
        }
    }
}