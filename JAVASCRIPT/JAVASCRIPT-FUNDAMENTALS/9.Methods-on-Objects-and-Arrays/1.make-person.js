'use strict';

let constructor = function makePerson(firstName, lastName, age, gender) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: function (bool) {
            if (bool === true) {
                return "Female";
            }

            return "Male";
        },
        toString: function () {
            return this.firstName + " " + this.lastName + " " + this.age + "\n" + this.gender(); 
         }
    };
};

let pesho = constructor("Pesho", "Peshov", 13, true),
gosho = constructor("Gosho", "Goshov", 22, false);

console.log(pesho.toString());
console.log(gosho.toString());