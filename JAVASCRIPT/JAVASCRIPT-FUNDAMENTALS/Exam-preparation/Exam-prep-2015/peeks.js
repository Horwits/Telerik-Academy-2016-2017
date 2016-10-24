// 100/100
function solve(params) {
    var intervals = params[0].split(' ').map(Number),
        currentCount = 0,
        maxCount = 0,
        isInValey = false,
        firstPeekInd = 0,
        secondPeekInd = 0;

    for (var i = 0, j = 1; j < intervals.length; i += 1, j += 1) {
        var currElement = intervals[i],
            nextElement = intervals[j];

        //find peek indexes
        if (currElement > nextElement) {
            if (!isInValey) {
                firstPeekInd = i;
            }

            isInValey = true;
        } else {
            secondPeekInd = j;
            isInValey = false;
        }

        
    }

    console.log(maxCount);
}

var test = ['5 1 7 4 8'];
solve(test);

test = ['5 1 7 6 3 6 4 2 3 8'];

test = ['10 1 2 3 4 5 4 3 2 1 10'];