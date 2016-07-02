function solve(args) {
    var NMJ = args[0]
        .split(' ')
        .map(Number),
        startPos = args[1]
            .split(' ')
            .map(Number);

    var joro = {
        x: startPos[1],
        y: startPos[0]
    };

    //generate matrix
    var matrix = [];
    var elements = 1;
    for (var index = 0; index < NMJ[0]; index++) {
        matrix[index] = [];
        for (var cols = 0; cols < NMJ[1]; cols++) {
            matrix[index][cols] = elements;

            elements += 1;
        }
    }

    var sumOfNums = matrix[joro.y][joro.x],
        numOfJumps = 1;

    matrix[joro.y][joro.x] = 'X';

    for (index = 2; index < args.length; index++) {
        var jumps = args[index].split(' ').map(Number),
            jumpRows = jumps[0],
            jumpCols = jumps[1];

        joro.x += jumpCols;
        joro.y += jumpRows;

        if (joro.x < 0 || joro.x >= NMJ[1] || joro.y < 0 || joro.y >= NMJ[0]) {
            console.log('escaped ' + sumOfNums);
            break;
        }

        if (matrix[joro.y][joro.x] === 'X') {
            console.log('caught ' + numOfJumps);
            break;
        }

        sumOfNums += matrix[joro.y][joro.x];
        matrix[joro.y][joro.x] = 'X';

        numOfJumps += 1;

        if (index === args.length - 1) {
            index = 1;
        }
    }
}

var test = [
    '6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1'
];

solve(test);