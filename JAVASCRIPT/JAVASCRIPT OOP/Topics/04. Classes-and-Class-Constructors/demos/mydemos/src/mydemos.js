/**
 * Created by Horwi on 6.9.2016 г..
 */
class Person {
    constructor(firstname, lastname, height) {
        firstname = firstname || 'Unknown';
        lastname = lastname || 'Unknown';
        height = height || 'Unknown';
        this._firstname = firstname;
        this._lastname = lastname;
        this._height = height;
    }

    sayHallo() {
        return `${this._firstname} ${this._lastname}, says hallo!`;
    }

    get fullname() {
        return `${this._firstname} ${this._lastname}`;
    }


    get height() {
        return this._height;
    }

    set height(x) {
        if (typeof x !== 'number') {
            throw 'Height should be a number.';
        }

        if (x > this._height) {
            this._height += 0.001;
        }
    }

    static defaultName(){
        return 'Default name';
    }
}

let person = new Person('Pesho', 'Stoqnov', 1.8);
const person2 = new Person('Pesho');
console.log(typeof Person);
console.log(typeof person);

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