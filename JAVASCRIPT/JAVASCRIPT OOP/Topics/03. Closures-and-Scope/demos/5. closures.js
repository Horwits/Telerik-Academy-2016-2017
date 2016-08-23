function outer(x) {
    function middle(y) {
        function inner(z) {
            return x + ' ' + y + ' ' + z;
        }

        return inner;
    }

    return middle;
}


var system = outer(4);
system = system(4);
system = system(2);
console.log('System ' + system);

var names = outer('Peter');
names = names('Georgiev');
names = names('Petrov');
console.log('Hi! I am ' + names);

var myNames = function firstN(first) {
    function lastN(last) {
        function result(middle) {
            return first + " " + middle + " " + last;
        }

        return result;
    }

    return lastN;
};

var me = myNames('Daniel');
me = me('Nikolov');
me = me('Aleksandrov');

console.log(me);