function solve(input) {
    var first = input[0].toLowerCase().split(""),
        second = input[1].toLowerCase().split(""),
        isEqual = false;

    if (first.length > second.length) {
        console.log('>');
    } else if (first.length < second.length) {
        console.log('<');
    } else {
        for (var i = 0; i < first.length; i += 1) {
            if (first[i] > second[i]) {
                console.log('>');
                isEqual = false;
                break;
            } else if (first[i] < second[i]) {
                console.log('<');
                isEqual = false;
                break;
            } else {
                isEqual = true;
            }
        }
    }

    if (isEqual) {
        console.log('=');
    }
}

var test = [
    'hello',
    'halo'
];

solve(test);

test = [
    'food',
    'food'
];

solve(test);