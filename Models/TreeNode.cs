using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TreeNode<T>
    {
      public TreeNode<T> Left { get; set; }
      public TreeNode<T> Right { get; set; }
      public T Value { get; set; }  
    }
}
