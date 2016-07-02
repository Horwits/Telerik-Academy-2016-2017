// TODO: Implement

function solve(args) {
    var s = +args[0];
    var C3 = +args[1];
    var C2 = +args[2];
    var C1 = +args[3];

    var c1Counter = 0;
    for (var index = 0; index <= s; index += C1) {
        c1Counter += 1;
    }

    var c2Counter = 0;
    for (index = 0; index <= s; index += C2) {
        c2Counter += 1;
    }

    var c3Counter = 0;
    for (index = 0; index <= s; index += C3) {
        c3Counter += 1;
    }

    var c1MoneySp = 1;
    c1MoneySp = C1 * c1Counter;

    var c2MoneySp = 1;
    c2MoneySp = C2 * c2Counter;

    var c3MoneySp = 1;
    c3MoneySp = C3 * c3Counter;

    console.log(c1MoneySp + c2MoneySp + c3MoneySp);
}

var test = [
    '110',
    '13',
    '15',
    '17',
];

solve(test);