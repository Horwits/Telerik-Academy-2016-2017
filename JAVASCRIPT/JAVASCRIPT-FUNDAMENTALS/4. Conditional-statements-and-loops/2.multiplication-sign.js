function solve(args) {
    'use strict';
    var a = args[0],
        b = args[1],
        c = args[2];

    if (a * b * c > 0) {
        return "+";
    } else if (a * b * c < 0) {
        return "-";
    } else {
        return 0;
    }
}

console.log(solve([-1, -4, -2]));