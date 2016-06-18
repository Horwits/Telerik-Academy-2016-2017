function solve(args) {
    var a = args[0],
        b = args[1],
        aGreaterB = a > b,
        temp;

    if (aGreaterB) {
        temp = a;
        a = b;
        b = temp;
    }

    return a + " " + b;
}

console.log(solve([6.6, 2.5]));