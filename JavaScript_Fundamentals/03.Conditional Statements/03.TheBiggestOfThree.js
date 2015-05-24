/**
 * Problem 3. The biggest of Three

 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 */

var a = -0.1, b = -0.5, c = -1.1;

if (a > b) {
    if (a > c) {
        console.log(a);
    }
    else {
        console.log(c);
    }
}
else if (a > c) {
    if (a > b) {
        console.log(a);
    }
    else {
        console.log(b);
    }
}
else if (b > a) {
    if (b > c) {
        console.log(b);
    }
    else {
        console.log(c);
    }
}
else if (b > c) {
    if (b > a) {
        console.log(b);
    }
    else {
        console.log(a);
    }
}
else if (c > a) {
    if (c > b) {
        console.log(c);
    }
    else {
        console.log(b);
    }
}
else if (c > b) {
    if (c > a) {
        console.log(c);
    }
    else {
        console.log(a);
    }
}

