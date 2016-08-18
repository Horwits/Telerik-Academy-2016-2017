/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(from, to) {
    var primes = [],
        i = 0;

    //if some of the params is missing it will try isNaN(undefined) and will enter the if case
    if (isNaN(+from) || isNaN(+to)) {
        throw new Error();
    }

    for (i = from; i <= to; i++) {
        if (isPrime(i)) {
            primes.push(i);
        }
    }

    function isPrime(num) {
        var end = Math.sqrt(num);

        if (num < 2) return false;

        for (var j = 2; j <= end; j++) {
            if (num % j == 0)
                return false;
        }
        
        return true;
    }

    return primes;
}

module.exports = findPrimes;
