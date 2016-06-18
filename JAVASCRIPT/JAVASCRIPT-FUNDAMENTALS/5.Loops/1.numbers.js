function solve(args) {
    var len = +args[0],
        printOut = "",
        i;

    for (i = 1; i <= len; i += 1) {
        printOut += i;
        if (i !== len) {
            printOut += " ";
        }
    }

    return printOut;
}

console.log(solve([6]));