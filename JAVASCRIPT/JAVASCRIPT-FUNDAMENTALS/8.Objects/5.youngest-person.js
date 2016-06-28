function solve(args) {
    var people = [],
        i = 0;

    for (i = 0; i < args.length; i += 3) {

        people.push({ firstName: args[i], lastName: args[i + 1], age: +args[i + 2] });
    }

    function youngestPerson(array) {
        var minAge = array[0].age,
            person = array[0];

        for (i in array) {
            if (array[i].age < minAge) {
                minAge = array[i].age;
                person = array[i];
            }
        }

        return person.firstName + ' ' + person.lastName;
    }

    console.log(youngestPerson(people));
}

var test = [
    'Gosho', 'Petrov', '32',
    'Bay', 'Ivan', '81',
    'John', 'Doe', '42'
];

test = [
  'Penka', 'Hristova', '61',
  'System', 'Failiure', '88',
  'Bat', 'Man', '16',
  'Malko', 'Kote', '72'
];

solve(test);