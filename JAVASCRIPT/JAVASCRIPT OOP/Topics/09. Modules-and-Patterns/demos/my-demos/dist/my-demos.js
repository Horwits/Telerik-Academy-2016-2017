// module pattern
let controls = function () {

    class Calculator {
        constructor() {
            this._result = 0;
        }

        add(value) {
            this._result += value;
            return this;
        }

        subtract(value) {
            this._result -= value;
            return this;
        }

        showResult() {
            console.log('The result is: ' + this._result);
            return this;
        }
    }

    return {
        // get instance
        getCalculator: () => new Calculator()
    };
}();

let calc = controls.getCalculator();

calc.add(5);
calc.showResult();

calc.add(5).add(5).showResult();

// Revealing pattern -> the difference is when we return the anonymous object, we just have to give a reference to private initialized functions and members. In Module pattern, we create the public funtions in the anonymous object.

let newControls = function () {
    class Calculator {
        constructor() {
            this._result = 0;
        }

        add(value) {
            this._result += value;
            return this;
        }

        subtract(value) {
            this._result -= value;
            return this;
        }

        showResult() {
            console.log('The result is: ' + this._result);
            return this;
        }
    }

    function getCalculator() {
        return new Calculator();
    }

    return {
        getCalculator
    };
}();

console.log('\nrevealing pattern\n');

let newcalc = newControls.getCalculator();
newcalc.add(5);
newcalc.showResult();

newcalc.add(5).add(5).showResult();
//# sourceMappingURL=my-demos.js.map