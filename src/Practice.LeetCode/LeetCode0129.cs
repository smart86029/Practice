using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.LeetCode
{
    public class LeetCode0129
    {
        public int SumNumbers(TreeNode root)
        {
            if (root == default)
                return 0;

            var result = 0;
            var unvisited = new Stack<Tuple<TreeNode, int>>();
            unvisited.Push(Tuple.Create(root, 0));
            while (unvisited.Any())
            {
                var pop = unvisited.Pop();
                var current = pop.Item1;
                var sum = pop.Item2 * 10 + current.val;
                if (current.right != default)
                    unvisited.Push(Tuple.Create(current.right, sum));
                if (current.left != default)
                    unvisited.Push(Tuple.Create(current.left, sum));
                if (current.right == default && current.left == default)
                    result += sum;
            }

            return result;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int x)
            {
                val = x;
            }
        }
    }
}