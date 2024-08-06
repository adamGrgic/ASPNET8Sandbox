using Microsoft.AspNetCore.Mvc;
using SandboxModule.L33tC0d3.Models;

namespace SandboxModule.L33tC0d3
{
    public class ArrayToListNodeHelper : Controller
    {
        // Helper function to convert array to ListNode
        public ListNode ArrayToListNode(int[] array)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            foreach (int val in array)
            {
                current.next = new ListNode(val);
                current = current.next;
            }
            return dummy.next;
        }
    }
}
