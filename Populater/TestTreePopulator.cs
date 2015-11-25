using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeWalker.Contract;
using TreeWalker.Implementation;

namespace TreeWalker.Populater
{
    class TestTreePopulator
    {
        private static void AddNodes(int depth, int childCount, TreeNode parent)
        {
            if (depth == 0) return;

            for (int i = 0; i < childCount; i++)
            {
                TreeNode childNode = new TreeNode(parent.Name + '_' + i.ToString());
                parent.Add(childNode);
                AddNodes(depth - 1, GetRandomChildCount(), childNode); 
            }
        }

        private static int GetRandomChildCount()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            return rnd.Next(5, 10);
        }

        public static ITreeNode CreateTree()
        {
            TreeNode root = new TreeNode("root");
            AddNodes(5, GetRandomChildCount(), root);
            return root;
        }
    }
}
