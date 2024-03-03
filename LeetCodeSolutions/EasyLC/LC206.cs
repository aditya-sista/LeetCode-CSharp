using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLC
{
    /// <summary>
    /// Reverse a linked list.
    /// </summary>
    public class LC206
    {
        // Iterative solution
        public ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            ListNode next = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
            return head;
        }

        // Recursive solution
        //public ListNode ReverseList(ListNode head)
        //{
        //    if (head == null || head.next == null) return head;

        //    var newHead = ReverseList(head.next);
        //    var curr = head.next;
        //    curr.next = head;
        //    head.next = null;
        //    return newHead;
        //}
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) 
        {
            this.val = val;
            this.next = next;
        }
    }
}
