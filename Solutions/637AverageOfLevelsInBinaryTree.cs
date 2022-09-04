namespace LeetCode.Solutions;

public class AverageOfLevelsInBinaryTree
{
    //https://leetcode.com/problems/average-of-levels-in-binary-tree/
    public IList<double> AverageOfLevels(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        var avg = new List<double>();
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            int size = queue.Count;
            double sum = 0;

            for (int i = 0; i < size; ++i)
            {
                TreeNode cur = queue.Dequeue();
                sum += cur.val;
                if (cur.left != null) queue.Enqueue(cur.left);
                if (cur.right != null) queue.Enqueue(cur.right);
            }

            avg.Add(sum / size);
        }

        return avg;
    }

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
    }
}