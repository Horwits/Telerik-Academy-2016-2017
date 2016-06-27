function solve(args) {
    var numbers = args[0].split(' ').map(Number);

    function getMax(x, y) {
        if (x >= y) {
            return x;
        } else {
            return y;
        }
    }

    var max = getMax(numbers[0], numbers[1]);
    console.log(getMax(max, numbers[2]));
}

var test = ['8 3 6'];
solve(test);