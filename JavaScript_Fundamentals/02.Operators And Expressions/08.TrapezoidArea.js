/**
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

var a = 5, b = 7, h = 12;
var c = 2, d = 1, e = 33;

console.log(trapezoidArea(a, b, h));
console.log(trapezoidArea(c, d, e));

function trapezoidArea(a, b, height) {
    return ((a + b) * height) / 2;
}