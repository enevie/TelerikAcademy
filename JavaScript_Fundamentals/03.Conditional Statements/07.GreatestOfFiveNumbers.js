/**
 * Problem 7. The biggest of five numbers

 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 */

var numbers = [5, 2, 32, 4, 10];
var greatest = numbers[0];

for (var i = 0; i <= numbers.length; i++) {
    if (greatest < numbers[i]) {
        greatest = numbers[i];
    }
}
console.log("The greatest is: " + greatest)