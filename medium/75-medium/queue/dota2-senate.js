//Number of Recent Calls
//Solution: Compare senators and eliminate opposition senators until one side wins
//Time-complexity: O(n)
//I used here the explanation of the problem from user santosh-setty (https://leetcode.com/problems/dota2-senate/solutions/3483505/step-by-step-guide-javascript-code-with-comments-and-detailed-explanation)
var predictPartyVictory = function (senate) {
    let radiant = [], dire = []; //initialize 2 arrays to store the indices of the senators from each party

    for (let i = 0; i < senate.length; i++) { //loop through the string
        if (senate[i] === 'R') { //if current senate is 'R'
            radiant.push(i + senate.length); //add current index to radiant array
        }
        else if (senate[i] === "D") { //else ig current senate is 'D'
            dire.push(i + senate.length); //add current index to dire array
        }
    }

    while (radiant.length > 0 && dire.length > 0) { //loop until one of the arrays is empty and compare the index of the first senator from each party
        if (radiant[0] < dire[0]) { //if the index of the first radiant senator is smaller than that of the first dire senator
            radiant.push(radiant[0] + senate.length); //add the index of the next radiant senator to the end of the radiant array
        }
        else if (radiant[0] > dire[0]) { //else if the index of the first dire senator is smaller than that of the first radiant senator
            dire.push(dire[0] + senate.length); //add the index of the next dire senator to the end of the dire array
        }
        radiant.shift(); //remove the first element from radiant array
        dire.shift(); //remove the first element from dire array
    }

    if (radiant.length > 0) { //if radiant array is not empty
        return "Radiant"; //announce the victory of the Radiant party
    }
    else { //if dire array is not empty
        return "Dire"; //announce the victory of theDire party
    }
};

//Case 1:
senate = "RD";
console.log(`Result for case 1: ${predictPartyVictory(senate)}`);

//Case 2:
senate = "RDD";
console.log(`Result for case 2: ${predictPartyVictory(senate)}`);