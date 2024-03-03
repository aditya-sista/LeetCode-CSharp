using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLC
{
    /// <summary>
    /// Palindrome Linked List.
    /// </summary>
    public class LC234
    {
        public bool IsPalindrome(ListNode head)
        {
            ListNode slowPointer = head;
            ListNode fastPointer = head;

            // Get to the end of the first half of the linked list.
            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }

            // At this point, slowPointer is going to be in the middle of the linked list.
            // Reverse the second half of the linked list.
            // At the end of the while loop, prev will become the head of the reversed second half.
            ListNode prev = null;
            while (slowPointer != null)
            {
                ListNode next = slowPointer.next;
                slowPointer.next = prev;
                prev = slowPointer;
                slowPointer = next;
            }

            // Compare the two halves.
            fastPointer = prev;
            slowPointer = head;
            while (fastPointer != null)
            {
                if (slowPointer.val != fastPointer.val) return false;
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next;
            }
            return true;
        }
    }
}
