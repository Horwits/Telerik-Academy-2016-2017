function solve(args) {
        var n = +args[0],
        numbers = args[1].split(' ').map(Number),
        counter = 0;

    for (var i = 1; i < n; i += 1) {
        if (i - 1 >= 0 && i + 1 < n) {
            if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1]) {
                counter += 1;
            }
        }
    }

    return counter;
}

var test = ['6','-26 -25 -28 31 2 27']

console.log(solve(test)); 