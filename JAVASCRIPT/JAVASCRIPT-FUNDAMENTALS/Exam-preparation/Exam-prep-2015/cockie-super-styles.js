// 25/100

function solve(params) {
    var result = '',
        whitespacesRgx = /\s/g,
        removed = [];

    if (!String.prototype.includes) {
        String.prototype.includes = function (search, start) {
            'use strict';
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

    var isOnElementsRow = false;
    for (var i = 0; i < params.length; i += 1) {

        var currLine = params[i];

        if (currLine.includes('{')) {
            isOnElementsRow = true;
        }
        if (currLine.includes('}')) {
            removed.pop();
            removed.push(params[i - 1].replace(';', '').replace(whitespacesRgx, ''));
        }
        var currObj = {
        };

        if (isOnElementsRow) {
            var words = currLine.match(/([^]\w+)/g);
            if (words.length === 1) {
                currObj.name = words[i];
            }

            currLine = currLine.replace(whitespacesRgx, '');

            var word = '';
            if (words !== null) {
                for (var j = 0; j < words.length; j += 1) {
                    if ((words[j][0] === '.') || (words[j][0] === '#') || (words[j][0] === '-')) {
                        words.pop();
                        continue;
                    } else {
                        if (j === 0) {
                            if (currLine.includes('#') || currLine.includes('.') || currLine.includes('-')) {
                                currLine = currLine.replace(words[j], words[j] + ' ');
                            }
                        } else {
                            if (currLine.includes('#') || currLine.includes('.') || currLine.includes('-')) {
                                currLine = currLine.replace(words[j], ' ' + words[j]);
                            }
                        }
                    }
                }
            }

            //console.log(words);

            removed.push(currLine);
            isOnElementsRow = false;
        } else {
            removed.push(currLine.replace(whitespacesRgx, ''));
        }
    }

    result = removed.join('');
    console.log(result);
}

var test = [
    '#the-big-b{',
    '  color: yellow;',
    '  size: big;',
    '}',
    '.muppet{',
    '  powers: all;',
    '  skin: fluffy;',
    '}',
    '     .water-spirit         {',
    '  powers: water;',
    '             alignment    : not-good;',
    '				}',
    'all{',
    '  meant-for: nerdy-children;',
    '}',
    '.muppet      {',
    '	powers: everything;',
    '}',
    'all            .muppet {',
    '	alignment             :             good                             ;',
    '}',
    '   .muppet+             .water-spirit{',
    '   power: everything-a-muppet-can-do-and-water;',
    '}',
    '',
];

solve(test);


test = [
    'all            .muppet {',
    '	alignment             :             good                             ;',
    '}',
    '   .muppet+             .water-spirit{',
    '   power: everything-a-muppet-can-do-and-water;',
    '}',
    '',
];
