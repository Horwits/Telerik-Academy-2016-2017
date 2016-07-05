//add string.format to the prototype of string
function solve(args) {
    'use strict';
    let obj = JSON.parse(args[0]),
        template = args[1];

    String.prototype.format = function (options) {
        var prop,
            result = this;
        for (prop in options) {
            result = result.replace(new RegExp('#{' + prop + '}', 'g'), options[prop]);
        }
        return result;
    };
    
    console.log(template.format(obj));
}

var test = [
    '{ "name": "John", "age": 13 }',
    "My name is #{name} and I am #{age}-years-old"
];

solve(test);
test = [
    '{ "name": "John", "args": "tete" , "str": "tedsadsae"}',
    "Hello, there! Are you #{name}, #{tete}, #{str}?"
];


//console.log(JSON.parse('{"age": 14}'));