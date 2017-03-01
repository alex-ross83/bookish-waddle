using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;

namespace Util.Tests
{
	[TestClass]
	public class TreePrinterTest
	{
		[TestMethod]
		public void PrintTree()
		{
			var printer = new TreePrinter<int>();
			var tree = new TreeNode<int>() { Value = 5 };
			tree.Right = new TreeNode<int>() { Value = 7, Left = new TreeNode<int>() { Value = 6 }, Right = new TreeNode<int>() { Value = 8 } };
			tree.Left = new TreeNode<int>() { Value = 3, Left = new TreeNode<int>() { Value = 2 }, Right = new TreeNode<int>() { Value = 4 } };
			Util.TreePrinter<int>.Print(tree);
			Assert.IsTrue(true);
		}
	}
}
