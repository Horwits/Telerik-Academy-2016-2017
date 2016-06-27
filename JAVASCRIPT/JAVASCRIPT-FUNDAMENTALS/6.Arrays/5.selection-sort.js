function solve(args) {
    var arr = (args + '').split('\n').map(Number);
    //var arr = args.map(Number);

    //find and remove duplicate elements

    //find the smallest element
    function findMinElementIndex(array, fromIndex) {
        var min = array[fromIndex],
            index = fromIndex;
        for (var i = fromIndex; i < arr.length; i += 1) {
            if (min > array[i]) {
                min = array[i];
                index = i;
            }
        }

        return index;
    }

    function swap(arr, curPos, minPos) {
        var temp = arr[curPos];
        arr[curPos] = arr[minPos];
        arr[minPos] = temp;

        return arr;
    }

    //swap it on the first position
    var counter = 0;

    while (counter < arr.length) {
        var currentMinIndex = findMinElementIndex(arr, counter);
        swap(arr, counter, currentMinIndex);

        //remove duplicates
        for (i = 0; i < arr.length - 1; i += 1) {
            if (arr[i + 1] === arr[i]) {
                arr.splice(i + 1, 1);
                i -= 1;
            }
        }

        counter += 1;
    }

    console.log(arr.join('\n'));
}

var test = ['10', '36', '10', '1', '34', '28', '38', '31', '27', '30', '20'];
solve(test);