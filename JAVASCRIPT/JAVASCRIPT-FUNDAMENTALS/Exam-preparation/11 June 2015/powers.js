function solve(params) {
    var nk = params[0].split(' ').map(Number),
        collection = params[1].split(' ').map(Number),
        result;
    // Your solution here
    var numbers = +nk[0];
    var transformations = +nk[1];

    function solution(transformations, numbers, collection) {
        var resultCollection = [];
        for (var i = 0; i < transformations; i += 1) {
            for (var j = 0; j < numbers; j += 1) {
                var toBePushed = 0;
                if (collection[j] % 2 === 0 && collection[j] !== 0) {
                    if (j === 0) {
                        toBePushed = Math.max(collection[collection.length - 1], collection[j + 1]);
                    } else if (j === collection.length - 1) {
                        toBePushed = Math.max(collection[0], collection[j - 1]);
                    } else {
                        toBePushed = Math.max(collection[j - 1], collection[j + 1]);
                    }

                } else if (collection[j] % 2 === 1 && collection[j] !== 1) {
                    if (j === 0) {
                        toBePushed = Math.min(collection[collection.length - 1], collection[j + 1]);
                    } else if (j === collection.length - 1) {
                        toBePushed = Math.min(collection[0], collection[j - 1]);
                    } else {
                        toBePushed = Math.min(collection[j - 1], collection[j + 1]);
                    }
                } else if (collection[j] === 0) {
                    if (j === 0) {
                        toBePushed = Math.abs(collection[collection.length - 1] - collection[j + 1]);
                    } else if (j === collection.length - 1) {
                        toBePushed = Math.abs(collection[0] - collection[j - 1]);
                    } else {
                        toBePushed = Math.abs(collection[j - 1] - collection[j + 1]);
                    }
                } else {
                    if (j === 0) {
                        toBePushed = Math.abs(collection[collection.length - 1] + collection[j + 1]);
                    } else if (j === collection.length - 1) {
                        toBePushed = Math.abs(collection[0] + collection[j - 1]);
                    } else {
                        toBePushed = Math.abs(collection[j - 1] + collection[j + 1]);
                    }
                }

                resultCollection.push(toBePushed);
            }

            collection = resultCollection;
            resultCollection = [];
        }
        return collection;
    }

    function sum(collection) {
        var sum = 0;
        for (var i = 0; i < collection.length; i += 1) {
            sum += collection[i];
        }

        return sum;
    }

    result = solution(transformations, numbers, collection);
    console.log(sum(result));
}

solve(["5 1", "9 0 2 4 1"]);
solve(["10 3", "1 9 1 9 1 9 1 9 1 9"]);
/*
•	each 0 - with the absolute difference of its neighboring numbers
•	all other even numbers - with the maximum of its neighboring numbers
•	each 1 - with the sum of its neighboring numbers
•	all other odd numbers - with the minimum of its neighboring numbers
 */