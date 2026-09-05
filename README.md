# LeetCode Solutions
This repository contains my solutions to LeetCode problems, covering two distinct phases of my learning process.

- **[`old/`](/old)** - solutions from 2024, written mostly in JavaScript, organized by difficulty and study plan. Kept as an archive of earlier progress.
- **[`new/`](/new)** - current solutions, written in C#, organized **by algorithmic pattern** rather than difficulty. The goal here isn't just solving individual problems, but building a personal reference of recognizable patterns that transfer to new, unseen problems.

## Why the restructure
The earlier approach (organized by difficulty and pre-made study plans) worked well for working through structured problem sets. The current approach has a different goal: recognizing *which pattern applies* to a given problem, not just recalling a specific solution. Grouping by pattern makes it easier to review one concept at a time and see how it applies across multiple problems.

## `new/` - Pattern-based practice (2026, C#)

Each folder corresponds to one algorithmic pattern. Every solution file includes a short comment explaining when the pattern applies and its time/space complexity, so the folder works as a personal pattern reference, not just a solution dump.

| Folder | Pattern | Example problems |
|---|---|---|
| [`arrays-hashmap`](/new/arrays-hashmap) | Storing state in a Dictionary/HashSet to avoid re-scanning | Two Sum, Contains Duplicate, Group Anagrams |
| [`two-pointers`](/new/two-pointers) | Two pointers moving through a structure from different ends or speeds | 3Sum, Container With Most Water |
| [`sliding-window`](/new/sliding-window) | A window that expands/shrinks dynamically over a sequence | Longest Substring Without Repeating Characters |
| [`stack`](/new/stack) | LIFO structure for tracking "open" elements or reversing order | Valid Parentheses, Daily Temperatures |
| [`binary-search`](/new/binary-search) | Repeatedly halving the search space | Search in Rotated Sorted Array |
| [`linked-list`](/new/linked-list) | Pointer manipulation on linked structures | Reverse Linked List, Reorder List |
| [`trees`](/new/trees) | DFS/BFS traversal and recursion on trees | Validate BST, Level Order Traversal |
| [`graphs-bfs-dfs`](/new/graphs-bfs-dfs) | Traversing graphs, detecting cycles, connectivity | Number of Islands, Course Schedule |
| [`backtracking`](/new/backtracking) | Exploring choices with the ability to undo them | Subsets, Permutations |
| [`dynamic-programming`](/new/dynamic-programming) | Breaking a problem into overlapping subproblems | Climbing Stairs, Coin Change |

Example of the comment style used at the top of each new solution file:
```csharp
// Pattern: Hashmap for tracking "what I've seen so far"
// When to use: for each element, I'm looking for something related to another element
// Complexity: O(n) time, O(n) space

public int[] TwoSum(int[] nums, int target) {
    // ...
}
```

## Progress
- [x] Arrays & Hashmap
- [x] Two Pointers
- [x] Sliding Window
- [x] Stack
- [ ] Binary Search
- [ ] Linked List
- [ ] Trees
- [ ] Graphs (BFS/DFS)
- [ ] Backtracking
- [ ] Dynamic Programming

## `old/` - Archive (2024)
Solutions mostly in JavaScript/TypeScript, plus SQL, organized by difficulty and original LeetCode study plans.

### Easy
- **Standalone problems:**
  - Two Sum [(JavaScript version)](/old/easy/two-sum.js), [(C# version)](/old/easy/two-sum.cs)
  - Palindrome number [(JavaScript version)](/old/easy/palindrome-number.js), [(TypeScript version)](/old/easy/palindrome-number.ts)
  - Score of a string [(JavaScript version)](/old/easy/score-of-a-string.js)
  - Search insert position [(JavaScript version)](/old/easy/search-insert-position.js)
  - Longest common prefix [(JavaScript version)](/old/easy/longest-common-prefix.js)
  - Roman to integer [(JavaScript version)](/old/easy/roman-to-integer.js)
- **[30 Days of JavaScript](/old/easy/30-days-of-javascript)** - ~20 problems focused on core JavaScript concepts (closures, promises, array methods, function composition)
- **[LeetCode 75 – Easy](/old/easy/75)** - ~17 problems already grouped by topic: array/string, two pointers, sliding window, prefix sum, hash map/set, linked list, binary tree DFS, binary search tree, queue
- **[SQL 50 – Easy](/old/easy/sql-50)** - ~32 SQL query problems (joins, aggregations, filtering)

### Medium
- **Standalone problems:**
  - Add two numbers [(JavaScript version)](/old/medium/add-two-numbers.js)
- **[30 Days of JavaScript – Medium](/old/medium/30-days-of-js-medium)** - ~10 problems covering more advanced JS concepts (debounce, memoize, event emitter, async patterns)
- **[LeetCode 75 – Medium](/old/medium/75-medium)** - ~31 problems grouped by topic: array/string, two pointers, sliding window, stack, hash map/set, linked list, binary tree BFS/DFS, binary search tree, graphs BFS/DFS, queue
- **[SQL 50 – Medium](/old/medium/sql-50-medium)** - ~17 SQL query problems (window functions, subqueries, more complex joins)

### Hard
- **Standalone problems:**
  - Median of two sorted arrays [(JavaScript version)](/old/hard/median-of-two-sorted-arrays.js)
- **[SQL 50 – Hard](/old/hard/sql-50-hard)** - 1 problem (advanced ranking/window functions)

## How to use
```bash
git clone https://github.com/wersosn/leetcode-problems.git
```

## Contributions
This repository is mainly for personal use, but suggestions are welcome.

## Links
LeetCode: [wersosn](https://leetcode.com/u/hYSsc9PjMo/)
