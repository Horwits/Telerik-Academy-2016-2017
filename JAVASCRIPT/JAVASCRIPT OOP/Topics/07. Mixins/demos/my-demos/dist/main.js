'use strict';

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _possibleConstructorReturn(self, call) { if (!self) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return call && (typeof call === "object" || typeof call === "function") ? call : self; }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function, not " + typeof superClass); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, enumerable: false, writable: true, configurable: true } }); if (superClass) Object.setPrototypeOf ? Object.setPrototypeOf(subClass, superClass) : subClass.__proto__ = superClass; }

/*var PrintNameMixin  = {
 printName: function () {
 console.log(this._name);
 }
 };*/

var PrintNameMixin = function PrintNameMixin(Base) {
    return function (_Base) {
        _inherits(_class, _Base);

        function _class() {
            _classCallCheck(this, _class);

            return _possibleConstructorReturn(this, (_class.__proto__ || Object.getPrototypeOf(_class)).apply(this, arguments));
        }

        _createClass(_class, [{
            key: 'printName',
            value: function printName() {
                console.log(this._name);
            }
        }]);

        return _class;
    }(Base);
};

var NameValidationMixin = function NameValidationMixin(Base) {
    return function (_Base2) {
        _inherits(_class2, _Base2);

        function _class2() {
            _classCallCheck(this, _class2);

            return _possibleConstructorReturn(this, (_class2.__proto__ || Object.getPrototypeOf(_class2)).apply(this, arguments));
        }

        _createClass(_class2, [{
            key: '_validateName',
            value: function _validateName(name) {
                if (typeof name !== 'string') {
                    throw new Error('Name must be a string!');
                }
                if (name.length === 0) {
                    throw new Error('Name must not be empty.');
                }
            }
        }]);

        return _class2;
    }(Base);
};

var Traktor = function (_PrintNameMixin) {
    _inherits(Traktor, _PrintNameMixin);

    function Traktor(name) {
        _classCallCheck(this, Traktor);

        var _this3 = _possibleConstructorReturn(this, (Traktor.__proto__ || Object.getPrototypeOf(Traktor)).call(this));

        _this3._name = name;
        return _this3;
    }

    return Traktor;
}(PrintNameMixin(Object));

var Person = function (_PrintNameMixin2) {
    _inherits(Person, _PrintNameMixin2);

    function Person(name) {
        _classCallCheck(this, Person);

        var _this4 = _possibleConstructorReturn(this, (Person.__proto__ || Object.getPrototypeOf(Person)).call(this));

        _this4._validateName(name);
        _this4._name = name;
        return _this4;
    }

    return Person;
}(PrintNameMixin(NameValidationMixin(Object)));

/*Object.keys(PrintNameMixin).forEach(function (prop) {
 console.log('attaching ' + prop);
 Person.prototype[prop] = PrintNameMixin[prop];
 });*/

var p = new Person('Avram');
// let p = new Person(5);

p.printName();

var traktor = new Traktor('Pesho');
traktor.printName();

var VehicleValidationMixin = function VehicleValidationMixin(Base) {
    return function (_Base3) {
        _inherits(_class3, _Base3);

        function _class3() {
            _classCallCheck(this, _class3);

            return _possibleConstructorReturn(this, (_class3.__proto__ || Object.getPrototypeOf(_class3)).apply(this, arguments));
        }

        _createClass(_class3, [{
            key: '_validateModel',
            value: function _validateModel(value) {
                if (!value || value.length === 0) {
                    throw "Invalid model.";
                }
            }
        }]);

        return _class3;
    }(Base);
};

var Vehicle = function (_VehicleValidationMix) {
    _inherits(Vehicle, _VehicleValidationMix);

    function Vehicle(model, age) {
        _classCallCheck(this, Vehicle);

        var _this6 = _possibleConstructorReturn(this, (Vehicle.__proto__ || Object.getPrototypeOf(Vehicle)).call(this));

        _this6._validateModel(model);
        _this6._model = model;
        _this6._age = age;
        return _this6;
    }

    _createClass(Vehicle, [{
        key: 'calculateYearOfCreating',
        value: function calculateYearOfCreating() {
            var date = new Date();
            return date.getFullYear() - this._age;
        }
    }, {
        key: 'model',
        get: function get() {
            return this._model;
        }
    }, {
        key: 'age',
        get: function get() {
            return this._age;
        }
    }]);

    return Vehicle;
}(VehicleValidationMixin(Object));

var Car = function (_Vehicle) {
    _inherits(Car, _Vehicle);

    function Car(model, age, brand) {
        _classCallCheck(this, Car);

        var _this7 = _possibleConstructorReturn(this, (Car.__proto__ || Object.getPrototypeOf(Car)).call(this, model, age));

        _this7._brand = brand;
        return _this7;
    }

    return Car;
}(Vehicle);

var bmw = new Car('Z3', 20, 'BMW');
console.log(bmw.calculateYearOfCreating());
console.log(bmw);