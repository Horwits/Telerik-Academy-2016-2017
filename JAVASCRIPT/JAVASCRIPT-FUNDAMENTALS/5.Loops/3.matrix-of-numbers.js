function solve(args) {
    var n = +args[0],
        i = 0,
        j = 0,
        print = "",
        specialCounter;

    for (i = 0; i < n; i += 1) {
        print += i + 1;
        specialCounter = i + 2;
        for (j = 0; j < n - 1; j += 1) {
            print += " ";
            print += specialCounter;
            specialCounter += 1;
        }

        print += "\n";
    }

    console.log(print);
}

solve([2]);
solve([3]);
solve([4]);