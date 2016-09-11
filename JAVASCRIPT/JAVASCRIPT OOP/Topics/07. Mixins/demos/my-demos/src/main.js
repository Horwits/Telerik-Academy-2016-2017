/*var PrintNameMixin  = {
 printName: function () {
 console.log(this._name);
 }
 };*/

let PrintNameMixin = function (Base) {
    return class extends Base {
        printName() {
            console.log(this._name);
        }
    }
};

let NameValidationMixin = function (Base) {
    return class extends Base {
        _validateName(name) {
            if (typeof name !== 'string') {
                throw new Error('Name must be a string!');
            }
            if (name.length === 0) {
                throw  new Error('Name must not be empty.');
            }
        }
    }
};


class Traktor extends PrintNameMixin(Object) {
    constructor(name) {
        super();
        this._name = name;
    }
}

class Person extends PrintNameMixin(NameValidationMixin(Object)) {
    constructor(name) {
        super();
        this._validateName(name);
        this._name = name;
    }
}


/*Object.keys(PrintNameMixin).forEach(function (prop) {
 console.log('attaching ' + prop);
 Person.prototype[prop] = PrintNameMixin[prop];
 });*/

let p = new Person('Avram');
// let p = new Person(5);

p.printName();

let traktor = new Traktor('Pesho');
traktor.printName();

let VehicleValidationMixin = function (Base) {
    return class extends Base {
        _validateModel(value) {
            if (!value || value.length === 0) {
                throw "Invalid model.";
            }
        }
    }
};

class Vehicle extends VehicleValidationMixin(Object) {
    constructor(model, age) {
        super();
        this._validateModel(model);
        this._model = model;
        this._age = age;
    }

    get model() {
        return this._model;
    }

    get age() {
        return this._age;
    }

    calculateYearOfCreating() {
        let date = new Date();
        return date.getFullYear() - this._age;
    }
}

class Car extends Vehicle {
    constructor(model, age, brand) {
        super(model, age);
        this._brand = brand;
    }
}

let bmw = new Car('Z3', 20, 'BMW');
console.log(bmw.calculateYearOfCreating());
console.log(bmw);