function solve(args) {
    var lines = (args[0] + '')
        .split('\n'),
        numbers = lines[1]
            .split(' ')
            .map(Number),
        n = lines[0],
        x = lines[n + 1],
        maxOcc = 0,
        currentOcc = 1;

    for (var i = 0; i < n; i += 1) {
        if (i + 1 < n) {
            if (numbers[i + 1] === numbers[i]) {
                currentOcc += 1;
            } else {
                currentOcc = 1;
            }
        }

        if (currentOcc > maxOcc) {
            maxOcc = currentOcc;
        }
    }

    return maxOcc;
}

var test = [
    '8\n286 21 6 -7856 73 73 -56\n73'
];

var test2 = [
    '8\n28\n6\n21\n6\n-7856\n73\n73\n-56\n73'
];


console.log(solve(test));

function testSolve(params) {
    console.log(solve(test) === 2);
}

testSolve();