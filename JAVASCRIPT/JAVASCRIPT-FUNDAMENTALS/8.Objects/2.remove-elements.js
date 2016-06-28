function solve(args) {
    var arr = args;

    Array.prototype.remove = function (element) {
        var result = [];
        for (var key in this) {
            if (this[key] !== element && typeof this[key] !== 'function') {
                result.push(this[key]);
            }
        }

        return result;
    };
    
    console.log(arr.remove(arr[0]).join('\n'));
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
arr = ['1', '2', '3', '2', '1', '2', '3', '2'];
solve(arr);

