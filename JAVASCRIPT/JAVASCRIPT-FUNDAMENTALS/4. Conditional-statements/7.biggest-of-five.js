function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    var d = +args[3];
    var e = +args[4];
    var biggest = 0;

    if (a >= b && a >= c && a >= d && a >= e) {
        biggest = a;
    }
    else if (b >= a && b >= c && b >= d && b >= e) {
        biggest = b;
    }
    else if (c >= a && c >= b && c >= d && c >= e) {
        biggest = c;
    }
    else if (d >= a && d >= b && d >= c && d >= e) {
        biggest = d;
    }
    else {
        biggest = e;
    }

    return biggest;
}

console.log(solve([5, 2, 2, 4, 1]));