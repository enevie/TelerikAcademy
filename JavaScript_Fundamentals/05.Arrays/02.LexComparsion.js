/**
 * Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).
 */


var char1 = ['a', 'b', 'z', 'd'];
var char2 = ['q', 'd', 'z', 'a'];

for (var i = 0; i < char1.length; i++) {
    if (char1[i] > char2[i]) {
        console.log("char " + char1[i] + " is bigger than " + char2[i]);
    }
    else if (char1[i] == char2[i]) {
        console.log("the chars are equal " + char1[i]);
    }
    else {
        console.log("char " + char2[i] + " is bigger than " + char1[i]);
    }
}
