function solve(args) {
    'use strict';
    var a = +args[0],
        b = +args[1],
        c = +args[2];

    if (a == b && b == c) {
        return a + " " + b + " " + c;
    }
    else if (a >= b && a >= c) {
        if (b >= c) {
            return a + " " + b + " " + c;
        }
        else {
            return a + " " + c + " " + b;
        }
    }
    else if (b >= a && b >= c) {
        if (a >= c) {
            return b + " " + a + " " + c;
        }
        else {
            return b + " " + c + " " + a;
        }
    }
    else if (c >= a && c >= b) {
        if (a >= b) {
            return c + " " + a + " " + b;
        }
        else {
            return c + " " + b + " " + a;
        }
    }
}

console.log(solve([0, -2.5, 5]));
console.log(solve([-1.1, -0.5, -1.1]));
console.log(solve([-4, -4, 4]));
console.log(solve([-4, -4, 4]));
console.log(solve([-4, -4, 4]));