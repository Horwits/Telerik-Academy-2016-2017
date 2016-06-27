function solve(args) {
    //var input = (args + '').split('\n').map(Number),
     var input = args.map(Number),
        n = input[0],
        x = input[input.length - 1],
        numbers = input.slice(1, n + 1);

    var position = binarySearch(numbers, x, 0, n);

    function binarySearch(array, value, left, right) {
        while (left <= right) {
            var middle = parseInt((left + right) / 2);
            if (array[middle] == value) {
                return middle;
            }
            else if (array[middle] > value) {
                right = middle - 1;
            }
            else {
                left = middle + 1;
            }
        }
        return -1;
    }

    console.log(position);
}

var test = ['10', '1', '2', '4', '8', '16', '31', '32', '64', '77', '99', '32'];

solve(test);