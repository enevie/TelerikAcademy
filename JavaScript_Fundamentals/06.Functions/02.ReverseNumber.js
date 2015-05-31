/**
 * Problem 2. Reverse number

 Write a function that reverses the digits of given decimal number.
 */

var number = 123.45;

console.log(reverseNumber(number));

function reverseNumber(number) {
    var reversedNumber = "", i, converted = number.toString();

    for (i = converted.length - 1; i >= 0; i--) {
        reversedNumber += converted[i];
    }
     return parseFloat(reversedNumber);
}