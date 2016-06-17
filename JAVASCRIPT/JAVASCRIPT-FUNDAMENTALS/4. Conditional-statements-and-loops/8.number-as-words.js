function solve(args) {
    var number = +args[0],
        digitToWord = "";

    if (Math.floor(number / 100) !== 0) {
        switch (Math.floor(number / 100)) {
            case 1: digitToWord = "one"; break;
            case 2: digitToWord = "two"; break;
            case 3: digitToWord = "three"; break;
            case 4: digitToWord = "four"; break;
            case 5: digitToWord = "five"; break;
            case 6: digitToWord = "six"; break;
            case 7: digitToWord = "seven"; break;
            case 8: digitToWord = "eight"; break;
            case 9: digitToWord = "nine"; break;
            //default: return "not a number";
        }

        digitToWord += " hundred";
    }

    var copyNum = number;

    if (number > 99) {
        number = number % 100;
    }

    //implement from 10 to 19
    var isHundredsZero = false;
    if (number < 10 && number > 0 && copyNum > 10) {
        digitToWord += " and ";
        isHundredsZero = true;
    }

    if (number > 19) {
        if (copyNum > 100) {
            digitToWord += " and ";
        }

        switch (Math.floor(number / 10) % 10) {
            case 2: digitToWord += "twenty"; break;
            case 3: digitToWord += "thirty"; break;
            case 4: digitToWord += "fourty"; break;
            case 5: digitToWord += "fifty"; break;
            case 6: digitToWord += "sixty"; break;
            case 7: digitToWord += "seventy"; break;
            case 8: digitToWord += "eighty"; break;
            case 9: digitToWord += "ninety"; break;
            //default: return "not a number";
        }
    }

    if (number > 19) {
        number = number % 10;
    } else if (number > 9 && number < 19) {
        if (copyNum > 100) {
            digitToWord += " and ";
        }

        switch (number) {
            case 10: digitToWord += "ten"; break;
            case 11: digitToWord += "eleven"; break;
            case 12: digitToWord += "twelve"; break;
            case 13: digitToWord += "thirteen"; break;
            case 14: digitToWord += "fourteen"; break;
            case 15: digitToWord += "fifteen"; break;
            case 16: digitToWord += "sixteen"; break;
            case 17: digitToWord += "seventeen"; break;
            case 18: digitToWord += "eighteen"; break;
            //default: return "not a number";
        }
    }

    if (copyNum > 10 && !isHundredsZero) {
        digitToWord += " ";
    }

    if (number < 10) {
        switch (number) {
            case 1: digitToWord += "one"; break;
            case 2: digitToWord += "two"; break;
            case 3: digitToWord += "three"; break;
            case 4: digitToWord += "four"; break;
            case 5: digitToWord += "five"; break;
            case 6: digitToWord += "six"; break;
            case 7: digitToWord += "seven"; break;
            case 8: digitToWord += "eight"; break;
            case 9: digitToWord += "nine"; break;
            //default: return "not a number";
        }
    }

    if (copyNum === 0) {
        digitToWord = "zero";
    }

    if (copyNum === 19) {
        digitToWord = "nineteen";
    }

    var firstLetter = digitToWord[0].toUpperCase();
    digitToWord = firstLetter + digitToWord.substr(1, digitToWord.length);
    return digitToWord;
}

console.log(solve([19]));
//console.log(Math.floor(2 % 100));
console.log(Math.floor(201 % 100));
console.log(Math.floor(666 % 100));