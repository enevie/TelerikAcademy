/**
 * Problem 2. Multiplication Sign

 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 */


var a = -5, b = 3, c = -2;


if (a > 0 && b > 0 && c > 0) {
    console.log("+");
}
else if (a < 0 && b > 0 && c > 0) {
    console.log("-");
}
else if (a > 0 && b < 0 && c > 0) {
    console.log("-");
}
else if (a > 0 && b > 0 && c < 0) {
    console.log("-");
}
else if (a < 0 && b < 0 && c > 0) {
    console.log("+");
}
else if (a < 0 && b > 0 && c < 0) {
    console.log("+");
}
else if (a > 0 && b < 0 && c < 0) {
    console.log("+");
}
else if (a < 0 && b < 0 && c < 0) {
    console.log("-");
}
else {
    console.log(0);
}




