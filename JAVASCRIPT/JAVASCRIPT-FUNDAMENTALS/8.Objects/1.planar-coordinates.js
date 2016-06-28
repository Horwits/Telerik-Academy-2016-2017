function solve(args) {
    var points = args.map(Number);

    function checkIfCanFormTriangle(lineOne, lineTwo, lineThree) {
        'use strict';
        return lineOne + lineTwo > lineThree && lineTwo + lineThree > lineOne && lineThree + lineOne > lineTwo;
    }

    function calculateDistanceBetweenTwoPoints(pointOneX, pointOneY, pointTwoX, pointTwoY) {
        'use strict';
        return (Math.sqrt(Math.pow(pointTwoX - pointOneX, 2) + Math.pow(pointTwoY - pointOneY, 2)));
    }

    var lengthLineOne = calculateDistanceBetweenTwoPoints(points[0], points[1], points[2], points[3]);
    var lengthLineTwo = calculateDistanceBetweenTwoPoints(points[4], points[5], points[6], points[7]);
    var lengthLineThree = calculateDistanceBetweenTwoPoints(points[8], points[9], points[10], points[11]);

    console.log(lengthLineOne.toFixed(2));
    console.log(lengthLineTwo.toFixed(2));
    console.log(lengthLineThree.toFixed(2));

    console.log(checkIfCanFormTriangle(lengthLineOne, lengthLineTwo, lengthLineThree) === true ? 'Triangle can be built' : 'Triangle can not be built');
}

var test = [
    '5', '6', '7', '8',
    '1', '2', '3', '4',
    '9', '10', '11', '12'
];

test = [
  '7', '7', '2', '2',
  '5', '6', '2', '2',
  '95', '-14.5', '0', '-0.123'
];

solve(test);