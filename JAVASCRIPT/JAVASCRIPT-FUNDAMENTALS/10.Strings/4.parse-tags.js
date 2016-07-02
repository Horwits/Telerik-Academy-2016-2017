function solve(params) {
    'use strict';
    let currentWordOpen = params[0].indexOf('>'),
        currentWordClose = params[0].indexOf('</'),
        currentWord = '',
        result = '';

    while (currentWordOpen > -1 && currentWordClose > -1) {
        currentWord = params[0].substr(currentWordOpen + 1, currentWordClose - currentWordOpen - 1);
        console.log(currentWord);

        result = params[0].replace(currentWord,)
        currentWordOpen = params[0].indexOf('>', currentWordClose + 11);
        currentWordClose = params[0].indexOf('</', currentWordClose + 1);
    }
}

var test = ['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.'];

solve(test);