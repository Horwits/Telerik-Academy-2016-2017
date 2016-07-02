function solve(params) {
    'use strict';
    let searchedWord = params[0].toLowerCase(),
        text = params[1].toLowerCase(),
        count = 0;

    let index = text.indexOf(searchedWord);

    while (index > -1) {

        count += 1;

        index = text.indexOf(searchedWord, index + 1);
    }

    console.log(count);
}

var test = [
    'In',
    'We are lIvIng in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'
];

solve(test);