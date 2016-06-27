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

    maxLen = findMaxLength(words);

    console.log(maxLen);
}

var test = [
    '3',
    'hi',
    'academy',
    'exam',
];

solve(test);