using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TreeWalker.Contract;

namespace TreeWalker.Implementation
{
    [DebuggerDisplay("name = {Name}, childcount = {childNodes.Count}")]
    class TreeNode: ITreeNode
    {
        private List<ITreeNode> childNodes = new List<ITreeNode>();

        public TreeNode(string name)
        {
            this.Name = name;
        }

        public IEnumerable<ITreeNode> ChildNodes
        {
            get { return childNodes; }
        }

        public void Add(ITreeNode nodeToAdd)
        {
            childNodes.Add(nodeToAdd);
        }

        public string Name { get; private set; }
    }
}
