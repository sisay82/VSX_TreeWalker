using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeWalker.Contract
{
    public interface ITreeNode
    {
        IEnumerable<ITreeNode> ChildNodes { get; }
        string Name { get; }
    }
}
