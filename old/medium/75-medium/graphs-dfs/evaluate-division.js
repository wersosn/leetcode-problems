//Evaluate Division
//Solution: Use a graph representation to store the variable pairs and their corresponding values
//Time complexity: O(n*(v+e))
//I used here solution by user Rajat310 (https://leetcode.com/problems/evaluate-division/solutions/3546365/dfs-graph-js-sol-explained-with-approach)
var calcEquation = function (equations, values, queries) {
    let graph = {}; //create an empty graph to represent relationships between variables
    let n = equations.length; //number of equations provided
    let result = []; //initialize the array that will store the results for each query

    for (let i = 0; i < n; i++) { //Step 1: build the graph
        let [num, denom] = equations[i]; //deconstruct the equation into numerator and denominator
        let val = values[i]; //current value for num/denom

        if (!graph[num]) { //if the numerator doesn't exist in the graph: 
            graph[num] = {}; //create an empty object for it
        }

        if (!graph[denom]) { //if the denominator doesn't exist in the graph: 
            graph[denom] = {}; //create an empty object for it
        }

        graph[num][denom] = val; //set the value of the direct relationship num/denom = val
        graph[denom][num] = 1 / val; //set the reverse relationship denom/num = 1/val (since denom = num/val)
    }

    let dfs = function (num, denom, visited) { //Step 2: implement DFS to find a path from 'num' to 'denom'
        if (!(num in graph) || !(denom in graph)) { //if either 'num' or 'denom' is not in the graph
            return -1; //there's no valid path (variable is unknown) - return -1.0
        }

        if (num === denom) { //if the numerator and denominator are the same
            return 1; //return x/x = 1
        }

        visited.push(num); //mark 'num' as visited to avoid cycles
        let neighbors = graph[num]; //get all neighbors of the current 'num'

        for (let n in neighbors) { //traverse all neighboring nodes
            if (!visited.includes(n)) { //if current node hasn't been visited
                let result = dfs(n, denom, visited); //perform DFS recursively to find the path to 'denom'
                if (result !== -1) { //if a valid path is found
                    return neighbors[n] * result; //multiply the values along the path
                }
            }
        }
        return -1; //if no valid path was found - return -1.0
    }

    for (let q of queries) { //Step 3: process each query
        let [num, denom] = q; //deconstruct the query into numerator and denominator
        let visited = []; //create a visited array for the DFS call
        let res = dfs(num, denom, visited); //get the result for this query using DFS

        result.push(res); //push the result to the results array
    }
    return result;
};

//Case 1:
equations = [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]];
console.log(`Result for case 1: [${calcEquation(equations, values, queries)}]`);

//Case 2:
equations = [["a","b"],["b","c"],["bc","cd"]], values = [1.5,2.5,5.0], queries = [["a","c"],["c","b"],["bc","cd"],["cd","bc"]];
console.log(`Result for case 2: [${calcEquation(equations, values, queries)}]`);

//Case 3:
equations = [["a","b"]], values = [0.5], queries = [["a","b"],["b","a"],["a","c"],["x","y"]];
console.log(`Result for case 3: [${calcEquation(equations, values, queries)}]`);

//Notes for myself, because I had absolutely no idea how I should have approached this problem (the explanation is in Polish)
/*Step 1: 
    Graf jest używany do reprezentowania relacji między zmiennymi w postaci równań.
    Każde równanie num / denom = value oznacza krawędź między dwoma węzłami num i denom, gdzie wagi krawędzi to wartość value dla kierunku num -> denom oraz 1/value 
    dla odwrotnego kierunku denom -> num.
  Step 2: 
    Używamy DFS do znajdowania ścieżki od num do denom. DFS przeszukuje graf w poszukiwaniu sąsiadów num, próbując dotrzeć do denom.
    Podczas przeszukiwania DFS unika odwiedzania tych samych węzłów wielokrotnie (poprzez visited), aby zapobiec nieskończonym pętlom.
    Jeśli ścieżka istnieje, DFS zwraca wynik, który jest iloczynem wartości krawędzi na tej ścieżce.
  Step 3:
    Dla każdego zapytania queries[i] = [num, denom], DFS próbuje znaleźć wartość num / denom.
    Jeśli taka ścieżka istnieje w grafie, zwracany jest wynik; jeśli nie, zwracane jest -1.
*/