function solve(args) {
    var width = args[0],
        height = args[1],
        rectangleArea = width * height,
        rectanglePerimeter = (width * 2) + (height * 2);

    rectangleArea = rectangleArea.toFixed(2);
    rectanglePerimeter = rectanglePerimeter.toFixed(2);

    return rectangleArea + " " + rectanglePerimeter;
}

//console.log(solve([5, 5]));