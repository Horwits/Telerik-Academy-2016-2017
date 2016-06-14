function solve(args) {
    var x = args[0],
        y = args[1],
        circleRadius = 1.5,
        rectangleTop = 1,
        rectangleLeft = -1,
        rectangleWidth = 6,
        rectangleHeight = 2,
        isInsideCircle = (Math.pow(x - 1, 2)) + (Math.pow(y - 1, 2)) <= ((circleRadius * circleRadius)),
        rectangleMostRightCorner = rectangleWidth - (Math.abs(rectangleLeft)),
        rectangleMostDownCorner = (rectangleTop - rectangleHeight),
        isOutsideRectangle = (((x < rectangleLeft) || (x > rectangleMostRightCorner) || ((y < rectangleMostDownCorner) || (y > rectangleTop))));

    var outputCircle = isInsideCircle === true ? "inside circle" : "outside circle";
    var outputRectangle = isOutsideRectangle === true ? "outside rectangle" : "inside rectangle";

    return outputCircle + " " + outputRectangle;
}

console.log(solve([2.5, 1]));