function solve(args) {
    var digit = args[0],
        digitToWord = "",
        isNotDigit = false,
        notADigitMessage = "not a digit";
    
    switch (digit) {
        case "0": digitToWord = "zero"; break;
        case "1": digitToWord = "one"; break;
        case "2": digitToWord = "two"; break;
        case "3": digitToWord = "three"; break;
        case "4": digitToWord = "four"; break;
        case "5": digitToWord = "five"; break;
        case "6": digitToWord = "six"; break;
        case "7": digitToWord = "seven"; break;
        case "8": digitToWord = "eight"; break;
        case "9": digitToWord = "nine"; break;
        default: isNotDigit = true; break;
    }

    return isNotDigit === true ? notADigitMessage : digitToWord;
}

console.log(solve(["sasa"]));