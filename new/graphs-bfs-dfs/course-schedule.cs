// Pattern: Topological sort using Kahn's algorithm (BFS with indegrees).
// When to use: To determine whether all tasks or courses with dependencies can be completed.
// Complexity: O(V + E) time and O(V + E) space, where V is the number of courses and E is the number of prerequisites.

public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        if(numCourses < 0 || prerequisites == null) {
            return false;
        }

        List<int>[] graph = new List<int>[numCourses];
        Queue<int> queue = new Queue<int>();
        int[] indegree = new int[numCourses];
        int completed = 0;

        for(int i = 0; i < numCourses; i++) {
            graph[i] = new List<int>();
        }

        foreach(int[] p in prerequisites) {
            int course = p[0];
            int preCourse = p[1];
            graph[preCourse].Add(course);
            indegree[course]++;
        }

        for(int i = 0; i < numCourses; i++) {
            if(indegree[i] == 0) {
                queue.Enqueue(i);
            }
        }

        while(queue.Count > 0) {
            int course = queue.Dequeue();
            completed++;
            foreach(var nextCourse in graph[course]) {
                indegree[nextCourse]--;
                if(indegree[nextCourse] == 0) {
                    queue.Enqueue(nextCourse);
                }
            }
        }

        if(completed == numCourses) {
            return true;
        }
        else {
            return false;
        }
    }
}


// Cases:
class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        //Case 1:
        var result1 = solution.CanFinish(2, [[1,0]]);
        Console.WriteLine("Result for case 1: " + result1);

        //Case 2:
        var result2 = solution.CanFinish(2, [[1,0], [0,1]]);
        Console.WriteLine("Result for case 2: " + result2);
    }
}