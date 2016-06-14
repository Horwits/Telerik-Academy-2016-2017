function solve(args) {
    var number = args[0],
        position = 3,
        mask = 1 << position,
        nAndMask = number & mask,
        bit = nAndMask >> position;

    return bit;
}

console.log(solve([1024]));