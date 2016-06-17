function solve(args) {
    var a = +args[0],
        b = +args[1],
        c = +args[2],
        sqrtPart = b * b - 4 * a * c,
        x, x1, x2;

    if (sqrtPart > 0) {
        x1 = (-b - Math.sqrt(sqrtPart)) / (2 * a);
        x2 = (-b + Math.sqrt(sqrtPart)) / (2 * a);
        return "x1=" + x1.toFixed(2) + "; " + "x2=" + x2.toFixed(2);
    }
    else if (sqrtPart < 0) {
        return "no real roots";
    }
    else {
        x = (-b + Math.sqrt(sqrtPart)) / (2 * a);
        return "x1=x2=" + x.toFixed(2);
    }
}

console.log(solve([2, 5, -3]));
console.log(solve([-0.5, 4, -8]));
console.log(solve([5, 2, 8]));