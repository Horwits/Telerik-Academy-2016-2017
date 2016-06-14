function solve(args) {
    var a = parseFloat(args[0]),
        b = parseFloat(args[1]),
        h = parseFloat(args[2]),
        area = (a + b) / 2 * h;

    return area.toFixed(7);
}
console.log(solve([8.5, 4.3, 2.7]));
//console.log(solve(["8.5", "4.3", "2.7"]));