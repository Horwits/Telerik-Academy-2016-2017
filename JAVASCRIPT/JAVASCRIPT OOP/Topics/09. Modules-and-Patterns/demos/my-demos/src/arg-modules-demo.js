/*let calculator = (function () {
 let result = 0;

 function add(x) {
 result += x;
 return this;
 }

 function subtract(x) {
 result -= x;
 return this;
 }

 function getResult() {
 return result;
 }

 return{
 add, subtract, getResult
 }
 })();*/

// our lasted obj starts as empty
let calculator = {};

// private iffe with every private functionality
(function (module) {
    let result = 0;

    function add(x) {
        result += x;
        return this;
    }

    function subtract(x) {
        result -= x;
        return this;
    }

    function getResult() {
        return result;
    }

    module.add = add;
    module.subtract = subtract;
    module.getResult = getResult;
}(calculator));

// calling it with our obj

(function (module) {
    module.add42 = function () {
        this.add(42);
    };
}(calculator));


calculator.add42();

console.log(calculator.add(5).getResult());

