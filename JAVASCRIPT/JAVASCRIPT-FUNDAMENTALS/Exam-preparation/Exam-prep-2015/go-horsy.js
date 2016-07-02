// 100/100

function solve(args) {
    var rowsAndCols = args[0].split(' ').map(Number),
        Rows = rowsAndCols[0],
        Cols = rowsAndCols[1];
        //directions = [];

    //read directions
    // for (var i = 1; i < Rows + 1; i += 1) {
    //     directions.push(args[i]);
    // }

    var horse = {
        x: Cols - 1,
        y: Rows - 1,
    };

    //movement
    function movement(horse, number) {
        if (number === '1') {
            horse.x += 1;
            horse.y -= 2;
        } else if (number === '2') {
            horse.x += 2;
            horse.y -= 1;
        } else if (number === '3') {
            horse.x += 2;
            horse.y += 1;
        } else if (number === '4') {
            horse.x += 1;
            horse.y += 2;
        } else if (number === '5') {
            horse.x -= 1;
            horse.y += 2;
        } else if (number === '6') {
            horse.x -= 2;
            horse.y += 1;
        } else if (number === '7') {
            horse.x -= 2;
            horse.y -= 1;
        } else {
            horse.x -= 1;
            horse.y -= 2;
        }
    }

    // generate the same sized matrix
    function generateValues(rows, cols) {
        var result = [];

        for (var i = 0; i < rows; i += 1) {
            result[i] = [];
            for (var j = 0; j < cols; j += 1) {
                if (j === 0 && i === 0) {
                    result[i][j] = 1;
                } else if (j === 0 && i !== 0) {
                    result[i][j] = 1 << i;
                } else {
                    result[i][j] = result[i][0] - j;
                }
            }
        }

        return result;
    }

    var matrix = generateValues(Rows, Cols),
        sum = matrix[horse.y][horse.x],
        jumps = 1;

    matrix[horse.y][horse.x] = 'X';
    while (true) {

        var currDir = args[horse.y + 1][horse.x];
        movement(horse, currDir);

        if (horse.x < 0 || horse.x >= Cols || horse.y < 0 || horse.y >= Rows) {
            //console.log(`Go go Horsy! Collected ${sum} weeds`);
            console.log("Go go Horsy! Collected " + sum + " weeds");
            return;
        }

        if (matrix[horse.y][horse.x] === 'X') {
            //console.log(`Sadly the horse is doomed in ${jumps} jumps`);
            console.log("Sadly the horse is doomed in " + jumps + " jumps");
            return;
        }

        sum += matrix[horse.y][horse.x];
        matrix[horse.y][horse.x] = 'X';
        jumps += 1;
    }
}

var args = [
    '3 5',
    '54561',
    '43328',
    '52388',
];

args = [
    '3 5',
    '54361',
    '43326',
    '52188',
];

solve(args);