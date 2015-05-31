/**
 * Problem 6. Most frequent number

 Write a script that finds the most frequent number in an array.
 */


var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 1, 1, 1, 2, 4, 9, 3];

mostFreq(arr);


function mostFreq(arr) {
    var i, j, currNumber, freq = 1, maxFreq = 0, theNumber;

    for (i = 0; i < arr.length; i++) {
        currNumber = arr[i];
        for (j = i + 1; j < arr.length; j++) {
            if (currNumber == arr[j]) {
                freq++;
            }
        }
        if (freq > maxFreq) {
            maxFreq = freq;
            theNumber = currNumber;
        }
        freq = 1;
    }
    console.log("The number is " + theNumber + " x " + maxFreq + " " + "times");
}