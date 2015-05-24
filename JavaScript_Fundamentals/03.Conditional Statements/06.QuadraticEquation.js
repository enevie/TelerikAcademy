/**
 * Problem 6. Quadratic equation
 * Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 */

var a = 2, b = 5, c = -3;

var descriminant = (b * b) - (4 * a * c);

if (descriminant < 0) {
    console.log("no real roots");
}
else if (descriminant == 0) {
    var x = -b / (2 * a);
    console.log("x1=x2=" + x);
}
else {
    var x1 = (-b + Math.sqrt((b * b) - 4 * (a * c))) / (2 * a);
    var x2 = (-b - Math.sqrt((b * b) - 4 * (a * c))) / (2 * a);

    console.log("x1=" + x1 + ";x2=" + x2);
}
