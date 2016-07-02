function solve(params) {
    'use strict';
    String.prototype.replaceAll = function (search, replacement) {
        var target = this;
        return target.split(search).join(replacement);
    };

    let result = params[0].replaceAll(' ', '&nbsp;');
    console.log(result);
}

var test = ['hello world'];


test = ['This text contains 4 spaces!!'];
solve(test);