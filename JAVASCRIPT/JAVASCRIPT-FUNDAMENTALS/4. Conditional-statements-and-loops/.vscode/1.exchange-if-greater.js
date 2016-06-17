function solve(args) {
    var a = args[0],
        b = args[1],
        aGreaterB = a > b;

    if (aGreaterB) {
        a ^= b;
        b ^= a;
        a ^= b;
    }

    return a + " " + b;
}

console.log(solve([5, 2]));