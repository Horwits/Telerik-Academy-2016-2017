'use strict';

var _typeof = typeof Symbol === "function" && typeof Symbol.iterator === "symbol" ? function (obj) { return typeof obj; } : function (obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol ? "symbol" : typeof obj; };

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

/**
 * Created by Horwi on 6.9.2016 г..
 */
var Person = function () {
    function Person(firstname, lastname, height) {
        _classCallCheck(this, Person);

        firstname = firstname || 'Unknown';
        lastname = lastname || 'Unknown';
        height = height || 'Unknown';
        this._firstname = firstname;
        this._lastname = lastname;
        this._height = height;
    }

    _createClass(Person, [{
        key: 'sayHallo',
        value: function sayHallo() {
            return this._firstname + ' ' + this._lastname + ', says hallo!';
        }
    }, {
        key: 'fullname',
        get: function get() {
            return this._firstname + ' ' + this._lastname;
        }
    }, {
        key: 'height',
        get: function get() {
            return this._height;
        },
        set: function set(x) {
            if (typeof x !== 'number') {
                throw 'Height should be a number.';
            }

            if (x > this._height) {
                this._height += 0.001;
            }
        }
    }], [{
        key: 'defaultName',
        value: function defaultName() {
            return 'Default name';
        }
    }]);

    return Person;
}();

var person = new Person('Pesho', 'Stoqnov', 1.8);
var person2 = new Person('Pesho');
console.log(typeof Person === 'undefined' ? 'undefined' : _typeof(Person));
console.log(typeof person === 'undefined' ? 'undefined' : _typeof(person));

console.log(person);
console.log(person2);

person2._firstname = 'Kiro';
console.log(person.sayHallo());

console.log(person.height);

// person.height = 'sda';

person.height = 2;

console.log(person.height);

console.log(person.fullname);

console.log(Person.defaultName());