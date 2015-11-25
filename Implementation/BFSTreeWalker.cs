using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeWalker.Contract;

namespace TreeWalker.Implementation
{
    class BFSTreeWalker : ITreeWalker
    {

        public void VisitNodes(ITreeNode node, Action<ITreeNode> onVisitNode)
        {
            Queue<ITreeNode> nodeToVisit = new Queue<ITreeNode>(); 

            nodeToVisit.Enqueue(node);

            while (nodeToVisit.Count > 0)
            {
                var current = nodeToVisit.Dequeue();
                
                if (current == null) continue;

                foreach (ITreeNode childNode in current.ChildNodes)
                {
                    nodeToVisit.Enqueue(childNode);
                }

                onVisitNode(current);
            }
        }
    }
}
