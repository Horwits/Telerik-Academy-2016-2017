function solve(args) {
    'use strict';
    var x = args[0];
    
    function checkIfIsPrime(number) {
        if (number < 0) return false;

        var boundary = Math.sqrt(number);

        if ((number === 0) || (number === 1)) return false;

        if (number == 2) return true;

        for (var i = 2; i <= boundary; i++) {
            if (number % i === 0)
                return false;
        }

        return true;
    }

    return checkIfIsPrime(x);
}

console.log(solve([23]));