using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeWalker.Contract;
using TreeWalker.Populater;
using TreeWalker.Implementation;

namespace TreeWalker
{
    class Program
    {
        static void OnVisitNode(ITreeNode node)
        {
            Console.WriteLine(node.Name);
        }

        static void Main(string[] args)
        {
            ITreeNode rootNode = TestTreePopulator.CreateTree();
            
            Console.WriteLine("BFS Walker");
            ITreeWalker walker = new BFSTreeWalker();
            walker.VisitNodes(rootNode, OnVisitNode);

            Console.WriteLine();

            Console.WriteLine("DFS Walker");
            walker = new DFSTreeWalker();
            walker.VisitNodes(rootNode, OnVisitNode);


            Console.WriteLine(rootNode.Name);
        }
    }
}
