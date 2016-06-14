function solve(args) {
    'use strict';

    var number = args[0] | 0,
        isDivisibleBySevenAndFive = Math.abs(number) % 5 === 0 && Math.abs(number) % 7 === 0;

    if (isDivisibleBySevenAndFive) {
        return "true " + number;
    } else {
        return "false " + number;
    }
}

//console.log(solve([140]));