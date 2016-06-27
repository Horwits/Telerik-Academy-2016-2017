function solve(args) {
    var array = args[0].split("\n").map(Number),
        counter = 1,
        temp = +array[0],
        max = 0,
        len = array.length;

    for (var i = 1; i < len; i += 1) {
        if (+array[i] > temp) {
            counter += 1;
        } else {
            counter = 1;
        }

        temp = +array[i];

        if (max < counter) {
            max = counter;
        }
    }

    console.log(max);
}

solve(['8', '7', '3', '2', '3', '4', '2', '2', '4']);