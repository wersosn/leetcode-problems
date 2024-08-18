//Thirtieth problem from '30 days of JavaScript' - Calculator with Method Chaining:
//Time complexity: O(1)
class Calculator {
    constructor(value) {
        this.result = value;
    }

    add(value){ //this method adds the given number value to the result and returns the updated Calculator.
       this.result += value;
       return this;
    }

    subtract(value){ //this method subtracts the given number value from the result and returns the updated Calculator.
        this.result -= value;
        return this;
    }

    multiply(value) { //this method multiplies the result  by the given number value and returns the updated Calculator.
        this.result *= value;
        return this;
    }

    divide(value) { //this method divides the result by the given number value and returns the updated Calculator
        if(value === 0) { //if the passed value is 0, an error "Division by zero is not allowed" should be thrown.
            throw new Error("Division by zero is not allowed");
        }
        else {
           this.result /= value;
           return this;
        }
    }

    power(value) { //this method raises the result to the power of the given number value and returns the updated Calculator.
        this.result = Math.pow(this.result, value);
        return this;
    }
    
    getResult() { //this method returns the result.
        return this.result;
    }
}

//Case 1:
let result = new Calculator(10).add(5).subtract(7).getResult();
console.log(`Result for case 1: ${result}`);

//Case 2:
let result2 = new Calculator(2).multiply(5).power(2).getResult();
console.log(`Result for case 2: ${result2}`);

//Case 3:
let result3 = new Calculator(20).divide(0).getResult();
console.log(`Result for case 3: ${result3}`);