/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoList(ListNode l1,ListNode l2) {
        ListNode dummy=new ListNode(0);
        ListNode p =dummy;
        while(l1!=null&&l2!=null){
            if(l1.val<l2.val){
                p.next=l1;
                l1=l1.next;
            }
            else{
                p.next=l2;
                l2=l2.next;
            }
            p=p.next;
        }
        p.next=l1!=null?l1:l2;
        return dummy.next;
    }
   public ListNode MergeKLists(ListNode[] lists) {
    if(lists.Length==0) return null;

    while(lists.Length>1){
                    int mergedSize = (lists.Length + 1) / 2;
            ListNode[] merged = new ListNode[mergedSize];
            for (int i = 0; i < mergedSize; i++) {
                int index1 = i * 2;
                int index2 = i * 2 + 1;
                ListNode l1 = lists[index1];
                ListNode l2 = (index2 < lists.Length) ? lists[index2] : null;
                merged[i]=MergeTwoList(l1,l2);
        }
            lists = merged;
        }
        
        return lists[0];
    }
}