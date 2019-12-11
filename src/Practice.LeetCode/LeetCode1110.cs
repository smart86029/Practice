using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.LeetCode
{
    public class LeetCode1110
    {
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            var toDelete = new HashSet<int>(to_delete);
            var map = new Dictionary<TreeNode, int>();
            var nodes = new Queue<Tuple<TreeNode, TreeNode, bool>>();
            nodes.Enqueue(Tuple.Create(root, default(TreeNode), true));

            while (nodes.Any())
            {
                var pair = nodes.Dequeue();
                var node = pair.Item1;
                var parent = pair.Item2;
                var isLeft = pair.Item3;
                if (node == default)
                    continue;

                if (toDelete.Contains(node.val))
                {
                    map[node] = 2;
                    if (parent != default)
                    {
                        if (isLeft)
                            parent.left = default;
                        else
                            parent.right = default;
                    }
                }
                else
                {
                    map[node] = parent == default || map[parent] == 2 ? 0 : 1;
                }

                nodes.Enqueue(Tuple.Create(node.left, node, true));
                nodes.Enqueue(Tuple.Create(node.right, node, false));
            }

            var result = map
                .Where(x => x.Value == 0)
                .Select(x => x.Key)
                .ToList();

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