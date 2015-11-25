using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeWalker.Contract
{
    public interface ITreeWalker
    {
        void VisitNodes(ITreeNode node, Action<ITreeNode> onVisitNode);
    }
}
