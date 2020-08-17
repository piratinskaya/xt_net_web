'use strict';

let str = '3.5 +4*10-5.3 /5 =';


let numbers = getNum(str);
let operators = getOper(str);

function getNum(str) {
    let regNums = /\s*[\-\+\/\*=]\s*/;

    return str.split(regNums).filter(Boolean);
}

function getOper(str) {
    let regOper = /[\d\.=\s]+/;

    return str.split(regOper).filter(Boolean);
}

let j = 0;
let result = parseFloat(numbers[0]);
for (let i = 1; i < numbers.length; i++) {
    let curNum = parseFloat(numbers[i]);
    switch (operators[j++]) {
        case '+':
            result += curNum;
            break;
        case '-':
            result -= curNum;
            break;
        case '/':
            result /= curNum;
            break;
        case '*':
            result *= curNum;
            break;
        default:
            break;
    }
}

console.log(result.toFixed(2));

