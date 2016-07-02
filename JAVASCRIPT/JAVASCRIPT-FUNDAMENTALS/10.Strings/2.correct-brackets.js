function solve(params) {
    'use strict';
    let expr = params[0],
        indexOfOp = expr.indexOf('('),
        countOpen = 0,
        indexOfClose = expr.indexOf(')'),
        countClose = 0,
        areValid = true;

    while (true) {
        if (indexOfOp === -1 && indexOfClose === -1) {
            break;
        }

        if (indexOfOp > -1) {
            countOpen += 1;
        }

        if (indexOfClose > -1) {
            countClose += 1;
        }

        if (indexOfClose < indexOfOp) {
            areValid = false;
            break;
        }

        indexOfOp = expr.indexOf('(', indexOfOp + 1);
        indexOfClose = expr.indexOf(')', indexOfClose + 1);
    }

    if (countOpen === countClose) {
        if (areValid) {
            console.log('Correct');
        } else {
            console.log('Incorrect');
        }
    } else {
        console.log('Incorrect');
    }

}

var test = ['((a+b)/5-d)'];

test = ['(()(a+b))'];

solve(test);