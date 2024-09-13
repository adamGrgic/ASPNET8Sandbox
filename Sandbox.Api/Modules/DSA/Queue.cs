using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DSA
{
    public class Queue :ControllerBase
    {

        public IActionResult BasicExample()
        {
            Queue<int> queue = new Queue<int>();

            // Add elements to the queue (Enqueue)
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Items in the queue:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            // Remove an element from the queue (Dequeue)
            int dequeuedItem = queue.Dequeue();
            Console.WriteLine($"\nDequeued item: {dequeuedItem}");

            Console.WriteLine("\nItems in the queue after dequeue:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            // Peek at the front element without removing it
            int frontItem = queue.Peek();
            Console.WriteLine($"\nFront item (peek): {frontItem}");

            return Ok();
        }
    }
}
