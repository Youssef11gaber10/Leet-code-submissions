/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
     public ListNode DetectCycle(ListNode head)
 {
     ListNode fast = head;
     ListNode slow = head;

     while (fast != null && fast.next != null)
     {
         slow = slow.next;
         fast = fast.next.next;
         if(slow == fast)
         {
             break;
         }
     }
     if (fast == null || fast.next == null)
         return null;
     //if not returned so we have cycle start to count the start of it
     slow = head;
     while(slow != fast)
     {
         slow = slow.next;
         fast = fast.next;

     }
     return slow;
 }
}