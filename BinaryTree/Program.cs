// See https://aka.ms/new-console-template for more information
using BinaryTree;

Console.WriteLine("Hello, World!");

BTree tree = new BTree();

tree.Add(10);
tree.Add(5);
tree.Add(2);
tree.Add(7);
tree.Add(6);
tree.Add(20);
tree.Add(15);
tree.Add(30);
tree.Add(25);
tree.Add(40);

tree.Remove(5);
tree.PrintInOrder();