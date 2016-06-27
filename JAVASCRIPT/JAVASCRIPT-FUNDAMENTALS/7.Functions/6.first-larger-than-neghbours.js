function solve(args) {
    var lines = args[0].split('\n'),
        n = +lines[0],
        numbers = lines[1].split(' ').map(Number);

    for (var i = 1; i < n; i += 1) {
        if (i - 1 >= 0 && i + 1 < n) {
            if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1]) {
                return i;
            }
        }
    }

    return - 1;
}

var test = ['6\n-26 55 45 31 2 27']

console.log(solve(test)); 