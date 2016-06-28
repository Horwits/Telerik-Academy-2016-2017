function solve(input) {
    var n = +input[0],
        words = [],
        maxLen = 0;

    for (var i = 1; i < input.length; i += 1) {
        words.push(input[i]);
    }

    function findMaxLength(words) {
        var max = words[0].length;

        for (var i = 1; i < words.length; i += 1) {
            if (words[i].length > max) {
                max = words[i].length;
            }
        }

        return max;
    }
    for (i = 0; i < n; i += 1) {
        var newPos = (words[i].length % (n + 1));
        words.splice(newPos, 0, words[i]);
        if (newPos >= i) {
            words.splice(i, 1);
        } else {
            words.splice(i + 1, 1);
        }
    }
    maxLen = findMaxLength(words);

    //printing
    var printOut = '';
    for (var r = 0; r < maxLen; r += 1) {
        for (var c = 0; c < n; c += 1) {
            if (r >= words[c].length) {
                continue;
            }
            printOut += words[c][r];
        }
    }

    return printOut;
}

var test = [
    '3',
    'hi',
    'academy',
    'exam',
];

test = [
    '2',
    'you',
    'win',
];

test = [
    '1',
    'hi',
];

test = [
    '4',
    'nakov',
    'wrote',
    'this',
    'problem',
];

solve(test);
console.log(solve(test) === 'wnptrarhokoitobsevlem');