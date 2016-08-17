/* window document console */
'use strict';

//radians -> 30gradus = 30*PI/180
function createGame(selector) {
    var canvas = document.querySelector(selector),
        ctx = canvas.getContext('2d'),
        isMouthOpen = false,
        pacman = {
            'x': 50,
            'y': 50,
            'size': 50,
            'speed': 3
        },
        dir = 0,
        keyCodeToDirs = {
            '39': 0,
            '40': 1,
            '37': 2,
            '38': 3
        },
        dirDeltas = [
            {
                'x': 1,
                'y': 0
            },
            {
                'x': 0,
                'y': 1
            },
            {
                'x': -1,
                'y': 0
            },
            {
                'x': 0,
                'y': -1
            }
        ],
        ball = {
            'x': 150,
            'y': 150,
            'size': 30
        }; // 0 -> r , 1-d, 2-l

    var steps = 0;
    const stepsToChangeMouth = 5;

    function drawBall(ballToDraw) {
        ctx.fillStyle = 'yellow';
        var x = ballToDraw.x + ballToDraw.size / 2;
        var y = ballToDraw.x + ballToDraw.size / 2;
        var size = ballToDraw.size / 2;
        ctx.beginPath();

        ctx.arc(x, y, size, 0, 2 * Math.PI);
        ctx.fill();
    }

    function drawPacman() {
        ctx.beginPath();

        if (isMouthOpen) {
            var deltaRadians = dir * Math.PI / 2;
            ctx.arc(pacman.x, pacman.y, pacman.size, deltaRadians + Math.PI / 4, deltaRadians + 7 * Math.PI / 4); // upper left angle
            ctx.lineTo(pacman.x, pacman.y);
        } else {
            ctx.arc(pacman.x, pacman.y, pacman.size, 0, 2 * Math.PI); // upper left angle
        }

        //pacman.x += 1;
        ctx.fill();
    }

    function updatePacmanPosition() {


        if (pacman.x < 0 || pacman.x > canvas.width) {
            pacman.x = (pacman.x + canvas.width) % canvas.width;
        }

        if (pacman.y < 0 || pacman.y > canvas.height) {
            pacman.y = (pacman.y + canvas.height) % canvas.height;
        }
    }

    function gameLoop() {
        ctx.fillStyle = 'yellow';
        ctx.clearRect(0, 0, canvas.width, canvas.height);
        var x = pacman.x + pacman.size / 2;
        var y = pacman.x + pacman.size / 2;
        var size = pacman.size / 2;

        drawBall(ball);

        drawPacman();

        steps += 1;
        if (0 === (steps % stepsToChangeMouth)) {
            isMouthOpen = !isMouthOpen;
            // steps = 0;
        }

        pacman.x += dirDeltas[dir].x * pacman.speed;
        pacman.y += dirDeltas[dir].y * pacman.speed;

        updatePacmanPosition();

        window.requestAnimationFrame(gameLoop);
    }

    function areColliding(obj1, obj2) {
        // if (obj1.x <= ) {
            
        // }
    }

    document.body.addEventListener('keydown', function (ev) {
        ev.preventDefault();

        if (keyCodeToDirs.hasOwnProperty(ev.keyCode)) {
            dir = keyCodeToDirs[ev.keyCode];
            // console.log(dir);
        }
        // console.log(ev.keyCode);
    });

    return {
        "start": function () {
            gameLoop();
        }
    };
}