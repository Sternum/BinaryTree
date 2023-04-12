using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinaryTree
{
    public class BTree
    {
        private BTreeNode root;

        public void Add(int value)
        {
            if(root == null)
            {
                root = new BTreeNode() { Value = value };
                return;
            }
            Add(root, value);
        }

        private void Add(BTreeNode node, int value)
        {
            if (node.Value > value)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = new BTreeNode() { Value = value };
                }
                else
                {
                    Add(node.LeftChild, value);
                }
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new BTreeNode() { Value = value };
                }
                else
                {
                    Add(node.RightChild, value);
                }
            }
        }

        public void Remove(int value)
        {
            BTreeNode node = Find(value);
            BTreeNode successor = FindSuccessor(node);
            node.Value = successor.Value;
            Delete(root, successor);
        }

        private BTreeNode FindSuccessor(BTreeNode node)
        {
            if (node.RightChild != null)
            {
                return FindMinimum(node.RightChild);
            }

            if (node.LeftChild != null)
            {
                return FindMaximum(node.LeftChild);
            }
            return node;
        }

        private  BTreeNode FindMinimum(BTreeNode node)
        {
            if(node.LeftChild != null)
            {
                return FindMinimum(node.LeftChild);
            }

            return node;
        }

        private  BTreeNode FindMaximum(BTreeNode node)
        {
            if (node.RightChild != null)
            {
                return FindMinimum(node.RightChild);
            }

            return node;
        }

        private void PreOrder(BTreeNode node) {
            Console.WriteLine(node.Value);
            if(node.LeftChild != null) { 
                PreOrder(node.LeftChild); 
            }
            if(node.RightChild != null)
            {
                PreOrder(node.RightChild);
            }
        }
        private void PostOrder(BTreeNode node) {
            if (node.LeftChild != null)
            {
                PostOrder(node.LeftChild);
            }
            if (node.RightChild != null)
            {
                PostOrder(node.RightChild);
            }
            Console.WriteLine(node.Value);
        }
        private void InOrder(BTreeNode node) {
            
            if (node.LeftChild != null)
            {
                InOrder(node.LeftChild);
            }
            Console.WriteLine(node.Value);
            if (node.RightChild != null)
            {
                InOrder(node.RightChild);
            }
            
        }

        public void PrintPreOrder()
        {
            PreOrder(root);
        }
        public void PrintPostOrder()
        {
            PostOrder(root);
        }
        public void PrintInOrder()
        {
            InOrder(root);
        }

        private BTreeNode Search(BTreeNode node, int value)
        {
            if(node.Value == value) return node;
            if(node.Value > value) return Search(node.LeftChild, value);
            if(node.Value < value) return Search(node.RightChild, value);

            return null;
        }

        private void Delete(BTreeNode currentNode, BTreeNode searchNode)
        {
            if (currentNode.LeftChild == searchNode)
            {
                currentNode.LeftChild = null;
                return;
            }
            if (currentNode.RightChild == searchNode)
            {
                currentNode.RightChild = null;
                return;
            }
            if (currentNode.LeftChild != null)
            {
                Delete(currentNode.LeftChild, searchNode);
            } 
            if (currentNode.RightChild != null)
            {
                Delete(currentNode.RightChild, searchNode);
            }
        }

        public BTreeNode Find(int value)
        {
           return Search(root , value);
        }
      
    }
}
