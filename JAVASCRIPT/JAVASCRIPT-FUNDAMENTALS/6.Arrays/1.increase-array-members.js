function solve(args) {
    var length = +args[0],
        i = 0,
        result = [];

    for (i = 0; i < length; i += 1) {
        result.push(i * 5);
    }

    console.log(result.join('\n'));
}

solve(['5']);