/**
 * Problem 5. Youngest person

 Write a function that finds the youngest person in a given array of people and prints his/hers full name
 Each person has properties firstname, lastname and age.
 */
function Person(firstname, lastname, age) {
    if (isNaN(age) || !isFinite(age)) {
        throw new Error('age must be a number');
    }

    if (!(this instanceof  Person)) {
        return new Person(firstname, lastname, age);
    }

    this.firstname = firstname;
    this.lastname = lastname;
    this.age = age;
}

Person.prototype.toString = function(){
    return this.firstname + ' ' + this.lastname;
};

function comparePeople(a, b) {
    return a.age - b.age;
}

var people = [
    new Person('Nikolay', 'Kostov', 24),
    new Person('Ivaylo', 'Kenov', 25),
    new Person('The', 'Ninja', 0)
];

people.sort(comparePeople);


console.log('Youngest: ' + people[0].toString());


