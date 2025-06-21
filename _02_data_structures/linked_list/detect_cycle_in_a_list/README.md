# Linked List Cycle

Given `head`, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the `next` pointer.

Return `true` if there is a cycle, and `false` otherwise.

---

## Example 1

**Input:**
`head = [3, 2, 0, -4]`, where `pos = 1` (The tail's `next` pointer connects to the node at index 1)

**Output:**
`true`

## Example 2

**Input:**
`head = [1, 2]`, where `pos = 0`

**Output:**
`true`

## Example 3

**Input:**
`head = [1]`, where `pos = -1` (no cycle)

**Output:**
`false`

---

## Constraints

- The number of the nodes in the list is in the range `[0, 10^4]`.
- `-10^5 <= Node.val <= 10^5`
- `pos` is `-1` or a valid index in the linked-list.

---

## Follow-up

Can you solve it using `O(1)` (i.e. constant) memory?
