//Solution: Merge two arrays into one, sort it in ascending order and find the median
//Time complexity: O((m + n) log (m + n))
var findMedianSortedArrays = function (nums1, nums2) {
    let result, newArr;
    if (nums1 === null) { //if nums1 is null, use nums2 as the new array
        newArr = nums2;
    }
    else if (nums2 === null) { //if nums2 is null, use nums1 as the new array
        newArr = nums1;
    }
    else { //if both arrays are not null, concatenate nums1 and nums2
        newArr = nums1.concat(nums2);
    }

    newArr.sort(function (a, b) { //sort the concatenated array in ascending order
        return a - b;
    });

    if (newArr.length === 1) { //if there's only one element -> it's the median
        result = newArr[0];
        return result;
    }

    let median = newArr.length;
    if (median % 2 === 0) { //if the length of the array is even -> calculate the average of the two middle values
        let mid1 = newArr[Math.floor(median / 2) - 1]; //find the lower middle element
        let mid2 = newArr[Math.floor(median / 2)]; //find the highest middle element
        result = (mid1 + mid2) / 2; //calculate average of this two middle values
    }
    else { //if the length of the array is odd -> take the middle element as the median
        result = newArr[Math.floor(median / 2)]; //find the highest middle element
    }

    return result;
};

//Case 1:
nums1 = [1, 3], nums2 = [2];
console.log(`Result for case 1: ${findMedianSortedArrays(nums1, nums2)}`);

//Case 2:
nums1 = [1, 2], nums2 = [3, 4];
console.log(`Result for case 2: ${findMedianSortedArrays(nums1, nums2)}`);
