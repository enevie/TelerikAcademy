/**
 * Problem 1. Exchange if greater

 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 */

var a = 10, b = 2;

printNumbers(a, b);

if (a > b) {
    var c = a;
    a = b;
    b = c;

}

printNumbers(a, b);


function printNumbers(a, b) {

    console.log(a + '\t' + b);
}