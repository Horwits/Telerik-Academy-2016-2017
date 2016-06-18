function solve(args) {
    var hex = args[0],
        result = 0,
        currentPosition = 0,
        length = hex.length;

    for (var i = length - 1; i >= 0; i--) {
        var currentChar = hex[i];
        var currentNum = 0;
        if (currentChar >= "0" && currentChar <= "9") {
            currentNum = +currentChar;
        }
        else {
            switch (currentChar) {
                case "A":
                    currentNum = 10;
                    break;
                case "B":
                    currentNum = 11;
                    break;
                case "C":
                    currentNum = 12;
                    break;
                case "D":
                    currentNum = 13;
                    break;
                case "E":
                    currentNum = 14;
                    break;
                case "F":
                    currentNum = 15;
                    break;
            }
        }

        result += (currentNum * Math.pow(16, currentPosition));
        currentPosition++;
    }

    return result;
}

console.log(solve(["FE"]));
console.log(solve(["4ED528CBB4"]));