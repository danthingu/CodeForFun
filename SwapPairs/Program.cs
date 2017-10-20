using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapPairs
{

    class Program
    {
        // 1 -> 2 -> 3 -> 4
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next = new ListNode(6);
            ListNode node = MySwapPairs(head);
            Console.Write($"{node.val} -> {node.next.val} -> {node.next.next.val} -> {node.next.next.next.val} -> {node.next.next.next.next.val} -> {node.next.next.next.next.next.val}");
            Console.ReadKey();
        }



        //STEPS:
        /*
         * 
         *      set dummy
         *      set dummy point to the next node
         *      set current temp node to dummy
         *      have a loop, check if from the current node to the next node and next next node is not null
         *      START THE LOOP: once you are in the loop, this is what you do next:
         *      initialize the first and second node to the temp.next and temp.next.next node
         *      set the first.next equal to second.next node
         *      set dummy current temp node to 2 if the listnode: 1->2
         *      set dummy current temp node to 1 if the listnode: 2->1
         *      once you are done, set the currentnode to the new position (3 in this case) : 2-> 1 -> 3
         *      EXIT THE LOOP
         *      return the head, in this case will be dummy.next;
         * 
         */
        public static ListNode MySwapPairs(ListNode head)
        {
            ListNode current, dummy;
            dummy = new ListNode(0);
            dummy.next = head;
            current = dummy;

            while (current.next != null && current.next.next != null)
            {
                ListNode first = current.next;
                ListNode second = current.next.next;
                first.next = second.next;
                current.next = second;
                current.next.next = first;
                current = current.next.next;
            }
            return dummy.next;
        }


    }
}
