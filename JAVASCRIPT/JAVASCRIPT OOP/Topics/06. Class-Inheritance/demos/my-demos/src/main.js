/**
 * Created by Horwi on 8.9.2016 г..
 */
class Mammal {
    constructor(age) {
        this._age = age;
    }

    walk() {
        console.log('Mammal walk().');
    }

    toString(){
        return 'Type of ' + this.constructor.name + ' Age: ' + this._age;
    }
}

class Person extends Mammal {
    constructor(name, age) {
        super(age);
        this._name = name;
    }

    says(text) {
        console.log('Name: ' + this._name + ' says ' + text + '.');
    }

    // to override base method we just have to rewrite the method
    walk() {
        console.log('Person walk().');
    }

    toString(){
        return 'Name: ' + this._name + ' ' + super.toString();
    }
}

class Zebra extends Mammal {
    constructor(age) {
        super(age);
    }
}

let p = new Person('Angel', 15);

console.log(p);
p.says('hallo');

let z = new Zebra(4);

z.walk();

p.walk();

console.log(p.toString());

console.log(z.toString());