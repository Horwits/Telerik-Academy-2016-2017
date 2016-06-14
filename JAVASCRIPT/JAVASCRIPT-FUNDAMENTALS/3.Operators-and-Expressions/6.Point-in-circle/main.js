function solve(args) {
    var xPowTwo = Math.pow(args[0], 2),
        yPowTwo = Math.pow(args[1], 2),
        radiusPowTwo = Math.pow(2, 2),
        distance = Math.sqrt(xPowTwo + yPowTwo),
        isInsideCircle = distance <= 2 * 2;

    return isInsideCircle ? "yes " + distance.toFixed(2) : "no " + distance.toFixed(2);
}

//console.log(solve([-1, 2]));