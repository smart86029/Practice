namespace Practice.LeetCode;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode FromArray(int[] nums)
    {
        if (nums.Length == 0)
        {
            return default;
        }

        var count = nums.Length;
        var nodes = new TreeNode[count];

        for (var i = 0; i < count; i++)
        {
            var leftIndex = i * 2 + 1;
            var rightIndex = leftIndex + 1;

            if (nodes[i] is null)
            {
                nodes[i] = new TreeNode(0);
            }

            nodes[i].val = nums[i];
            if (leftIndex < count)
            {
                nodes[leftIndex] = new TreeNode(0);
                nodes[i].left = nodes[leftIndex];
            }
            if (rightIndex < count)
            {
                nodes[rightIndex] = new TreeNode(0);
                nodes[i].right = nodes[rightIndex];
            }
        }

        return nodes[0];
    }

    public static TreeNode FromArray(int?[] nums)
    {
        if (nums.Length == 0)
        {
            return default;
        }

        var count = nums.Length;
        var nodes = new TreeNode[count];
        var parents = new Queue<TreeNode>();

        for (var i = 0; i < count; i++)
        {
            if (!nums[i].HasValue)
            {
                continue;
            }

            nodes[i] = new TreeNode(nums[i].Value);
            parents.Enqueue(nodes[i]);
            if (i == 0)
            {
                continue;
            }

            var parent = parents.Peek();
            if (parent.left is null)
            {
                parent.left = nodes[i];
            }
            else
            {
                parent.right = nodes[i];
                parents.Dequeue();
            }
        }

        return nodes[0];
    }

    public int?[] ToArray()
    {
        var nums = new List<int?>();
        var nodes = new Queue<TreeNode>();
        nodes.Enqueue(this);

        while (nodes.Any())
        {
            var current = nodes.Dequeue();
            nums.Add(current?.val);
            if (current is null)
            {
                continue;
            }

            nodes.Enqueue(current.left);
            nodes.Enqueue(current.right);
        }

        var lastIndex = nums.FindLastIndex(x => x.HasValue);

        return nums.Take(lastIndex + 1).ToArray();
    }
}
