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
tree.Add(100);
tree.Add(99);
tree.Add(76);
tree.Add(43);
tree.Add(12);
tree.Add(23);
tree.Add(89);
tree.Add(70);
tree.Add(69);

tree.Remove(25);
tree.PrintInOrder();