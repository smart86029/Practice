namespace Practice.LeetCode.Algorithms;

public class LeetCode0129
{
    public int SumNumbers(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }

        var result = 0;
        var unvisited = new Stack<(TreeNode Node, int Number)>();
        unvisited.Push((root, 0));
        while (unvisited.Any())
        {
            var (current, number) = unvisited.Pop();
            var sum = number * 10 + current.val;
            if (current.right is not null)
            {
                unvisited.Push((current.right, sum));
            }

            if (current.left is not null)
            {
                unvisited.Push((current.left, sum));
            }

            if (current.right is null && current.left is null)
            {
                result += sum;
            }
        }

        return result;
    }
}
