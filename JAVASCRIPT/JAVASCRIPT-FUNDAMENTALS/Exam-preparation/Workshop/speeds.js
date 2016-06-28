//has to be fixed

function solve(args) {
    var sizes = args[0]
        .split(' ')
        .map(Number);

    var w = sizes[0],
        h = sizes[1],
        d = sizes[2];

    function layerTo2DArray(layer) {
        var parsedLayer = layer
            .split(' | ')
            .map(function (row) {
                var result = row.split(')(');

                result[0] = result[0].replace('(', '');
                result[result.length - 1] = result[result.length - 1].replace(')', '');

                return result;
            });

        return parsedLayer;
    }

    function isInside(x, y) {
        return (0 <= x) && (x < w) && (0 <= y) && (y < d);
    }

    var deltas = {
        'L': { x: -1, y: 0 },
        'R': { x: 1, y: 0 },
        'F': { x: 0, y: 1 },
        'B': { x: 0, y: -1 },
    }

    var start = args[args.length - 1].split(' ').map(Number);

    var ball = {
        x: +start[0],
        y: +start[1],
        z: 0
    };

    var index = 1;
    var currentLayer = layerTo2DArray(args[index]);

    while (true) {


        var cmd = currentLayer[ball.y][ball.x];

        if (cmd[0] === 'E') {
            ball.z += 1;

            if (ball.z === (h - 1)) {
                console.log('Yes');
                console.log(ball.x + ' ' + ball.z + ' ' + ball.y);
                return;
            }
        } else if (cmd[0] === 'B') {
            console.log('No');
            console.log(ball.x + ' ' + ball.z + ' ' + ball.y);
            return;
        } else if (cmd[0] === 'T') {
            var telInfo = cmd
                .split(' ')
                .slice(1)
                .map(Number);

            ball.x = telInfo[0];
            ball.y = telInfo[1];
            continue;
        } else if (cmd[0] === 'S') {
            var dir = cmd.split(' ')[1];

            ball.x += deltas[dir[0]].x;
            ball.y += deltas[dir[0]].y;

            if (dir[1]) {
                ball.x += deltas[dir[1]].x;
                ball.y += deltas[dir[1]].y;
            }

            if (!isInside(ball.x, ball.y)) {
                ball.x -= deltas[dir[0]].x;
                ball.y -= deltas[dir[0]].y;

                if (dir[1]) {
                    ball.x -= deltas[dir[1]].x;
                    ball.y -= deltas[dir[1]].y;
                }

                console.log('No');
                console.log(ball.x + ' ' + ball.z + ' ' + ball.y);
                return;
            }

            ball.z += 1;

            if (ball.z === (h - 1)) {
                console.log('Yes');
                console.log(ball.x + ' ' + ball.z + ' ' + ball.y);
                return;
            }

        } else {
            console.log('wrong');
        }

        index += 1;
        currentLayer = layerTo2DArray(args[index]);
    }
}

var test = [
    '3 3 3', // w h d
    '(S L)(E)(S L) | (S L)(S R)(S L) | (B)(S F)(S L) ',
    '(S B)(S F)(E) | (S B)(S F)(T 1 1)  | (S L)(S R)(B)',
    '(S FL)(S FL)(S FR) | (S FL)(S FL)(S FR) | (S F)(S BR)(S FR)',
    '1 1'
];

solve(test);