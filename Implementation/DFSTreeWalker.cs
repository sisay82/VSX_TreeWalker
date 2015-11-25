using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeWalker.Contract;

namespace TreeWalker.Implementation
{
    class DFSTreeWalker : ITreeWalker
    {
        public void VisitNodes(ITreeNode node, Action<ITreeNode> onVisitNode)
        {
            if (node == null) return;

            onVisitNode(node);
            foreach (ITreeNode childNode in node.ChildNodes)
            {
                this.VisitNodes(childNode, onVisitNode);
            }
        }


        #region Down here a commented version of VisitNode - PostOrder
            //public void VisitNodes(ITreeNode node, Action<ITreeNode> onVisitNode)
            //{
            //    if (node == null) return;
            //    
            //    foreach (ITreeNode childNode in node.ChildNodes)
            //    {
            //        this.VisitNodes(childNode, onVisitNode);
            //    }
            //    onVisitNode(node);
            //}
        #endregion Down here the version of DepthFirst Traversal PostOrder
    }
}
