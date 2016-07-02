function solve(params) {
    'use strict';
    var N = parseInt(params[0]),
        K = parseInt(params[1]),
        numbers = params[2].split(' ').map(Number);

    // Your solution here
    var min = 1000000000,
        max = -1000000000,
        result = [];

    for (var i = 0; i < N - K + 1; i += 1) {
        min = 1000000000;
        max = -1000000000;

        for (var j = 0; j < K; j += 1) {

            min = Math.min(min, numbers[j + i]);
            max = Math.max(max, numbers[j + i]);
        }

        result.push(min + max);
    }
    console.log(result.join(','));
}

var test = [
    '4',
    '2',
    '1 3 1 8'
];


test = [
    '5',
    '3',
    '7 7 8 9 10'
];

test = [
    '8',
    '4',
    '1 8 8 4 2 9 8 11'
];

solve(test);