function solve(params) {
    'use strict';
    var n = +params[0],
        answer = 1,
        numbersArray = [],
        counter = 0,
        i,
        j,
        k,
        len;
        
    // Your code here...
    for (i = 1; i <= n; i += 1) {
        numbersArray.push(+params[i]);
    }

    for (j = 0, len = numbersArray.length; j < len; j += 1) {
        k = j + 1;
        if (k <= len) {
            if (numbersArray[k] < numbersArray[j]) {
                //counter += 1;
                //if (counter === 1) {
                answer += 1;
                //}
            }
        }
        //counter = 0;
    }
    return answer;
}

var test = [
    '7',
    '1',
    '2',
    '-3',
    '4',
    '4',
    '0',
    '1',
];


test = [
    '6',
    '1',
    '3',
    '-5',
    '8',
    '7',
    '-6',
];

console.log(solve(test));

var test = [
    '9',
    '1',
    '8',
    '8',
    '7',
    '6',
    '5',
    '7',
    '7',
    '6',
];
