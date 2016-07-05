function solve(args) {
    'use strict';

    if (!String.prototype.includes) {
        String.prototype.includes = function (search, start) {
            if (typeof start !== 'number') {
                start = 0;
            }

            if (start + search.length > this.length) {
                return false;
            } else {
                return this.indexOf(search, start) !== -1;
            }
        };
    }

    let text = args[0],
        rgx = /<(.*?)>/g;
    let match = text.match(rgx);


    for (var key in match) {
        if (text.includes(match[key])) {
            if (match[key].includes('upcase')) {
               
            }
        }
    }
}

// function solve(params) {
// />([a-z|A-Z].*?)<\//
//     'use strict';
//     let currentWordOpen = params[0].indexOf('>'),
//         currentWordClose = params[0].indexOf('</'),
//         currentWord = '',
//         result = '';

//     while (currentWordOpen > -1 && currentWordClose > -1) {
//         currentWord = params[0].substr(currentWordOpen + 1, currentWordClose - currentWordOpen - 1);
//         console.log(currentWord);

//         result = params[0].replace(currentWord,)
//         currentWordOpen = params[0].indexOf('>', currentWordClose + 11);
//         currentWordClose = params[0].indexOf('</', currentWordClose + 1);
//     }
// }

var test = ['We are <orgcase>liViNg</orgcase> in a <upcase>yellow submarine</upcase>. We <orgcase>doN\'t</orgcase> have <lowcase>anything</lowcase> else.'];

solve(test);