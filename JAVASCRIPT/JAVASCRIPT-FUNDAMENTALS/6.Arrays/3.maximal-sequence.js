function solve(args) {
    var array = args[0].split("\n").map(Number),
        counter = 1,
        temp = +array[0],
        max = 0,
        len = array.length;

    for (var i = 1; i < len; i += 1) {
        if (+array[i] !== temp) {
            temp = +array[i];
            counter = 1;
        } else {
            counter += 1;
        }

        if (max < counter) {
            max = counter;
        }
    }

    console.log(max);
}

solve(['10', '2', '1', '1', '2', '3', '3', '2', '2', '2', '1']);