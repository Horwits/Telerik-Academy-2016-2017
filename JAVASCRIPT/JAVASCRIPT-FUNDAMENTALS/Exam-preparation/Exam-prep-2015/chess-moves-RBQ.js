// 100/100 can't find the bug

function solve(params) {
    'use strict';
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]), i, move,
        board = [];
    //functions for movement
    function whenCurrColAndRowAreBiggerDiagonal(currCol, currRow, nextCol, nextRow) {
        var isValid = true;
        while (currCol > nextCol && currRow >= nextRow) {
            currCol -= 1;
            currRow -= 1;

            nextPos = board[currRow][currCol];

            if (nextRow !== currRow && nextCol === currCol || nextRow === currRow && nextCol !== currCol) {
                console.log('no');
                isValid = false;
                break;
            }

            if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                console.log('no');
                isValid = false;
                break;
            }
        }

        if (isValid) {
            console.log('yes');
        }

    }

    //row > && col <
    function whenCurrRowIsBiggerAndCurrColIsSmallerDiagonal(currCol, currRow, nextCol, nextRow) {
        var isValid = true;
        while (currCol < nextCol && currRow >= nextRow) {
            currCol += 1;
            currRow -= 1;

            nextPos = board[currRow][currCol];

            if (nextRow === currRow && nextCol !== currCol || nextCol === currCol && nextRow !== currRow) {
                console.log('no');
                isValid = false;
                break;
            }

            if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                console.log('no');
                isValid = false;
                break;
            }
        }

        if (isValid) {
            console.log('yes');
        }
    }

    //row < && col <
    function whenCurrRowIsSmallerAndCurrColIsSmallerDiagonal(currCol, currRow, nextCol, nextRow) {
        var isValid = true;
        while (currCol <= nextCol && currRow < nextRow) {
            currCol += 1;
            currRow += 1;

            nextPos = board[currRow][currCol];

            if (nextRow === currRow && nextCol !== currCol) {
                console.log('no');
                isValid = false;
                break;
            }

            if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                console.log('no');
                isValid = false;
                break;
            }
        }

        if (isValid) {
            console.log('yes');
        }

    }

    //row < && col >
    function whenCurrRowIsSmallerAndCurrColIsBiggerDiagonal(currCol, currRow, nextCol, nextRow) {
        var isValid = true;
        while (currCol >= nextCol && currRow < nextRow) {
            currCol -= 1;
            currRow += 1;

            nextPos = board[currRow][currCol];

            if (nextRow === currRow && nextCol !== currCol) {
                console.log('no');
                isValid = false;
                break;
            }

            if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                console.log('no');
                isValid = false;
                break;
            }
        }

        if (isValid) {
            console.log('yes');
        }
    }

    for (var index = rows + 1; index >= 2; index--) {
        board.push(params[index]);
    }

    //console.log(board);

    var isQueen = false, isBishop = false, isRook = false;

    for (i = 0; i < tests; i++) {
        move = params[rows + 3 + i].split(' ');

        // Your solution here
        var currCol = move[0].charCodeAt(0) - 97;
        var currRow = +move[0][1] - 1;
        if (currCol > cols || currRow > rows) {
            console.log('no');
            break;
        }

        // console.log(currCol);
        // console.log(currRow + " " + currCol);

        var currPos = board[currRow][currCol];

        //console.log(currPos);
        if (currPos === '-') {
            console.log('no');
        } else if (currPos === 'Q') {
            isQueen = true;
        }
        else if (currPos === 'B') {
            isBishop = true;
        }
        else if (currPos === 'R') {
            //console.log(currRow + " " + currCol);
            isRook = true;
        }

        var nextCol = move[1].charCodeAt(0) - 97;
        var nextRow = +move[1][1] - 1;
        var nextPos = board[nextRow][nextCol];

        //console.log("nextCol");
        //console.log(nextCol + " " + nextRow);
        //console.log(board[nextRow][nextCol]);

        var areColsEven = currCol === nextCol;
        var areRowsEven = currRow === nextRow;
        var isValid = true;

        if (isRook) {
            //console.log(nextRow + " " + nextCol);

            //if rows are not eqal but cols are
            if (areColsEven && !areRowsEven) {
                // rows 
                if (currRow > nextRow) {
                    while (currRow > nextRow) {

                        currRow -= 1;

                        nextPos = board[currRow][currCol];

                        if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                            console.log('no');
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) {
                        console.log('yes');
                    }
                } else if (currRow < nextRow) {
                    while (currRow < nextRow) {

                        currRow += 1;

                        nextPos = board[currRow][currCol];

                        if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                            console.log('no');
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) {
                        console.log('yes');
                    }
                }
            }
            else if (!areColsEven && areRowsEven) {
                if (currCol > nextCol) {
                    while (currCol > nextCol) {

                        currCol -= 1;

                        nextPos = board[currRow][currCol];

                        if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                            console.log('no');
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) {
                        console.log('yes');
                    }
                } else if (currCol < nextCol) {
                    while (currCol < nextCol) {

                        currCol += 1;

                        nextPos = board[currRow][currCol];

                        if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                            console.log('no');
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) {
                        console.log('yes');
                    }
                }

            } else {
                console.log('no');
            }

            isRook = false;
        } else if (isBishop) {
            areColsEven = currCol === nextCol;
            areRowsEven = currRow === nextRow;

            if (areColsEven || areRowsEven) {
                console.log('no');
            } else if (currCol > nextCol && currRow > nextRow) {
                whenCurrColAndRowAreBiggerDiagonal(currCol, currRow, nextCol, nextRow);//both are bigger
            } else if (currCol < nextCol && currRow > nextRow) {
                whenCurrRowIsBiggerAndCurrColIsSmallerDiagonal(currCol, currRow, nextCol, nextRow); //col is less , row is bigger
            } else if (currCol < nextCol && nextRow > currRow) {
                whenCurrRowIsSmallerAndCurrColIsSmallerDiagonal(currCol, currRow, nextCol, nextRow);
            } else if (currCol > nextCol && currRow < nextRow) {
                whenCurrRowIsSmallerAndCurrColIsBiggerDiagonal(currCol, currRow, nextCol, nextRow);
            }

            isBishop = false;
        } else if (isQueen) {
            areColsEven = currCol === nextCol;
            areRowsEven = currRow === nextRow;
            if (areColsEven && areRowsEven) {
                console.log('no');
            } else if (areColsEven && !areRowsEven) {
                if (currRow > nextRow) {
                    while (currRow > nextRow) {

                        currRow -= 1;

                        nextPos = board[currRow][currCol];

                        if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                            console.log('no');
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) {
                        console.log('yes');
                    }
                } else if (currRow < nextRow) {
                    while (currRow < nextRow) {

                        currRow += 1;

                        nextPos = board[currRow][currCol];

                        if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                            console.log('no');
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) {
                        console.log('yes');
                    }
                }
            } else if (areRowsEven && !areColsEven) {
                if (currCol > nextCol) {
                    while (currCol > nextCol) {

                        currCol -= 1;

                        nextPos = board[currRow][currCol];

                        if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                            console.log('no');
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) {
                        console.log('yes');
                    }
                } else if (currCol < nextCol) {
                    while (currCol < nextCol) {

                        currCol += 1;

                        nextPos = board[currRow][currCol];

                        if ((nextPos === 'R' || nextPos === 'B' || nextPos === 'Q')) {
                            console.log('no');
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) {
                        console.log('yes');
                    }
                }
            } else {
                if (currCol > nextCol && currRow > nextRow) {
                    whenCurrColAndRowAreBiggerDiagonal(currCol, currRow, nextCol, nextRow);//both are bigger
                } else if (currCol < nextCol && currRow > nextRow) {
                    whenCurrRowIsBiggerAndCurrColIsSmallerDiagonal(currCol, currRow, nextCol, nextRow); //col is less , row is bigger
                } else if (currCol < nextCol && nextRow > currRow) {
                    whenCurrRowIsSmallerAndCurrColIsSmallerDiagonal(currCol, currRow, nextCol, nextRow);
                } else if (currCol > nextCol && currRow < nextRow) {
                    whenCurrRowIsSmallerAndCurrColIsBiggerDiagonal(currCol, currRow, nextCol, nextRow);
                }
            }

            isQueen = false;
        }
    }
}

