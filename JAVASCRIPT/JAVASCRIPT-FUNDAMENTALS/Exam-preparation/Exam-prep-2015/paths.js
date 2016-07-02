function solve(params) {
    var rowsAndCols = params[0]
        .split(' ')
        .map(Number),
        directions = [];

    //generate directions
    for (var i = 1; i < rowsAndCols[0] + 1; i += 1) {
        directions[i - 1] = params[i].split(' ');
    }

    //generate new matrix
    var numbers = [];
    for (i = 0; i < rowsAndCols[0]; i += 1) {
        numbers[i] = [];
        for (var j = 0; j < rowsAndCols[1]; j += 1) {
            var nums = 0;
            if (j === 0) {
                nums = Math.pow(2, j + i);
                numbers[i][j] = nums;
            } else {
                numbers[i][j] = numbers[i][0] + j;
            }
        }
    }

    var path = {
        x: 0,
        y: 0
    };

    function dir(path, dir) {

        switch (dir) {
            case 'dr':
                path.x += 1;
                path.y += 1;
                break;
            case 'dl':
                path.x -= 1;
                path.y += 1;
                break;
            case 'ul':
                path.x -= 1;
                path.y -= 1;
                break;
            case 'ur':
                path.x += 1;
                path.y -= 1;
                break;
        }
    }

    var counter = 1;
    var sum = numbers[path.y][path.x];
    numbers[path.y][path.x] = 'V';

    while (true) {

        dir(path, directions[path.y][path.x]);

        if ((rowsAndCols[1] <= path.x || path.x < 0) || (rowsAndCols[0] <= path.y || path.y < 0)) {
            return "successed with " + sum; //sum
        }

        if (numbers[path.y][path.x] === 'V') {
            return 'failed at ('+path.y +', '+ path.x + ')';
        }

        sum += numbers[path.y][path.x];

        numbers[path.y][path.x] = 'V';
    }
}

var test = [
    '3 5',
    'dr dl dr ur ul',
    'dr dr ul ur ur',
    'dl dr ur dl ur'
];

args = [
  '3 5',
  'dr dl dl ur ul',
  'dr dr ul ul ur',
  'dl dr ur dl ur'   
];

console.log(solve(test)); 

console.log(solve(args)); 