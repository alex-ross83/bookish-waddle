using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
	public class TreePrinter<T>
	{
		public static void Print(TreeNode<T> n) {
			if (n == null)
			{
				throw new ArgumentNullException("Invalid tree!");
			}
			PrintBST(n, "\t");
		}
		private static void PrintBST(TreeNode<T> root, string prefix)
		{
			if (root == null)
			{
				//Console.WriteLine(prefix + "+- <null>");
				return;
			}
			//otherwise....
			Console.WriteLine(prefix + "+- " + root.Value);
			PrintBST(root.Left, prefix + "|\t");
			PrintBST(root.Right, prefix + "|\t");
		}
		public static void Print_WithStack(TreeNode<T> n)
		{
			if (n == null)
			{
				throw new ArgumentException("Invalid tree provided!");
			}
			//Find depth of tree
			//we can use depth first and see how deep can we go, use a stack for this
			var stack = new Stack<TreeNode<T>>();
			stack.Push(n);
			TreeNode<T> current;
			while (stack.Count() > 0)
			{
				current = stack.Pop();
				Console.WriteLine(GetIdentation(stack.Count()) + "+-"  + current.Value);
				if (current.Left != null)
				{
					stack.Push(current.Left);
				}
				if (current.Right != null)
				{
					stack.Push(current.Right);
				}
				//debug only
				//Console.WriteLine(current.Value.ToString());
			}
		}

		private static string GetIdentation(int times)
		{
			string identation = times > 0 ? "|\t" : "\t";
			var sb = new StringBuilder();
			for (int i = 0; i < times; i++)
			{
				sb.Append(identation);
			}
			return sb.ToString();
		}
		public static int MaxDepth(TreeNode<T> n)
		{
			if (n == null)
			{
				return 0;
			}
			int leftSideDepth = MaxDepth(n.Left) + 1;
			int rightSideDepth = MaxDepth(n.Right) + 1;
			if (leftSideDepth > rightSideDepth)
			{
				return leftSideDepth;
			}
			else
			{
				return rightSideDepth;
			}
		}

	}
}
