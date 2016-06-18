function solve(args) {
    var min = +args[0],
        max = +args[0],
        sum = +args[0],
        avrg;

    for (var index = 1; index < args.length; index++) {
        var element = +args[index];
        if (min > element) {
            min = element;
        }

        if (element > max) {
            max = element;
        }

        sum += element;
    }

    avrg = sum / args.length;
    console.log("min=" + min.toFixed(2));
    console.log("max=" + max.toFixed(2));
    console.log("sum=" + sum.toFixed(2));
    console.log("avg=" + avrg.toFixed(2));
}

solve([2, 5, 1]);
solve([2, -1, 4]);