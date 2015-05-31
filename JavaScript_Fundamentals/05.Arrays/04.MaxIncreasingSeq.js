/**
 * Problem 4. Maximal increasing sequence

 Write a script that finds the maximal increasing sequence in an array.
 */

var arr = [3, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13];
var maxIndex = 1;
var lastDigitOfTheSequence = 0;
var currIndex = 1;


for (var i = 0; i < arr.length; i++) {
    if (arr[i] + 1 == arr[i + 1]) {
        currIndex++;
        if (currIndex > maxIndex) {
            maxIndex = currIndex;
            lastDigitOfTheSequence = arr[i + 1];
        }
    }
    else {
        currIndex = 1;
    }
}

var startIndex = lastDigitOfTheSequence - (maxIndex - 1);

for (var n = startIndex; n <= lastDigitOfTheSequence; n++) {
    console.log(n);
}
