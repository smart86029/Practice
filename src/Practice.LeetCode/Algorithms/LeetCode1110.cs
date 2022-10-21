namespace Practice.LeetCode.Algorithms;

public class LeetCode1110
{
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
    {
        var toDelete = new HashSet<int>(to_delete);
        var map = new Dictionary<TreeNode, int>();
        var nodes = new Queue<(TreeNode Node, TreeNode Parent, bool IsLeft)>();
        nodes.Enqueue((root, default, true));

        while (nodes.Any())
        {
            var (node, parent, isLeft) = nodes.Dequeue();
            if (node is null)
            {
                continue;
            }

            if (toDelete.Contains(node.val))
            {
                map[node] = 2;
                if (parent is not null)
                {
                    if (isLeft)
                    {
                        parent.left = default;
                    }
                    else
                    {
                        parent.right = default;
                    }
                }
            }
            else
            {
                map[node] = parent is null || map[parent] == 2 ? 0 : 1;
            }

            nodes.Enqueue((node.left, node, true));
            nodes.Enqueue((node.right, node, false));
        }

        var results = map
            .Where(x => x.Value == 0)
            .Select(x => x.Key)
            .ToList();

        return results;
    }
}
