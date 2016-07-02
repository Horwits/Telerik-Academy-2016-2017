// 5/100 
function solve(args) {
    var result,
        text = args[0],
        offset = +args[1],
        CONSTANTS = {
            ALPHABET: 'abcdefghijklmnopqrstuvwxyz'
        };

    //compress
    var compressed = '',
        indexInText = 0;

    while (indexInText < text.length) {
        var currentSymbol = text[indexInText];
        var scanIndex = indexInText + 1;
        var repeatLength = 1;

        while (scanIndex < text.length && text[scanIndex] === currentSymbol) {
            repeatLength++;
            scanIndex++;
        }

        indexInText = scanIndex;
        if (repeatLength > 2) {
            compressed += repeatLength;
            compressed += currentSymbol;
        }
        else {
            var counter = 0;
            while (counter < repeatLength) {
                compressed += currentSymbol;
                counter += 1;
            }
        }
    }

    //encrypt
    var encryptResult = '';
    // for (index = 0; index < compressed.length; index++) {
    //     //var element = array[index];
    //     if (compressed.charCodeAt(index) >= '0'.charCodeAt(0) && compressed.charCodeAt(index) <= '9'.charCodeAt(0)) {
    //         encryptResult += compressed[index];
    //     } else {
    //         var xorResult = 0;
    //         //
    //         var currElCode = compressed.charCodeAt(index) - 'a'.charCodeAt(0);
    //         var currInd = CONSTANTS.ALPHABET.length + currElCode - offset;

    //         if (currInd < 0) {
    //             currInd = currInd % offset;
    //         }

    //         xorResult = compressed.charCodeAt(index) ^ (CONSTANTS.ALPHABET).charCodeAt(currInd);

    //         encryptResult += xorResult;
    //     }
    // }

    function encryption(text, offset) {
        offset = offset || 0;
        var encryptedText = [],
            asciiCodeOfEncrypt = 0,
            asciiCodeOfNoneEncrypt = 0,
            encryptedAlphabet = CONSTANTS.ALPHABET.substr(26 - offset, offset) +
                CONSTANTS.ALPHABET.substr(0, 26 - offset);

        for (var i = 0; i < text.length; i++) {
            if (checkIfLetter(text[i])) {
                asciiCodeOfEncrypt = encryptedAlphabet[CONSTANTS.ALPHABET.indexOf(text[i])];
                asciiCodeOfNoneEncrypt = text[i];
                encryptedText.push(asciiCodeOfEncrypt.charCodeAt(0) ^ asciiCodeOfNoneEncrypt.charCodeAt(0));
            }
            else {
                encryptedText.push(text[i]);
            }
        }

        function checkIfLetter(symbol) {
            var asciiCode = symbol.charCodeAt(0);
            if ((asciiCode > 64 && asciiCode < 91) || (asciiCode > 96 && asciiCode < 123)) {
                return true;
            }
            return false;
        }

        return encryptedText.join("");
    }

    encryptResult = encryption(text, offset);
    //transoformation
    var sum = 0,
        product = 1, el;
    for (index = 0; index < encryptResult.length; index++) {
        el = +encryptResult[index];
        if (el % 2 === 0) {
            sum += el;
        } else {
            product *= el;
        }
    }

    //console.log(compressed);

    console.log(sum);
    console.log(product);
}


var test = [
    'aaaabbbccccaa',
    '3'
];

solve(test);

/*for (var index = 1; index < text.length; index++) {
        var element = text[index],
            prevEl = text[index - 1];

        if (element === prevEl) {
            counter += 1;
        }

        if (counter > 2 && element !== prevEl) {
            compressed += counter + prevEl;
            counter = 1;
            hasBiggerLen = true;
        } else if (counter <= 2 && element !== prevEl || index === text.length - 1) {
            var ind = 0;

            var toBeAdded = '';
            while (ind < counter) {

                toBeAdded += prevEl;
                ind++;
            }

            compressed += toBeAdded;
            counter = 1;
            hasBiggerLen = false;
        }
    } */

    //Working 75/75

    /*function solve(args) {
    var result,
        text = args[0],
        offset = args[1],
        CONSTANTS = {
            ALPHABET: 'abcdefghijklmnopqrstuvwxyz'
        };
    result = transformation(encryption(compression(text), offset));
    function compression(text) {
        var charArray = text.split(""),
            counter = 1,//TODO maybe mistake here
            lettersToCompressSymbol = "",
            lettersToCompressLength = 0,
            lettersToCompressStartPoss = 0,
            noMoreLettersToCompress = true;
        while(1){
            for (var i = 0; i < charArray.length; i++) {
                if (i != charArray.length - 1) {
                    if (charArray[i] == charArray[i + 1]) {
                        counter++;
                    }
                    else{
                        if(counter > 2){
                            lettersToCompressSymbol = charArray[i];
                            lettersToCompressLength = counter;
                            lettersToCompressStartPoss = i + 1 - lettersToCompressLength;
                            counter = 1;
                            noMoreLettersToCompress = false;
                            break;
                        }
                        counter = 1;
                    }
                }
                else{
                    if(counter > 2){
                        lettersToCompressSymbol = charArray[i];
                        lettersToCompressLength = counter;
                        lettersToCompressStartPoss = i + 1 - lettersToCompressLength;
                        noMoreLettersToCompress = false;
                        counter = 1;
                    }
                }
            }
            if(!noMoreLettersToCompress) {
                charArray.splice(lettersToCompressStartPoss, lettersToCompressLength,
                    (lettersToCompressLength + "" + lettersToCompressSymbol));
                noMoreLettersToCompress = true;
            }
            else{
                break;
            }
        }
        return charArray.join("");
    }
 
    function encryption(text, offset) {
        offset = offset || 0;
        var encryptedText = [],
            asciiCodeOfEncrypt = 0,
            asciiCodeOfNoneEncrypt = 0,
            encryptedAlphabet = CONSTANTS.ALPHABET.substr(26 - offset, offset) +
            CONSTANTS.ALPHABET.substr(0, 26 - offset);
 
        for (var i = 0; i < text.length; i++) {
            if (checkIfLetter(text[i])) {
                asciiCodeOfEncrypt = encryptedAlphabet[CONSTANTS.ALPHABET.indexOf(text[i])];
                asciiCodeOfNoneEncrypt = text[i];
                encryptedText.push(asciiCodeOfEncrypt.charCodeAt(0) ^ asciiCodeOfNoneEncrypt.charCodeAt(0));
            }
            else {
                encryptedText.push(text[i]);
            }
        }
 
        function checkIfLetter(symbol) {
            var asciiCode = symbol.charCodeAt(0);
            if ((asciiCode > 64 && asciiCode < 91) || (asciiCode > 96 && asciiCode < 123)) {
                return true;
            }
            return false;
        }
 
        return encryptedText.join("");
    }
 
    function transformation(text) {
        var sumOfAllEvenDigits = 0,
            productOfAllOddDigits = 1;
        for (var i = 0; i < text.length; i++) {
            if (!(parseInt(text[i]) % 2)) {
                sumOfAllEvenDigits += parseInt(text[i]);
            }
            else {
                productOfAllOddDigits *= parseInt(text[i]);
            }
        }
        return sumOfAllEvenDigits + "\n" + productOfAllOddDigits;
    }
 
    return result;
} */