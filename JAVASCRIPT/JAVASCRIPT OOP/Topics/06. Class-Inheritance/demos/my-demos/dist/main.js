'use strict';

var _get = function get(object, property, receiver) { if (object === null) object = Function.prototype; var desc = Object.getOwnPropertyDescriptor(object, property); if (desc === undefined) { var parent = Object.getPrototypeOf(object); if (parent === null) { return undefined; } else { return get(parent, property, receiver); } } else if ("value" in desc) { return desc.value; } else { var getter = desc.get; if (getter === undefined) { return undefined; } return getter.call(receiver); } };

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _possibleConstructorReturn(self, call) { if (!self) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return call && (typeof call === "object" || typeof call === "function") ? call : self; }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function, not " + typeof superClass); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, enumerable: false, writable: true, configurable: true } }); if (superClass) Object.setPrototypeOf ? Object.setPrototypeOf(subClass, superClass) : subClass.__proto__ = superClass; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

/**
 * Created by Horwi on 8.9.2016 г..
 */
var Mammal = function () {
    function Mammal(age) {
        _classCallCheck(this, Mammal);

        this._age = age;
    }

    _createClass(Mammal, [{
        key: 'walk',
        value: function walk() {
            console.log('Mammal walk().');
        }
    }, {
        key: 'toString',
        value: function toString() {
            return 'Type of ' + this.constructor.name + ' Age: ' + this._age;
        }
    }]);

    return Mammal;
}();

var Person = function (_Mammal) {
    _inherits(Person, _Mammal);

    function Person(name, age) {
        _classCallCheck(this, Person);

        var _this = _possibleConstructorReturn(this, (Person.__proto__ || Object.getPrototypeOf(Person)).call(this, age));

        _this._name = name;
        return _this;
    }

    _createClass(Person, [{
        key: 'says',
        value: function says(text) {
            console.log('Name: ' + this._name + ' says ' + text + '.');
        }

        // to override base method we just have to rewrite the method

    }, {
        key: 'walk',
        value: function walk() {
            console.log('Person walk().');
        }
    }, {
        key: 'toString',
        value: function toString() {
            return 'Name: ' + this._name + ' ' + _get(Person.prototype.__proto__ || Object.getPrototypeOf(Person.prototype), 'toString', this).call(this);
        }
    }]);

    return Person;
}(Mammal);

var Zebra = function (_Mammal2) {
    _inherits(Zebra, _Mammal2);

    function Zebra(age) {
        _classCallCheck(this, Zebra);

        return _possibleConstructorReturn(this, (Zebra.__proto__ || Object.getPrototypeOf(Zebra)).call(this, age));
    }

    return Zebra;
}(Mammal);

var p = new Person('Angel', 15);

console.log(p);
p.says('hallo');

var z = new Zebra(4);

z.walk();

p.walk();

console.log(p.toString());

console.log(z.toString());