var test = [
    '3',
    '4',
    '--R-',
    'B--B',
    'Q--Q',
    '12',
    'd1 b3',
    'a1 a3',
    'c3 b2',
    'a1 c1',
    'a1 b2',
    'a1 c3',
    'a2 b3',
    'd2 c1',
    'b1 b2',
    'c3 b1',
    'a2 a3',
    'e5 b2'
];

test = [
    '5',
    '5',
    'Q-Q-Q',
    '-----',
    'R-Q-R',
    '-----',
    'Q---Q',
    '1',
    'c3 b4',
];

test = [
    '7',
    '8',
    '---Q----',
    'Q-------',
    '------R-',
    '--------',
    '-------R',
    '----B---',
    '-B------',
    '8',
    'd7 h6',
    'a6 b4',
    'g5 h7',
    'd7 g7',
    'h3 a4',
    'b1 a2',
    'b1 d4',
    'e2 h4',
];

test = [
    '9',
    '9',
    '--------B',
    '--Q------',
    '------Q--',
    '-R------R',
    '---------',
    '-----Q--R',
    '---------',
    '---B-----',
    '-B-------',
    '10',
    'i9 h8',
    'i9 g7',
    'g7 g1',
    'd2 e3',
    'i4 a4',
    'i6 i1',
    'i6 i5',
    'f4 d6',
    'c8 i2',
    'r6 b1',
];

test = [
'9',
'9',
'-------Q-',
'---------',
'--R----B-',
'---------',
'----QQ---',
'--------R',
'---------',
'-B-------',
'---------',
'10',
'b2 d4',
'b2 e5',
'b2 f6',
'f5 c5',
'f5 i5',
'e5 e1',
'e5 b8',
'h9 h1',
'h9 a2',
'c7 a7'
];

solve(test);