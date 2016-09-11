'use strict';

class listNode {
    constructor(value) {
        this._value = value;
        this._next = null;
    }

    get value(){
        return this._value;
    }

    set value(x){
        this._value = x;
    }

    get next(){
        return this._next;
    }
}

class LinkedList {
    constructor() {
        this._lenght = 0;
        this._first = null;
        this._last = null;
    }

    get first(){
        return this._first;
    }

    get last(){
        return this._last;
    }

    get length(){
        return this._lenght;
    }

    append(...x) {
        if (!this._first) {
            this._first = new listNode(arguments[0]);
        }
    }
}

var list = new LinkedList();

console.log(list.first);

module.exports = LinkedList;