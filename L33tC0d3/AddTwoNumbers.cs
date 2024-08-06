using Microsoft.AspNetCore.Mvc;
using SandboxModule.L33tC0d3.Models;


namespace SandboxModule.L33tC0d3
{

    
    

    // Add Two Numbers
    // Difficult Medium
    // Problem Link :https://leetcode.com/problems/add-two-numbers/description/
    // ChatGPT Helper: https://chatgpt.com/c/257a92e7-0c5e-4be9-a2c7-e86003f29c52
    [Route("{controller}/{action}")]
    public class AddTwoNumbers : Controller
    {
        public AddTwoNumbers()
        {
            
        }
        public IActionResult Executer()
        {
            int[] l1Array = { 2, 4, 3 };
            int[] l2Array = { 5, 6, 4 };

            ListNode l1 = ArrayToListNode(l1Array);
            ListNode l2 = ArrayToListNode(l2Array);

            ListNode result = V1(l1, l2);

            // Print the result linked list
            while (result != null)
            {
                Console.Write(result.val + " ");
                result = result.next;
            }
            return Ok();
        }

        public ListNode V1(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            ListNode head = result;
            int sum = 0;
            while (l1 != null || l2 != null || sum > 0) // to keep running if we have a value in l1, l2 or carry
            {
                // two if statements because l1 and l2 can be of different sizes
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                result.next = new ListNode(sum % 10); // digit
                sum /= 10; // carry
                result = result.next;
            }
            return head.next; // we don't want to return head as it will add a node=0 at the start so -> wrong answer
        }


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
