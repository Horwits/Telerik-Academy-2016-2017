function solve(args) {
    var numbers = (args + '').split('\n').map(Number),
        occurance = 0,
        maxOccurance = 0,
        mostFreaquentNumber = 0;

    for (var i = 0; i < numbers.length; i++) {
        var currentNum = numbers[i];
        for (var j = 0; j < numbers.length; j++) {
            if (currentNum == numbers[j]) {
                occurance++;
            }

            if (occurance > maxOccurance) {
                maxOccurance = occurance;
                mostFreaquentNumber = currentNum;
            }
        }

        occurance = 0;
    }

    console.log(mostFreaquentNumber + ' (' + maxOccurance + ' times)');
}

var test = ['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3'];

solve(test);