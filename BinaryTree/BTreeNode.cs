﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BTreeNode
    {
        public int Value { get; set; }
        public BTreeNode LeftChild { get; set; }
        public BTreeNode RightChild { get; set;}
    }
}
