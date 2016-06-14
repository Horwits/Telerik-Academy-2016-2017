function solve(args) {
    'use strict';

    var number = args[0],
        isOdd = Math.abs(number) % 2 == 1;

    if (isOdd) {
        return "odd " + number;
    } else {
        return "even " + number;
    }
}

//console.log(solve([-1]));