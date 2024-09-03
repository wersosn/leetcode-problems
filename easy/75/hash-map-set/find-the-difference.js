//Find the Difference of Two Arrays
//Solution: Find unique elements from two arrays that do not appear in the other using sets for fast lookup
//Time-complexity: O(n + m)
var findDifference = function (nums1, nums2) {
    let dif1 = [], dif2 = []; //create 2 arrays to store the differences
    //convert the input arrays to sets to remove duplicates
    let n1 = new Set(nums1);
    let n2 = new Set(nums2);
    //iterate through the first set to find elements that are not in the second set
    for (let i of n1) {
        if (!n2.has(i)) {
            dif1.push(i);
        }
    }
    //iterate through the second set to find elements that are not in the first set
    for (let i of n2) {
        if (!n1.has(i)) {
            dif2.push(i);
        }
    }
    //return the differences as a pair of arrays
    let answer = [dif1, dif2];
    return answer;
};

//Case 1:
nums1 = [1,2,3], nums2 = [2,4,6];
console.log(`Result for case 1: [${findDifference(nums1, nums2)}]`);

//Case 2:
nums1 = [1,2,3,3], nums2 = [1,1,2,2];
console.log(`Result for case 2: [${findDifference(nums1, nums2)}]`);
