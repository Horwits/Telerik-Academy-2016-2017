function solve(args) {
    var number = args[0],
        thirdDigit = parseInt(number / 100) % 10;
        isSeven = thirdDigit == 7;

    if (isSeven) {
        return "true";
    } else {
        return "false " + thirdDigit;
    }
}

//console.log(solve([877]));